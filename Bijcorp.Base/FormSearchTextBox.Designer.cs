namespace Bijcorp.Base
{
    partial class FormSearchTextBox
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
            this.tbSearch = new DevExpress.XtraEditors.TextEdit();
            this.Cod_element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSearchField = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this._dataTable)).BeginInit();
            this.paSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchField.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paSuperior
            // 
            this.paSuperior.Controls.Add(this.cbSearchField);
            this.paSuperior.Controls.Add(this.tbSearch);
            this.paSuperior.Size = new System.Drawing.Size(541, 31);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(5, 6);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(219, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.EditValueChanged += new System.EventHandler(this.tbSearch_EditValueChanged);
            // 
            // Cod_element
            // 
            this.Cod_element.DataPropertyName = "Cod_element";
            this.Cod_element.HeaderText = "Código";
            this.Cod_element.Name = "Cod_element";
            this.Cod_element.ReadOnly = true;
            this.Cod_element.Width = 65;
            // 
            // Name_element
            // 
            this.Name_element.DataPropertyName = "Name_element";
            this.Name_element.HeaderText = "Nombre";
            this.Name_element.Name = "Name_element";
            this.Name_element.ReadOnly = true;
            this.Name_element.Width = 69;
            // 
            // cbSearchField
            // 
            this.cbSearchField.Location = new System.Drawing.Point(226, 6);
            this.cbSearchField.Name = "cbSearchField";
            this.cbSearchField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSearchField.Size = new System.Drawing.Size(151, 20);
            this.cbSearchField.TabIndex = 1;
            this.cbSearchField.SelectedIndexChanged += new System.EventHandler(this.cbSearchField_SelectedIndexChanged);
            // 
            // FormSearchTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 285);
            this.Name = "FormSearchTextBox";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.FormSearchTextBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataTable)).EndInit();
            this.paSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSearchField.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_element;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_element;
        public DevExpress.XtraEditors.ComboBoxEdit cbSearchField;
        public DevExpress.XtraEditors.TextEdit tbSearch;

    }
}