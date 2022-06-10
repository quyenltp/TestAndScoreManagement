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
    public partial class SystemForm : Form
    {
        
        public SystemForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();
           
            nd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyCauHoi ql = new QuanLyCauHoi();
            ql.Show();
        }
    }
}
