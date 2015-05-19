using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bijcorp.Base
{
    public partial class FormSearchTextBox : FormSearh
    {        

        public FormSearchTextBox()
        {
            InitializeComponent();                        
        }        

        private void tbSearch_EditValueChanged(object sender, EventArgs e)
        {            
            if (_dataTable.Columns.Contains(_fieldFilter))
                _dataView.RowFilter = String.Format(PatternStr, _fieldFilter, tbSearch.Text);
        }

        private void cbSearchField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchField.Text.Trim().Length > 0)
                _fieldFilter = cbSearchField.Text;
        }

        protected virtual void InitializeData()
        {
        }

        protected virtual void InitializeAppeareance()
        {
        }

        protected virtual void InitializeSearchField()
        {
        }

        private void FormSearchTextBox_Load(object sender, EventArgs e)
        {
            //inicializar data y apariencia
            Cursor.Current = Cursors.WaitCursor;

            if (cbSearchField.Properties.Items.Count == 0)
                InitializeSearchField();

            if (gvSearch.Columns.Count == 0)
                InitializeAppeareance();

            InitializeData();
            Cursor.Current = Cursors.Default;
        }
    }
}
