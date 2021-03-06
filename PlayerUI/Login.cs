using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAndScore.Data;

namespace TestAndScore
{
    public partial class Login : Form
    {

        TaiKhoan tk = new TaiKhoan();
        public static int loaitk;
        public static string ma_nguoi_dung;
        public string Get_Ma_Nguoi_Dung()
        {
            return ma_nguoi_dung;
        }
        public Login()
        {
            InitializeComponent();
            labelWarning.Hide();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Texts == "" || txtPassword.Texts == "")
            {
                MessageBox.Show("Thông tin chưa đầy đủ!\n Vui lòng nhập lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (tk.timkiem(txtUsername.Texts, txtPassword.Texts) == 1)
                {
                    //ma_nguoi_dung = new TaiKhoan().Ma_Nguoi_Dung(txtUsername.Texts);
                    MessageBox.Show("Chào Mừng " + txtUsername.Texts + " Đã Đến Với Phần Mềm Quản Lý Thi Và Chấm Thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm f = new MainForm();
                    f.cc(1);
                    f.phanquyen();
                    f.Show();
                    Hide();
                    //Close();
                }

                else if (tk.timkiem(txtUsername.Texts, txtPassword.Texts) == 2)
                {
                    //ma_nguoi_dung = new TaiKhoan().Ma_Nguoi_Dung(txtUsername.Texts);
                    MessageBox.Show("Chào Mừng == " + txtUsername.Texts + "== Đã Đến Với Phần Mềm Quản Lý Thi Và Chấm Thi");
                    MainForm f = new MainForm();
                    f.cc(2);
                    f.Show();
                    Hide();
                    //Close();
                }

                else
                {
                    if (MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!\nVui lòng nhập lại thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        txtUsername.Focus();
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
        private void ck1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                txtPassword.PasswordChar = false;
            else
                txtPassword.PasswordChar = true;
        }

    }
}
