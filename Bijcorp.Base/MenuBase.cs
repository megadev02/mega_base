using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace Bijcorp.Base
{
    public partial class MenuBase : XtraForm, INavigationMainMenu
    {
        private int _xmdi = 205;
        private int _ymdi = 75;
        List<LinkGroup> _linkGroups = new List<LinkGroup>(); 
        List<LinkModule> _linkModules = new List<LinkModule>();
        readonly FormLogin _fmLogin = new FormLogin();
        List<XtraForm> _genericViews = new List<XtraForm>();

        public string User { get; set; }
        public DateTime Date { get; set; }

        public List<LinkGroup> LinkGroups
        {
            get { return _linkGroups; }
            set { _linkGroups = value; }
        }

        public List<LinkModule> LinkModules
        {
            get { return _linkModules; }
            set { _linkModules = value; }
        }

        public MenuBase()
        {
            InitializeComponent();            
        }

        public int Xmdi
        {
            get { return _xmdi; }
            set { _xmdi = value; }
        }

        public int Ymdi {
            get { return _ymdi; }
            set { _ymdi = value; }
        }

        public void OpenMdi(IGenericView genericView)
        {
            genericView.NavigationMainMenu = this;
            CurrentPresenter = genericView.GetPresenter();
            var genericForm = (genericView as XtraForm);
            if (genericForm == null) return;
            
            //genericForm.DesktopLocation = new Point(100, 100);
            _genericViews.Add(genericForm);
            genericForm.Owner = this;
            genericForm.Show();
        }

        private void btFilter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrentPresenter.FilterMenuButton();
        }

        private void btSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrentPresenter.SearchMenuButton();
        }

        private void btNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrentPresenter.NewMenuButton();
        }

        private void btFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrentPresenter.FilterMenuButton();
        }

        private void btNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrentPresenter.NextMenuButton();
        }

        private void btLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrentPresenter.LastMenuButton();
        }

        public IGenericPresenter CurrentPresenter { get; set; }

        public void RefreshButtonConfig()
        {
            btFilter.Enabled = CurrentPresenter.FlagButtonFilter;
            btSearch.Enabled = CurrentPresenter.FlagButtonSearch;
            btNew.Enabled = CurrentPresenter.FlagButtonNew;
            btFirst.Enabled = CurrentPresenter.FlagButtonNavigation;
            btNext.Enabled = CurrentPresenter.FlagButtonNavigation;
            btPrevius.Enabled = CurrentPresenter.FlagButtonNavigation;
            btLast.Enabled = CurrentPresenter.FlagButtonNavigation;
        }

        public virtual void InitializeDicModules()
        {
        }

        public virtual void InitializeTreeMenu()
        {
        }

        public void InitializeModules()
        {
            InitializeDicModules();
            InitializeTreeMenu();

            navBarControl1.Groups.Clear();

            foreach (var linkGroup in _linkGroups)
            {
                var groupContainer = new NavBarGroupControlContainer();
                groupContainer.Size = new System.Drawing.Size(191, 76);
                var group = new NavBarGroup(linkGroup.Name);
                group.Tag = linkGroup.Id;
                group.GroupStyle = NavBarGroupStyle.ControlContainer;
                navBarControl1.Groups.Add(group);

                navBarControl1.Controls.Add(groupContainer);
                group.ControlContainer = groupContainer;
                group.Visible = true;
                group.GroupClientHeight = 200;

                var tree = new TreeList();
                tree.Dock = DockStyle.Fill;
                groupContainer.Controls.Add(tree);

                var linkModules = _linkModules.Where(x => x.Group.Id == linkGroup.Id).ToList();

                tree.DataSource = linkModules;
                tree.KeyFieldName = "Id";
                tree.ParentFieldName = "ParentId";

                for (int i = 0; i < tree.Columns.Count; i++)
                {
                    if (tree.Columns[i].FieldName == "Name")
                        tree.Columns[i].VisibleIndex = 0;
                    else
                        tree.Columns[i].VisibleIndex = -1;
                }

                tree.OptionsBehavior.Editable = false;
                tree.TreeLineStyle = LineStyle.None;
                tree.OptionsView.ShowHorzLines = false;
                tree.OptionsView.ShowColumns = false;
                tree.OptionsView.ShowIndicator = false;
                tree.OptionsView.ShowRoot = false;
                tree.OptionsView.ShowVertLines = false;
                tree.OptionsView.ShowIndentAsRowStyle = false;
                tree.ExpandAll();

                tree.MouseDoubleClick += tree_MouseDoubleClick;
            }
        }        

        void tree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var tree = sender as TreeList;
            if (tree == null) return;

            var modDelegate = tree.FocusedNode["View"] as Delegate;
            if (modDelegate != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                modDelegate.DynamicInvoke();
                Cursor.Current = Cursors.Default;
            }
        }

        public bool InitializeLogin(List<User> users)
        {                        
            _fmLogin.LoadUser(users);
            if (_fmLogin.ShowDialog() != DialogResult.OK) return false;



            bar2.Visible = true;
            barMenu.Visible = true;
            dockPanel1.Visibility = DockVisibility.Visible;            
            dockPanel2.Visibility = DockVisibility.AutoHide;
            

            return true;
        }

        private void MenuBase_Load(object sender, EventArgs e)
        {
            //dockPanel1.Visibility = DockVisibility.Hidden;
            //dockPanel2.Visibility = DockVisibility.Hidden;
            //bar1.Visible = false;
            //bar2.Visible = false;
        }

        private void btClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btOpenSession_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _fmLogin.Clear();

            if (_fmLogin.ShowDialog() != DialogResult.OK) return;
            
            bar2.Visible = true;            
            dockPanel1.Visibility = DockVisibility.Visible;
            dockPanel2.Visibility = DockVisibility.AutoHide;
        }

        private void btCloseSession_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bar2.Visible = false;            
            dockPanel1.Visibility = DockVisibility.Hidden;
            dockPanel2.Visibility = DockVisibility.Hidden;
            foreach (var genericView in _genericViews)
            {
                genericView.Close();
            }
        }
    }
}
