using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void DSCauHoi_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"LAPTOP-P3AC0C24\SQLEXPRESS;Initial Catalog=RADEVACHAMTHI;Integrated Security=True";
            con.Open();
            string sql = "select * from CAUHOI where maMH like '%" + a + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.DataSource = ch.laycauhoi(a).Tables[0];
            dataGridView1.Refresh();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        /*private void button1_Click(object sender, EventArgs e)
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
                            CH1 = dataGridView1.Rows[dong].Cells[3].Value.ToString();
                            mCH1 = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                            check++;
                            return;
                        }
                    case 1:
                        {
                            CH2 = dataGridView1.Rows[dong].Cells[3].Value.ToString();
                            mCH2 = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                            check++;
                            return;
                        }
                    case 2:
                        {
                            CH3 = dataGridView1.Rows[dong].Cells[3].Value.ToString();
                            mCH3 = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                            check++;
                            return;
                        }
                    case 3:
                        {
                            CH4 = dataGridView1.Rows[dong].Cells[3].Value.ToString();
                            mCH4 = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                            check++;
                            return;
                        }
                    case 4:
                        {
                            CH5 = dataGridView1.Rows[dong].Cells[3].Value.ToString();
                            mCH5 = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                            check++;
                            return;
                        }
                }
                soCau--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            closed = 1;
            Close();
        }*/

        private void btnThem_Click(object sender, EventArgs e)
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
                            CH1 = dataGridView1.Rows[dong].Cells[3].Value.ToString();
                            mCH1 = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                            check++;
                            return;
                        }
                    case 1:
                        {
                            CH2 = dataGridView1.Rows[dong].Cells[3].Value.ToString();
                            mCH2 = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                            check++;
                            return;
                        }
                    case 2:
                        {
                            CH3 = dataGridView1.Rows[dong].Cells[3].Value.ToString();
                            mCH3 = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                            check++;
                            return;
                        }
                    case 3:
                        {
                            CH4 = dataGridView1.Rows[dong].Cells[3].Value.ToString();
                            mCH4 = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                            check++;
                            return;
                        }
                    case 4:
                        {
                            CH5 = dataGridView1.Rows[dong].Cells[3].Value.ToString();
                            mCH5 = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                            check++;
                            return;
                        }
                }
                soCau--;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            closed = 1;
            Close();
        }

        private void DSCauHoi_Load_1(object sender, EventArgs e)
        {

        }
    }
}
