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
    public partial class SoanCauHoi : Form
    {
        CauHoi ch = new CauHoi();
        public SoanCauHoi()
        {
            InitializeComponent();
        }

        private string taoMaCH()
        {
            string a = "CH";
            if((ch.hienthi().Rows.Count + 1)<10)
            {
                a += "00" + (ch.hienthi().Rows.Count + 1);
            }
            if(((ch.hienthi().Rows.Count + 1)<100)&&((ch.hienthi().Rows.Count + 1) >= 10))
            {
                a += "0" + (ch.hienthi().Rows.Count + 1);
            }
            if(((ch.hienthi().Rows.Count + 1) >= 100))
            {
                a += (ch.hienthi().Rows.Count + 1);
            }
            return a;
        }
        private void customButton1_Click(object sender, EventArgs e)
        {

            //customComboBox2.DataTextField = ch.mamonhoc().Columns["maMH"].ToString();
            //customComboBox2.DataBindings;
            try
            {
                string dokho = customComboBox1.Texts;
                ch.them(taoMaCH(), customComboBox2.Texts, dokho, customTextBox1.Texts);
                MessageBox.Show("Thêm câu hỏi mới thành công");
            }
            catch
            {
                MessageBox.Show("Thêm câu hỏi mới thất bại");
            }

        }

        private void customComboBox2_Load(object sender, EventArgs e)
        {
            //customComboBox2.DataSource = ch.mamonhoc();
            for (int j = 0; j < ch.mamonhoc().Rows.Count; j++)

            {
                string text = ch.mamonhoc().Rows[j]["maMH"].ToString();
                this.customComboBox2.Items.Add(text);
            }
        }
    }
}
