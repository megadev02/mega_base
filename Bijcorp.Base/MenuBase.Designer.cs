namespace Bijcorp.Base
{
    partial class MenuBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btOpenSession = new DevExpress.XtraBars.BarButtonItem();
            this.btCloseSession = new DevExpress.XtraBars.BarButtonItem();
            this.btClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btFilter = new DevExpress.XtraBars.BarButtonItem();
            this.btSearch = new DevExpress.XtraBars.BarButtonItem();
            this.btNew = new DevExpress.XtraBars.BarButtonItem();
            this.btFirst = new DevExpress.XtraBars.BarButtonItem();
            this.btPrevius = new DevExpress.XtraBars.BarButtonItem();
            this.btNext = new DevExpress.XtraBars.BarButtonItem();
            this.btLast = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.SuspendLayout();            
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMenu,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btFilter,
            this.btSearch,
            this.btNew,
            this.btFirst,
            this.btNext,
            this.btLast,
            this.btPrevius,
            this.barSubItem1,
            this.btOpenSession,
            this.btCloseSession,
            this.btClose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 16;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barMenu
            // 
            this.barMenu.BarName = "Custom 2";
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Custom 2";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Inicio";
            this.barSubItem1.Id = 10;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btOpenSession),
            new DevExpress.XtraBars.LinkPersistInfo(this.btCloseSession),
            new DevExpress.XtraBars.LinkPersistInfo(this.btClose)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btOpenSession
            // 
            this.btOpenSession.Caption = "Iniciar sesión";
            this.btOpenSession.Id = 13;
            this.btOpenSession.Name = "btOpenSession";
            this.btOpenSession.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btOpenSession_ItemClick);
            // 
            // btCloseSession
            // 
            this.btCloseSession.Caption = "Cerrar sesión";
            this.btCloseSession.Id = 14;
            this.btCloseSession.Name = "btCloseSession";
            this.btCloseSession.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btCloseSession_ItemClick);
            // 
            // btClose
            // 
            this.btClose.Caption = "Salir";
            this.btClose.Id = 15;
            this.btClose.Name = "btClose";
            this.btClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btClose_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btFilter),
            new DevExpress.XtraBars.LinkPersistInfo(this.btSearch),
            new DevExpress.XtraBars.LinkPersistInfo(this.btNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.btFirst),
            new DevExpress.XtraBars.LinkPersistInfo(this.btPrevius),
            new DevExpress.XtraBars.LinkPersistInfo(this.btNext),
            new DevExpress.XtraBars.LinkPersistInfo(this.btLast)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 3";
            this.bar2.Visible = false;
            // 
            // btFilter
            // 
            this.btFilter.Caption = "Filter";
            this.btFilter.Glyph = global::Bijcorp.Base.Properties.Resources.filtro3;
            this.btFilter.Id = 0;
            this.btFilter.LargeImageIndex = 0;
            this.btFilter.Name = "btFilter";
            this.btFilter.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btFilter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btFilter_ItemClick);
            // 
            // btSearch
            // 
            this.btSearch.Caption = "Search";
            this.btSearch.Glyph = global::Bijcorp.Base.Properties.Resources.search;
            this.btSearch.Id = 1;
            this.btSearch.Name = "btSearch";
            this.btSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSearch_ItemClick);
            // 
            // btNew
            // 
            this.btNew.Caption = "New";
            this.btNew.Glyph = global::Bijcorp.Base.Properties.Resources._new;
            this.btNew.Id = 2;
            this.btNew.Name = "btNew";
            this.btNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btNew_ItemClick);
            // 
            // btFirst
            // 
            this.btFirst.Caption = "First";
            this.btFirst.Glyph = global::Bijcorp.Base.Properties.Resources.first;
            this.btFirst.Id = 3;
            this.btFirst.Name = "btFirst";
            this.btFirst.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btFirst_ItemClick);
            // 
            // btPrevius
            // 
            this.btPrevius.Caption = "Previus";
            this.btPrevius.Glyph = global::Bijcorp.Base.Properties.Resources.previus;
            this.btPrevius.Id = 6;
            this.btPrevius.Name = "btPrevius";
            this.btPrevius.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btNext
            // 
            this.btNext.Caption = "Next";
            this.btNext.Glyph = global::Bijcorp.Base.Properties.Resources.next;
            this.btNext.Id = 4;
            this.btNext.Name = "btNext";
            this.btNext.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btNext_ItemClick);
            // 
            // btLast
            // 
            this.btLast.Caption = "Last";
            this.btLast.Glyph = global::Bijcorp.Base.Properties.Resources.last;
            this.btLast.Id = 5;
            this.btLast.Name = "btLast";
            this.btLast.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btLast.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btLast_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 4";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Custom 4";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2,
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel2.ID = new System.Guid("5eb9e41c-9d09-4974-91b1-1914a8483e43");
            this.dockPanel2.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel2.SavedIndex = 0;
            this.dockPanel2.Size = new System.Drawing.Size(803, 200);
            this.dockPanel2.Text = "Mensajes";
            this.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(797, 172);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("cd97a1de-5c5f-4376-81df-d728dff37dcb");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.SavedIndex = 0;
            this.dockPanel1.Size = new System.Drawing.Size(200, 372);
            this.dockPanel1.Text = "Módulos";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(194, 344);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(194, 344);
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupClientHeight = 80;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(190, 248);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // MenuBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 464);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MenuBase";
            this.Text = "MenuBase";
            this.Load += new System.EventHandler(this.MenuBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar barMenu;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btFilter;
        private DevExpress.XtraBars.BarButtonItem btSearch;
        private DevExpress.XtraBars.BarButtonItem btNew;
        private DevExpress.XtraBars.BarButtonItem btFirst;
        private DevExpress.XtraBars.BarButtonItem btNext;
        private DevExpress.XtraBars.BarButtonItem btLast;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btPrevius;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        public DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btOpenSession;
        private DevExpress.XtraBars.BarButtonItem btCloseSession;
        private DevExpress.XtraBars.BarButtonItem btClose;
    }
}