using PlayerUI.CSDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestAndScore.Data;

namespace TestAndScore
{
    public partial class BaoCaoNam : Form
    {
        public BaoCaoNam()
        {
            InitializeComponent();
            //lb_Name.Text = new TaiKhoan().Ten_Nguoi_Dung(new Login().Get_Ma_Nguoi_Dung());
        }

        int han_muc_nam;
        int nam_bao_cao;
        int tong_de, tong_cham;
        Dethi listDeThi = new Dethi();
        Baicham listBaiCham = new Baicham();
        private void BaoCaoNam_Load(object sender, EventArgs e)
        {
            int current_year = DateTime.Now.Year;
            han_muc_nam = 70;
            for (int i = 1; i <= han_muc_nam; ++i)
            {
                cbx_Nam.Items.Add((current_year - i).ToString() + " - " + (current_year - i + 1).ToString());
            }
            cbx_Nam.SelectedIndex = 0;
        }

        bool check_request;

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
                if (cbx_Nam.SelectedIndex == 0)
                {
                    if (MessageBox.Show("Bạn chắc chắn đã tổng kết năm học " + cbx_Nam.Items[0].ToString() + " và thực hiện lập báo cáo?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }

                nam_bao_cao = DateTime.Now.Year - 1 - cbx_Nam.SelectedIndex;

                //Hiển thị tổng số bài chấm và tổng số bài thi
                tong_de = listDeThi.HienThiTheoNam(nam_bao_cao.ToString()).Rows.Count;
                tong_cham = listBaiCham.HienThiTheoNam(nam_bao_cao.ToString()).Rows.Count;
                lb_Tong_De.Text = tong_de.ToString();
                lb_Tong_Cham.Text = tong_cham.ToString();

                //Lập DataTable
                DataTable da = new DataTable();
                DataTable ds_mon = listBaiCham.DanhSachMonHoc();

                da.Columns.Add("Tên môn học", typeof(string));
                da.Columns.Add("Số lượng bài thi", typeof(int));
                da.Columns.Add("Số lượng bài chấm", typeof(int));
                da.Columns.Add("Tỉ lệ bài thi(%)", typeof(float));
                da.Columns.Add("Tỉ lệ bài chấm(%)", typeof(float));

                for (int i = 0; i < ds_mon.Rows.Count; ++i)
                {
                    int tong_de_mon, tong_cham_mon;
                    tong_de_mon = int.Parse(listBaiCham.SoLuongDeThiTheoMon(ds_mon.Rows[i]["maMH"].ToString(), nam_bao_cao.ToString()).Rows[0][0].ToString());
                    tong_cham_mon = int.Parse(listBaiCham.SoLuongBaiChamTheoMon(ds_mon.Rows[i]["maMH"].ToString(), nam_bao_cao.ToString()).Rows[0][0].ToString());

                    if (tong_de_mon == null) tong_de_mon = 0;
                    if (tong_cham_mon == null) tong_cham_mon = 0;

                    da.Rows.Add(ds_mon.Rows[i]["tenMH"].ToString(),
                                  tong_de_mon,
                                  tong_cham_mon,
                                  Math.Round((float)tong_de_mon * 100 / tong_de, 2),
                                  Math.Round((float)tong_cham_mon * 100 / tong_de, 2)
                                    );
                }

                dataGridViewBaoCaoNam.DataSource = da;

                dataGridViewBaoCaoNam.ReadOnly = true;

                dataGridViewBaoCaoNam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewBaoCaoNam.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
