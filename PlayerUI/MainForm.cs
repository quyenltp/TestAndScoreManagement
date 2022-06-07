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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelSoanThao.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_SoanDeThi_Click(object sender, EventArgs e)
        {
            openChildForm(new SoanDeThi());
            hideSubMenu();
        }

        private void btnSoan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSoanThao);
        }

        private void btnSoanCauHoi_Click(object sender, EventArgs e)
        {
            openChildForm(new SoanCauHoi());
            hideSubMenu();
        }

        private void btnChamThi_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
    }
}
