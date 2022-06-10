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
    public partial class BaoCaoNam : Form
    {
        public BaoCaoNam()
        {
            InitializeComponent();
        }

        int han_muc_nam = 70;

        private void BaoCaoNam_Load(object sender, EventArgs e)
        {
            int current_year = DateTime.Now.Year;
            for (int i = 1; i <= 70; ++i)
            {
                cbx_Nam.Items.Add(current_year - i);
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (cbx_Nam.Text == "")
            {
                MessageBox.Show("Vui lòng chọn năm báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

            }
        }
    }
}
