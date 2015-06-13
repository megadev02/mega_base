using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using System.ComponentModel;
using PopupControl;

namespace Bijcorp.Base
{
    [UserRepositoryItem("RegisterSearchButtonEdit")]
    public class RepositoryItemSearchButtonEdit : RepositoryItemButtonEdit
    {
        public const string SearchButtonEditName = "SearchButtonEdit";

        static RepositoryItemSearchButtonEdit() { RegisterSearchButtonEdit(); }

        public override string EditorTypeName { get { return SearchButtonEditName; } }

        public static void RegisterSearchButtonEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(SearchButtonEditName,
              typeof(SearchButtonEdit), typeof(RepositoryItemSearchButtonEdit),
              typeof(ButtonEditViewInfo), new ButtonEditPainter(), true, null));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemSearchButtonEdit source = (RepositoryItemSearchButtonEdit)item;
            }
            finally { EndUpdate(); }
        }        
    }

    public class SearchButtonEdit : ButtonEdit
    {
        #region attributes

        PopupGrid popupGrid = new PopupGrid();
        Popup popup = null;
        TypeTextChanged _typeTextChanged = TypeTextChanged.KeyPress;
        DisplayMember _displayMember = DisplayMember.FieldCode;
        
        public ItemTextList ItemSelected { get; set; }

        private List<ItemTextList> _list = new List<ItemTextList>();        

        public enum TypeTextChanged
        {
            AssignObject,
            KeyPress
        }

        public enum DisplayMember
        {
            FieldCode,
            FieldName
        }

        #endregion

        #region properties

        public object ItemId
        {
            get { return ItemSelected != null ? ItemSelected.Id : null; }
            set
            {
                ItemSelected = value == null ? null : _list.FirstOrDefault(x => x.Id.ToString() == value.ToString());
                _typeTextChanged = ItemSelected != null ? TypeTextChanged.AssignObject : TypeTextChanged.KeyPress;

                if (_displayMember == DisplayMember.FieldName)
                    Text = ItemSelected != null ? ItemSelected.Name : "";
                else
                    Text = ItemSelected != null ? ItemSelected.Code : "";
            }
        }

        public string ItemCode
        {
            get { return ItemSelected != null ? ItemSelected.Code : ""; }
        }

        public string ItemName
        {
            get { return ItemSelected != null ? ItemSelected.Name : ""; }
        }

        #endregion

        static SearchButtonEdit() { RepositoryItemSearchButtonEdit.RegisterSearchButtonEdit(); }

        public override string EditorTypeName { get { return RepositoryItemSearchButtonEdit.SearchButtonEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemSearchButtonEdit Properties { get { return (RepositoryItemSearchButtonEdit)base.Properties; } }

        #region override methods

        protected override void OnLoaded()
        {
            popup = new Popup(popupGrid);            
            popupGrid.OnSendKeyPress += popupGrid_OnSendKeyPress;
            popupGrid.DoubleClick += popupGrid_DoubleClick;            

            //agregando un un boton para abrir popup
            Properties.Buttons.Clear();

            Properties.Buttons.Add(new EditorButton()
            {
                Kind = ButtonPredefines.Combo,
                Visible = true
            });

            Properties.Buttons.Add(new EditorButton()
            {
                Kind = ButtonPredefines.Ellipsis,
                IsLeft = true,
                Visible = true,
                Shortcut = new KeyShortcut(Keys.F4)
            });
        }        

        void popupGrid_DoubleClick(object sender, EventArgs e)
        {
            ItemSelected = popupGrid.ItemSelected;

            if (_displayMember == DisplayMember.FieldName)
                Text = ItemSelected != null ? ItemSelected.Name : "";
            else
                Text = ItemSelected != null ? ItemSelected.Code : "";
            
            Focus();
            popup.Close();
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (!this.Properties.ReadOnly)
                this.BackColor = Color.LightYellow;
            
            //Properties.Buttons[1].Visible = true;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (!this.Properties.ReadOnly)
                this.BackColor = Color.White;
            
            if (Text.Length > 0)
            {
                //buscar código para recuperar data
                if (ItemSelected == null)
                {
                    ItemSelected = _list.FirstOrDefault(x => x.Code != null && x.Code.ToUpper() == Text.Trim().ToUpper());

                    _typeTextChanged = ItemSelected != null ? TypeTextChanged.AssignObject : TypeTextChanged.KeyPress;

                    if (ItemSelected == null)
                    {
                        ItemSelected = new ItemTextList();

                        if (_displayMember == DisplayMember.FieldName)
                            ItemSelected.Name = Text;
                        else
                            ItemSelected.Code = Text;
                    }
                    else
                    {
                        if (_displayMember == DisplayMember.FieldName)
                            Text = ItemSelected != null ? ItemSelected.Name : "";
                        else
                            Text = ItemSelected != null ? ItemSelected.Code : "";
                    }
                }
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Text.Trim().Length > 0 && popup != null && _typeTextChanged == TypeTextChanged.KeyPress)
            {
                popup.Show(this as ButtonEdit);
                //popupGrid.ItemSelected = null;
                //ItemSelected = null;
                popupGrid.Filter(Text);
                popupGrid.Focus();
            }
            else if (Text.Trim().Length == 0)
            {
                ItemSelected = null;
                popupGrid.ItemSelected = null;
            }
            else
            {
                _typeTextChanged = TypeTextChanged.KeyPress;
            }
        }

        protected override void OnClickButton(EditorButtonObjectInfoArgs buttonInfo)
        {
            base.OnClickButton(buttonInfo);

            if (buttonInfo.Button.Kind == ButtonPredefines.Combo)
            {
                popup.Show(this as ButtonEdit);
                popupGrid.Filter("");
                popupGrid.Focus();
            }
        }        

        #endregion

        #region methods

        public void Bind(List<ItemTextList> list, DisplayMember displayMember)
        {            
            _list = list;
            _displayMember = displayMember;
            popupGrid.Bind(list);
        }

        public void Bind(DataTable dt, DisplayMember displayMember)
        {
            _displayMember = displayMember;
            popupGrid.Bind(dt);
        }

        public void Clear()
        {
            ItemSelected = null;
            Text = "";
        }

        #endregion

        #region events

        void popupGrid_OnSendKeyPress(char key)
        {
            const string patternCharacter = "abcdefghijklmnopqrstuvwxyz0123456789-_+.* ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (patternCharacter.Contains(key))
            {
                Text += key;                
            }
            else if (key == Keys.Back.ToChar() && Text.Length > 1)
            {
                Text = Text.Substring(0, Text.Length - 1);
                popupGrid.ItemSelected = null;
                ItemSelected = null;
            }
            else if (key == Keys.Back.ToChar() && Text.Length == 1)
            {
                Text = "";
                popup.Close();
            }
            else if (key == Keys.Enter.ToChar() && popupGrid.ItemSelected != null)
            {
                ItemSelected = popupGrid.ItemSelected;

                if (_displayMember == DisplayMember.FieldName)
                    Text = ItemSelected != null ? ItemSelected.Name : "";
                else
                    Text = ItemSelected != null ? ItemSelected.Code : "";

                Focus();
                popup.Close();
            }
            else if (key == Keys.Enter.ToChar() && popupGrid.ItemSelected == null)
            {
                ItemSelected = null;
                Focus();
                popup.Close();
                SendKeys.Send("{ENTER}");
            }            
        }

        #endregion

    }

    public class ItemTextList
    {
        public object Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TextSearch
        {
            get { return Code + " - " + Name; }
        }
    }
}
