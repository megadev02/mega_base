using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bijcorp.Base
{
    public delegate void SendKeyPress(char key);

    public partial class PopupGrid : UserControl
    {
        DataTable _dataTable = new DataTable();
        DataView _dataView = new DataView();
        string _patternFilter = "TextSearch LIKE '%{0}%'";

        public event SendKeyPress OnSendKeyPress;
        public event EventHandler DoubleClick;

        private ItemTextList _itemSelected = null;

        public PopupGrid()
        {
            InitializeComponent();
        }

        public static DataTable ToDataTable<T>(IList<T> data)// T is any generic type
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

            var table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        public void Bind(List<ItemTextList> list)
        {
            _dataTable = ToDataTable(list);
            _dataView = _dataTable.DefaultView;
            gridControl1.DataSource = _dataView;
        } 
     
        public void Filter(string filterValue)
        {
            _dataView.RowFilter = string.Format(_patternFilter, filterValue);

            if (_dataView.Count == 0) ItemSelected = null;
        }

        public ItemTextList ItemSelected
        {
            get
            {
                _itemSelected = null;

                DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                if (dataRow != null)
                {
                    _itemSelected = new ItemTextList()
                    {
                        Id = Convert.ToInt32(dataRow["Id"]),
                        Code = dataRow["Code"].ToString(),
                        Name = dataRow["Name"].ToString()
                    };
                    return _itemSelected;
                }
                return _itemSelected;                
            }
            set { _itemSelected = value; }
        }

        public void Next()
        {
            gridView1.MoveNext();
        }

        public void Previus()
        {
            gridView1.MovePrev();
        }

        private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (OnSendKeyPress != null)
                OnSendKeyPress(e.KeyChar);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (DoubleClick != null)
                DoubleClick(sender, e);
        }        
    }    
}
