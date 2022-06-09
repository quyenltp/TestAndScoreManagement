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

namespace PlayerUI
{
    public partial class DSCauHoi : Form
    {
        CauHoi ch = new CauHoi();
        public DSCauHoi()
        {
            InitializeComponent();
        }

        private void DSCauHoi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ch.hienthi();
        }
    }
}
