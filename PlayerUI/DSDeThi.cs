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
    public partial class DSDeThi : Form
    {
        public DSDeThi()
        {
            InitializeComponent();
            FirstLoad();
        }

        Dethi a = new Dethi();
        string dieukien;

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
            dieukien = "";
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
                dataGridView_Danh_Sach_De_Thi.DataSource = a.HienThiTatCa().Tables[0];
            }
            else
            {
                dieukien = "";
                Duyet_Dieu_Kien();
                dataGridView_Danh_Sach_De_Thi.DataSource = a.HienThiChonLoc(dieukien).Tables[0];
            }


            dataGridView_Danh_Sach_De_Thi.ReadOnly = true;

            dataGridView_Danh_Sach_De_Thi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Danh_Sach_De_Thi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void checkBox_Lich_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Lich.Checked == true)
            {
                dtPicker_Ngay_Thi.Enabled = true;
            }
            else
            {
                dtPicker_Ngay_Thi.Enabled = false;
            }
        }


        private void Duyet_Dieu_Kien()
        {
            if (customTbx_Thoi_Luong.Texts != "") dieukien += "thoiluong = " + "'" + customTbx_Thoi_Luong.Texts + "'" + " AND ";
            if (customTbx_Nam_Hoc.Texts != "") dieukien += "namhoc = " + "'" + customTbx_Nam_Hoc.Texts + "'" + " AND ";
            if (customTbx_So_Cau_Hoi.Texts != "") dieukien += "socauhoi = " + "'" + customTbx_So_Cau_Hoi.Texts + "'" + " AND ";
            if (customTbx_Ma_De.Texts != "") dieukien += "maDT = " + "'" + customTbx_Ma_De.Texts + "'" + " AND ";
            if (customTbx_Ma_Mon.Texts != "") dieukien += "maMH = " + "'" + customTbx_Ma_Mon.Texts + "'" + " AND ";
            if (cbx_Hinh_Thuc.Text != "(Tất cả)") dieukien += "hinhthuc = " + "N'" + cbx_Hinh_Thuc.Text + "'" + " AND ";
            if (cbx_Hoc_Ki.Text != "(Tất cả)") dieukien += "hocki = " + "N'" + cbx_Hoc_Ki.Text + "'" + " AND ";
            if (dtPicker_Ngay_Thi.Enabled == true) dieukien += "thoiluong = " + "'" + dtPicker_Ngay_Thi.Value.ToString("MM/dd/yyyy") + "'" + " AND ";
            string str1 = "";
            for (int i = 0; i < dieukien.Length - 5; ++i)
            {
                str1 += dieukien[i];
            }
            dieukien = str1;
        }
    }
}
