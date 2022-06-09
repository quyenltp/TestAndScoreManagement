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
        static string a;
        static int dong;
        public string CH1;
        public string CH2;
        public string CH3;
        public string CH4;
        public string CH5;

        public string mCH1;
        public string mCH2;
        public string mCH3;
        public string mCH4;
        public string mCH5;
        int check = 0;
        int soCau;
        public int closed;

        public DSCauHoi(string somthing,int cauhoi)
        {
            a = somthing;
            soCau = cauhoi;
            InitializeComponent();
        }
        public DSCauHoi()
        {
            InitializeComponent();
        }

        private void DSCauHoi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ch.laycauhoi(a);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (soCau == 0)
            {
                return;
            }
            else
            {
                switch (check)
                {
                    case 0:
                        {
                            CH1 = dataGridView1.Rows[dong].Cells[7].Value.ToString();
                            mCH1 = dataGridView1.Rows[dong].Cells[4].Value.ToString();
                            check++;
                            return;
                        }
                    case 1:
                        {
                            CH2 = dataGridView1.Rows[dong].Cells[7].Value.ToString();
                            mCH2 = dataGridView1.Rows[dong].Cells[4].Value.ToString();
                            check++;
                            return;
                        }
                    case 2:
                        {
                            CH3 = dataGridView1.Rows[dong].Cells[7].Value.ToString();
                            mCH3 = dataGridView1.Rows[dong].Cells[4].Value.ToString();
                            check++;
                            return;
                        }
                    case 3:
                        {
                            CH4 = dataGridView1.Rows[dong].Cells[7].Value.ToString();
                            mCH4 = dataGridView1.Rows[dong].Cells[4].Value.ToString();
                            check++;
                            return;
                        }
                    case 4:
                        {
                            CH5 = dataGridView1.Rows[dong].Cells[7].Value.ToString();
                            check++;
                            return;
                        }
                }
                soCau--;
            }
        }

        private void changeCauhoi()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            closed = 1;
            Close();
        }
    }
}
