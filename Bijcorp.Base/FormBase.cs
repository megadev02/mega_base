using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bijcorp.Base.Annotations;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;

namespace Bijcorp.Base
{
    public partial class FormBase : XtraForm, IGenericView
    {
        private readonly Button _btNewButton = new Button();
        private readonly Button _btSearchButton = new Button();

        public GenericPresenter _genericPresenter;
        private INavigationMainMenu _navigationMainMenu;        

        public FormBase()
        {
            InitializeComponent();
            _btNewButton.Click += btNewButton_Click;
            _btSearchButton.Click += _btSearchButton_Click;
        }

        void _btSearchButton_Click(object sender, EventArgs e)
        {
            RaiseSearchButtonMenuClicked();
        }

        void btNewButton_Click(object sender, EventArgs e)
        {
            RaiseNewButtonMenuClicked();
        }        

        #region generic methods

        public INavigationMainMenu NavigationMainMenu
        {
            get { return _navigationMainMenu; }
            set
            {
                _navigationMainMenu = value;
                if (value != null)
                    _genericPresenter = new GenericPresenter(this, _navigationMainMenu);
            }
        }

        public Operation CurrentOperation
        {
            get
            {
                if (btOperation.Tag != null)
                {
                    if (btOperation.Tag.Equals(Operation.Add))
                        return Operation.Add;
                    if (btOperation.Tag.Equals(Operation.Search))
                        return Operation.Search;
                    if (btOperation.Tag.Equals(Operation.Update))
                        return Operation.Update;
                    if (btOperation.Tag.Equals(Operation.Ok))
                        return Operation.Ok;
                }
                return Operation.Nothing;
            }
            set
            {
                btOperation.Tag = value;
                paTitle.Visible = false;
                if (value == Operation.Add)
                    btOperation.Text = "Agregar";
                else if (value == Operation.Search)//ocasionado por filter
                {
                    btOperation.Text = "Buscar";
                    laTitle.Text = "FILTRAR BUSQUEDA";
                    paTitle.Visible = true;
                }
                else if (value == Operation.Update)
                    btOperation.Text = "Actualizar";
                else if (value == Operation.Ok)
                    btOperation.Text = "Ok";
            }
        }

        public Button NewMenuButton {
            get { return _btNewButton; }            
        }

        public Button SearchMenuButton {
            get { return _btSearchButton; }
        }

        public event EventHandler NewMenuButtonClicked;
        public event EventHandler SearchMenuButtonClicked;
        public event EventHandler AddClicked;
        public event EventHandler UpdateClicked;
        public event EventHandler SearchClicked;
        public event EventHandler CancelClicked;
        public event EventHandler OkClicked;
        public event EventHandler ActivatedFormClicked;
        
        public IGenericPresenter GetPresenter()
        {
            return _genericPresenter;
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) 
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void RaiseNewButtonMenuClicked()
        {
            EventHandler handlers = NewMenuButtonClicked;
            if (handlers != null)
            {
                handlers(this, EventArgs.Empty);
            }
        }

        protected virtual void RaiseSearchButtonMenuClicked()
        {
            EventHandler handlers = SearchMenuButtonClicked;
            if (handlers != null)
            {
                handlers(this, EventArgs.Empty);
            }
        }

        protected virtual void RaiseAddClicked()
        {
            EventHandler handlers = AddClicked;
            if (handlers != null)
            {
                handlers(this, EventArgs.Empty);
            }
        }

        protected virtual void RaiseSearchClicked()
        {
            EventHandler handlers = SearchClicked;
            if (handlers != null)
            {
                handlers(this, EventArgs.Empty);
            }
        }

        protected virtual void RaiseUpdateClicked()
        {
            EventHandler handlers = UpdateClicked;
            if (handlers != null)
            {
                handlers(this, EventArgs.Empty);
            }
        }

        protected virtual void RaiseCancelClicked()
        {
            EventHandler handlers = CancelClicked;
            if (handlers != null)
            {
                handlers(this, EventArgs.Empty);
            }
        }

        protected virtual void RaiseOkClicked()
        {
            EventHandler handlers = OkClicked;
            if (handlers != null)
            {
                handlers(this, EventArgs.Empty);
            }
        }

        private void FormBase_Activated(object sender, EventArgs e)
        {
            var nmm = this.Owner as INavigationMainMenu;
            nmm.CurrentPresenter = _genericPresenter;
            nmm.RefreshButtonConfig();
        }        

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btOperation_Click(object sender, EventArgs e)
        {            
            if (CurrentOperation == Operation.Add)
                RaiseAddClicked();
            else if (CurrentOperation == Operation.Search)
                RaiseSearchButtonMenuClicked();                            
            else if (CurrentOperation == Operation.Update)
                RaiseUpdateClicked();
            else if (CurrentOperation == Operation.Ok)
                RaiseOkClicked();
        }

        private void FormBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                SendKeys.Send("{TAB}");
        }

        private void FormBase_LocationChanged(object sender, EventArgs e)
        {
            var form = _navigationMainMenu as XtraForm;            
            if (form == null) return;
            if (Location.Y < 78)
                Location = new Point(form.DesktopLocation.X + 205, form.DesktopLocation.Y + 78);
        }              
    }
}
