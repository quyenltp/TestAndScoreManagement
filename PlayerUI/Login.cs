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
        }
        public static int loaitk;
        public static string matk;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
        }
    }
}
