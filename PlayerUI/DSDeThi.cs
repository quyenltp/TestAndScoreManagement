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
        Boolean isChecked;
        string ngaythi;

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
            checkBox_Lich.Checked = false;
            dtPicker_Ngay_Thi.Enabled = false;
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
            }    
            else
            {
                if (!isChecked) ngaythi = "";
                else ngaythi = dtPicker_Ngay_Thi.Value.ToString("MM/dd/yyyy");
                dataGridView_Danh_Sach_De_Thi.DataSource = a.HienThiChonLoc(customTbx_Ma_De.Texts, customTbx_Ma_Mon.Texts, cbx_Hinh_Thuc.Text, cbx_Hoc_Ki.Text, customTbx_Nam_Hoc.Texts, customTbx_Thoi_Luong.Texts, customTbx_So_Cau_Hoi.Texts, ngaythi);
            }


            dataGridView_Danh_Sach_De_Thi.ReadOnly = true;

            int totalRowHeight = dataGridView_Danh_Sach_De_Thi.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dataGridView_Danh_Sach_De_Thi.Rows)
                totalRowHeight += row.Height;
            dataGridView_Danh_Sach_De_Thi.Height = totalRowHeight;
            this.Height = dataGridView_Danh_Sach_De_Thi.Height + 100;

            dataGridView_Danh_Sach_De_Thi.AutoResizeColumns();
            dataGridView_Danh_Sach_De_Thi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void checkBox_Lich_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Lich.Checked == true)
            {
                dtPicker_Ngay_Thi.Enabled = isChecked = true;
            }
            else
            {
                dtPicker_Ngay_Thi.Enabled = isChecked = false;
            }
        }
    }
}
