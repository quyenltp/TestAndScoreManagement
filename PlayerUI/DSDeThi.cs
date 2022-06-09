using PlayerUI.CSDL;
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
    public partial class DSDeThi : Form
    {
        public DSDeThi()
        {
            InitializeComponent();
            FirstLoad();
        }

        DanhSachDeThi a = new DanhSachDeThi();

        private void Check_Tuy_Chon()
        {
            if (radioButton_Tat_Ca.Checked == true) panel_Selection.Enabled = false;
            else
            {
                panel_Selection.Enabled = true;
            }
        }

        private void FirstLoad()
        {
            dtPicker_Ngay_Thi.Value = DateTime.Now;
            cbx_Hinh_Thuc.SelectedIndex = cbx_Hoc_Ki.SelectedIndex = 0;
            Check_Tuy_Chon();
        }

        private void radioButton_Tat_Ca_CheckedChanged(object sender, EventArgs e)
        {
            Check_Tuy_Chon();
        }

        private void customBtn_Tra_Cuu_Click(object sender, EventArgs e)
        {
            if (radioButton_Tat_Ca.Checked == true)
            {
                dataGridView_Danh_Sach_De_Thi.DataSource = a.HienThiTatCa();
                dataGridView_Danh_Sach_De_Thi.ReadOnly = true;

                /*int totalRowHeight = dataGridView_Danh_Sach_De_Thi.ColumnHeadersHeight;
                foreach (DataGridViewRow row in dataGridView_Danh_Sach_De_Thi.Rows)
                    totalRowHeight += row.Height;
                dataGridView_Danh_Sach_De_Thi.Height = totalRowHeight;
                this.Height = dataGridView_Danh_Sach_De_Thi.Height + 100;*/

                dataGridView_Danh_Sach_De_Thi.AutoResizeColumns();
                dataGridView_Danh_Sach_De_Thi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }    
            else
            {
                panel_Selection.Enabled = true;
            }
        }
    }
}
