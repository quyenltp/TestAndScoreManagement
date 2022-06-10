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
    public partial class QuanLyCauHoi : Form
    {
        CauHoi tk = new CauHoi();
        public QuanLyCauHoi()
        {
            InitializeComponent();
        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tk.hienthi();
            //dataGridView1.Column
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tk.them(textBox1.Text, textBox2.Text, textBox3.Text, (richTextBox1.Text));
                MessageBox.Show("Thêm thành công");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                richTextBox1.Text = "";
                NguoiDung_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Đã tồn tại tài khoản");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa tài khoản không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tk.sua(textBox1.Text, textBox2.Text, textBox3.Text);
                    MessageBox.Show("Sửa tài khoản thành công");
                    NguoiDung_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không đúng\nSửa tài khoản thành công");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
                MessageBox.Show("Bạn cần chọn Tài Khoản để xóa");
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    tk.xoa(textBox1.Text);
                    MessageBox.Show("Đã xóa thành công");
                    NguoiDung_Load(sender, e);
                }
            }
        }
    }
}
