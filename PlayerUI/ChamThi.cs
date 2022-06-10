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
    public partial class ChamThi : Form
    {
        Chamthi ct = new Chamthi();
        public ChamThi()
        {
            InitializeComponent();
            //comboBox4.DataSource = a.hienthithisinh();
            //comboBox4.DisplayMember = "mssv";
            //AddBinding();
        }
        //Chamthi a = new Chamthi();
        private void ChamThi_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource = a.hienthilop();
            //comboBox2.DataSource = a.hienthimonthi();
            //comboBox3.DataSource = a.hienthigiangvien();
            //comboBox2.DisplayMember = "tenMH";
            //comboBox1.DisplayMember = "tenlop";
            //comboBox3.DisplayMember = "tenGV";

        }
        void AddBinding()
        {
            //customTextBox5.DataBindings.Add(new Binding("Texts", comboBox4.DataSource, "hoten"));
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            //customComboBox2.DataTextField = ch.mamonhoc().Columns["maMH"].ToString();
            //customComboBox2.DataBindings;
            try
            {
                float b = float.Parse(customTextBox6.Texts);
                ct.them(customTextBox1.Texts, b, customTextBox7.Texts, customTextBox8.Texts, customTextBox5.Texts);
                MessageBox.Show("Thêm chấm thi mới thành công");

            }
            catch
            {
                MessageBox.Show("Thêm chấm thi mới thất bại");
            }

        }

        private void customComboBox4_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < ct.hienthimonthi().Rows.Count; j++)

            {
                string text = ct.hienthimonthi().Rows[j]["tenMH"].ToString();
                this.customComboBox4.Items.Add(text);
            }
        }

        private void customComboBox2_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < ct.hienthilop().Rows.Count; j++)

            {
                string text = ct.hienthilop().Rows[j]["tenlop"].ToString();
                this.customComboBox2.Items.Add(text);
            }
        }

        private void customComboBox3_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < ct.hienthigiangvien().Rows.Count; j++)

            {
                string text = ct.hienthigiangvien().Rows[j]["tenGV"].ToString();
                this.customComboBox3.Items.Add(text);
            }
        }
    }
}
