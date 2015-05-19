namespace Bijcorp.Base
{
    partial class FormBase
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
            this.paOperation = new DevExpress.XtraEditors.PanelControl();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btOperation = new DevExpress.XtraEditors.SimpleButton();
            this.paData = new DevExpress.XtraEditors.PanelControl();
            this.paTitle = new DevExpress.XtraEditors.PanelControl();
            this.laTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).BeginInit();
            this.paOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // paOperation
            // 
            this.paOperation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paOperation.Controls.Add(this.btCancel);
            this.paOperation.Controls.Add(this.btOperation);
            this.paOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paOperation.Location = new System.Drawing.Point(0, 283);
            this.paOperation.Name = "paOperation";
            this.paOperation.Size = new System.Drawing.Size(409, 39);
            this.paOperation.TabIndex = 1;
            this.paOperation.Text = "panelControl1";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(83, 7);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancelar";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOperation
            // 
            this.btOperation.Location = new System.Drawing.Point(5, 7);
            this.btOperation.Name = "btOperation";
            this.btOperation.Size = new System.Drawing.Size(75, 23);
            this.btOperation.TabIndex = 0;
            this.btOperation.Text = "Operation";
            this.btOperation.Click += new System.EventHandler(this.btOperation_Click);
            // 
            // paData
            // 
            this.paData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paData.Location = new System.Drawing.Point(0, 22);
            this.paData.Name = "paData";
            this.paData.Size = new System.Drawing.Size(409, 261);
            this.paData.TabIndex = 0;
            this.paData.Text = "panelControl1";
            // 
            // paTitle
            // 
            this.paTitle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(109)))));
            this.paTitle.Appearance.Options.UseBackColor = true;
            this.paTitle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paTitle.Controls.Add(this.laTitle);
            this.paTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTitle.Location = new System.Drawing.Point(0, 0);
            this.paTitle.Name = "paTitle";
            this.paTitle.Size = new System.Drawing.Size(409, 22);
            this.paTitle.TabIndex = 2;
            this.paTitle.Text = "panelControl1";
            this.paTitle.Visible = false;
            // 
            // laTitle
            // 
            this.laTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.laTitle.ForeColor = System.Drawing.Color.White;
            this.laTitle.Location = new System.Drawing.Point(0, 0);
            this.laTitle.Name = "laTitle";
            this.laTitle.Padding = new System.Windows.Forms.Padding(3, 4, 0, 0);
            this.laTitle.Size = new System.Drawing.Size(409, 22);
            this.laTitle.TabIndex = 0;
            this.laTitle.Text = "FILTRAR BUSQUEDA";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 322);
            this.Controls.Add(this.paData);
            this.Controls.Add(this.paTitle);
            this.Controls.Add(this.paOperation);
            this.KeyPreview = true;
            this.Name = "FormBase";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FormBase";
            this.Activated += new System.EventHandler(this.FormBase_Activated);
            this.LocationChanged += new System.EventHandler(this.FormBase_LocationChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormBase_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.paOperation)).EndInit();
            this.paOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.PanelControl paOperation;
        protected DevExpress.XtraEditors.PanelControl paData;
        protected DevExpress.XtraEditors.SimpleButton btCancel;
        protected DevExpress.XtraEditors.SimpleButton btOperation;
        private DevExpress.XtraEditors.PanelControl paTitle;
        private System.Windows.Forms.Label laTitle;
    }
}