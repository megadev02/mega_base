namespace Bijcorp.Base
{
    partial class FormSearh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearh));
            this.paSuperior = new System.Windows.Forms.Panel();
            this.paSup = new System.Windows.Forms.Panel();
            this.gcSearch = new DevExpress.XtraGrid.GridControl();
            this.gvSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.paBotonesSelGrupo = new System.Windows.Forms.Panel();
            this.btSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.paSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).BeginInit();
            this.paBotonesSelGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // paSuperior
            // 
            this.paSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSuperior.Location = new System.Drawing.Point(0, 0);
            this.paSuperior.Name = "paSuperior";
            this.paSuperior.Size = new System.Drawing.Size(541, 48);
            this.paSuperior.TabIndex = 3;
            // 
            // paSup
            // 
            this.paSup.Controls.Add(this.gcSearch);
            this.paSup.Controls.Add(this.paBotonesSelGrupo);
            this.paSup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paSup.Location = new System.Drawing.Point(0, 48);
            this.paSup.Name = "paSup";
            this.paSup.Size = new System.Drawing.Size(541, 237);
            this.paSup.TabIndex = 4;
            // 
            // gcSearch
            // 
            this.gcSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gcSearch.EmbeddedNavigator.Name = "";
            this.gcSearch.Location = new System.Drawing.Point(0, 0);
            this.gcSearch.MainView = this.gvSearch;
            this.gcSearch.Name = "gcSearch";
            this.gcSearch.Size = new System.Drawing.Size(541, 200);
            this.gcSearch.TabIndex = 5;
            this.gcSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSearch});
            // 
            // gvSearch
            // 
            this.gvSearch.GridControl = this.gcSearch;
            this.gvSearch.Name = "gvSearch";
            this.gvSearch.OptionsBehavior.Editable = false;
            this.gvSearch.OptionsView.ShowGroupPanel = false;
            this.gvSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvSearch_KeyDown);
            this.gvSearch.DoubleClick += new System.EventHandler(this.gvSearch_DoubleClick);
            // 
            // paBotonesSelGrupo
            // 
            this.paBotonesSelGrupo.Controls.Add(this.btSalir);
            this.paBotonesSelGrupo.Controls.Add(this.btOk);
            this.paBotonesSelGrupo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBotonesSelGrupo.Location = new System.Drawing.Point(0, 200);
            this.paBotonesSelGrupo.Name = "paBotonesSelGrupo";
            this.paBotonesSelGrupo.Size = new System.Drawing.Size(541, 37);
            this.paBotonesSelGrupo.TabIndex = 4;
            this.paBotonesSelGrupo.Visible = false;
            // 
            // btSalir
            // 
            this.btSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSalir.Location = new System.Drawing.Point(484, 6);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(46, 23);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "Salir";
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(6, 6);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(40, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "Ok";
            this.btOk.Click += new System.EventHandler(this.buOk_Click);
            // 
            // FormSearh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 285);
            this.Controls.Add(this.paSup);
            this.Controls.Add(this.paSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearh";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Datos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSearh_Load);
            this.paSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).EndInit();
            this.paBotonesSelGrupo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paSup;
        private System.Windows.Forms.Panel paBotonesSelGrupo;
        private System.Windows.Forms.Button buCancelar;
        protected System.Windows.Forms.Panel paSuperior;
        protected DevExpress.XtraEditors.SimpleButton btSalir;
        protected DevExpress.XtraEditors.SimpleButton btOk;
        public DevExpress.XtraGrid.GridControl gcSearch;
        public DevExpress.XtraGrid.Views.Grid.GridView gvSearch;

    }
}