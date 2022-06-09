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

        private void btnLuuDeThi_Click(object sender, EventArgs e)
        {
            try
            {
                dt.them("DT" + (dt.hienthi().Rows.Count + 1).ToString(), "môn học", 1, "2022", Int32.Parse(txtThoiLuong.Texts), "CH5", "KH008");
                MessageBox.Show("Thêm câu hỏi mới thành công");
            }
            catch
            {
                MessageBox.Show("Thêm câu hỏi mới thất bại");
            }
            dt.them("DT" + (dt.hienthi().Rows.Count + 1).ToString(), "môn học", 1, "2022", Int32.Parse(txtThoiLuong.Texts), "CH5","KH008");
            MessageBox.Show("Thêm câu hỏi mới thành công");
        }
    }

}
