using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAndScore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            labelWarning.Hide();
        }
              
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.PlaceholderText = "";
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.PlaceholderText = "Tên đăng nhập";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.PlaceholderText = "";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.PlaceholderText = "Mật khẩu";
        }
    }
}
