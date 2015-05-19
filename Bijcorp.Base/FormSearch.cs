using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Bijcorp.Base
{    
    public partial class FormSearh : DevExpress.XtraEditors.XtraForm
    {        
        #region Atributos
        protected string _fieldId;
        protected string _fieldFilter = "";
        protected const string PatternStr = "{0} like '%{1}%'";
        protected DataTable _dataTable = new DataTable();
        protected DataView _dataView = null;
        public KeyType _KeyType = KeyType.Int;

        #endregion

        public enum KeyType
        {
            Int,
            String
        }

        #region Propiedades
        
        public object FieldIdValue { get; set; }
        
        #endregion

        #region Metodos
        public FormSearh()
        {
            InitializeComponent();                                   
        }

        public void InitializeData(string fieldId, string fieldFilter, DataTable dataTable)
        {
            _fieldId = fieldId;
            _fieldFilter = fieldFilter;
            _dataTable = dataTable;
            _dataView = _dataTable.DefaultView;
            gcSearch.DataSource = _dataView;
        }

        #endregion             

        #region eventos

        private void buOk_Click(object sender, EventArgs e)
        {            
            FieldIdValue = Convert.ToInt32(gvSearch.GetRowCellValue(gvSearch.FocusedRowHandle, _fieldId));
            this.DialogResult = DialogResult.OK;
        }        

        private void FormSearh_Load(object sender, EventArgs e)
        {            
        }

        private void gvSearch_DoubleClick(object sender, EventArgs e)
        {
            if (_KeyType == KeyType.Int)
                FieldIdValue = Convert.ToInt32(gvSearch.GetRowCellValue(gvSearch.FocusedRowHandle, _fieldId));
            else
                FieldIdValue = Convert.ToString(gvSearch.GetRowCellValue(gvSearch.FocusedRowHandle, _fieldId));
            this.DialogResult = DialogResult.OK;
        }

        private void gvSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FieldIdValue = Convert.ToInt32(gvSearch.GetRowCellValue(gvSearch.FocusedRowHandle, _fieldId));
                this.DialogResult = DialogResult.OK;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        #endregion
    }
}