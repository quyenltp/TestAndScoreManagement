using PlayerUI;
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
    public partial class SoanDeThi : Form
    {
        Dethi dt = new Dethi();
        public SoanDeThi()
        {
            InitializeComponent();
        }

        private void btnDSCauHoi_Click(object sender, EventArgs e)
        {
            DSCauHoi dsCauhoi = new DSCauHoi();
            dsCauhoi.Show();
        }

        private string taoMaDT()
        {
            string a = "CH";
            if ((dt.hienthi().Rows.Count + 1) < 10)
            {
                a += "00" + (dt.hienthi().Rows.Count + 1);
            }
            if (((dt.hienthi().Rows.Count + 1) < 100) && ((dt.hienthi().Rows.Count + 1) >= 10))
            {
                a += "0" + (dt.hienthi().Rows.Count + 1);
            }
            if (((dt.hienthi().Rows.Count + 1) >= 100))
            {
                a += (dt.hienthi().Rows.Count + 1);
            }
            return a;
        }

        private void btnLuuDeThi_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Today;
            if((Int32.Parse(txtThoiLuong.Texts)<30)||(Int32.Parse(txtThoiLuong.Texts)>180))
            {
                MessageBox.Show("Thời lượng thi không đúng, cần phải nhỏ hơn 180p và lớn hơn 30p");
                return;
            }
            try
            {
                dt.them(taoMaDT(),customComboBox1.Texts, comboBoxHinhThucThi.Texts, comboBoxHocKy.Texts, Int32.Parse(txtNamHoc.Texts), Int32.Parse(txtThoiLuong.Texts), Int32.Parse(comboBoxLanThi.Texts), dateTime);
                MessageBox.Show("Thêm câu hỏi mới thành công");
            }
            catch
            {
                MessageBox.Show("Thêm câu hỏi mới thất bại");
            }
            //dt.them(taoMaDT(), "môn học", comboBoxHinhThucThi.Texts, comboBoxHocKy.Texts, Int32.Parse(txtNamHoc.Texts), Int32.Parse(txtThoiLuong.Texts), Int32.Parse(comboBoxLanThi.Texts), dateTime);
            //MessageBox.Show("Thêm câu hỏi mới thành công");
        }

        private void customComboBox1_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < dt.mamonhoc().Rows.Count; j++)

            {
                string text = dt.mamonhoc().Rows[j]["maMH"].ToString();
                this.customComboBox1.Items.Add(text);
            }
        }
    }

}
