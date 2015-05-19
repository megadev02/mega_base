using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Bijcorp.Base
{
    public partial class FormLogin : XtraForm
    {        
        private List<User> _users = null;   

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                SendKeys.Send("{TAB}");
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (_users.Count == 0)
                MessageBox.Show("No existen usuarios en la base de datos");
            else
            {
                if (!_users.Exists(x => x.Name.Trim().ToUpper() == tbUser.Text.Trim().ToUpper()))
                    MessageBox.Show("No existe el usuario");
                else
                {
                    var user = _users.FirstOrDefault(x => x.Name.Trim().ToUpper() == tbUser.Text.Trim().ToUpper());
                    string contrasenia = Utilities.EncriptarMD5(tbPwd.Text);
                    if (user != null && user.Pwd.ToUpper() == contrasenia)
                    {
                        Global.UserLogin = user;
                        DialogResult = DialogResult.OK;
                        return;
                    }
                }                
                Global.UserLogin = null;                
            }
            DialogResult = DialogResult.Cancel;
        }

        public void LoadUser(List<User> users)
        {
            _users = users;
        }

        public void Clear()
        {
            tbUser.Text = "";
            tbPwd.Text = "";
            tbUser.Focus();
        }
    }
}
