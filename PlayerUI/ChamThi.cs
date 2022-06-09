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
    public partial class ChamThi : Form
    {
        public ChamThi()
        {
            InitializeComponent();
        }

        Color backColor, foreColor;

        private void btnTraCuu_KQ_Cham_Thi_MouseLeave(object sender, EventArgs e)
        {
            btnTraCuu_KQ_Cham_Thi.BackColor = backColor;
            btnTraCuu_KQ_Cham_Thi.ForeColor = foreColor;
        }

        private void btnTraCuu_KQ_Cham_Thi_Click(object sender, EventArgs e)
        {
            if (listGiangVien.Text == "" || listLop.Text == "" || listMonHoc.Text== "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }    
        }

        private void btnTraCuu_KQ_Cham_Thi_MouseHover(object sender, EventArgs e)
        {
            backColor = btnTraCuu_KQ_Cham_Thi.BackColor;
            foreColor = btnTraCuu_KQ_Cham_Thi.ForeColor;

            btnTraCuu_KQ_Cham_Thi.BackColor = Color.Cyan;
            btnTraCuu_KQ_Cham_Thi.ForeColor = Color.Gray;
        }
    }
}
