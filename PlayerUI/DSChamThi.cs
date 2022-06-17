using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestAndScore
{
    public partial class DSChamThi : Form
    {
        public DSChamThi()
        {
            InitializeComponent();
        }


        private void DSChamThi_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-PUO8CB7\MINHPHAM;Initial Catalog=RADEVACHAMTHI_;Integrated Security=True";
            con.Open();
            string sql = "SELECT * FROM KETQUATHI FULL OUTER JOIN THISINH ON KETQUATHI.mssv = THISINH.mssv";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
        }
    }
}
