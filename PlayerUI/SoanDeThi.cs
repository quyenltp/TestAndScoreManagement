using PlayerUI;
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
    public partial class SoanDeThi : Form
    {
        Dethi dt = new Dethi();
        DSCauHoi dsCauhoi;
        public SoanDeThi()
        {           
            InitializeComponent();
        }

        private void btnDSCauHoi_Click(object sender, EventArgs e)
        {
            if (comboBoxLanThi.Texts == "")
            {
                MessageBox.Show("Hãy chọn số câu hỏi trước.");
                return;
            }
            else
            {
                dsCauhoi = new DSCauHoi(customComboBox1.Texts, Int32.Parse(comboBoxLanThi.Texts));
                dsCauhoi.Show();
                switch(Int32.Parse(comboBoxLanThi.Texts))
                {
                    case 1:
                        {
                            label6.Visible = true;
                            label7.Visible = false;
                            label8.Visible = false;
                            label9.Visible = false;
                            label10.Visible = false;
                            return;
                        }
                    case 2:
                        {
                            label6.Visible = true;
                            label7.Visible = true;
                            label8.Visible = false;
                            label9.Visible = false;
                            label10.Visible = false;
                            return;
                        }
                    case 3:
                        {
                            label6.Visible = true;
                            label7.Visible = true;
                            label8.Visible = true;
                            label9.Visible = false;
                            label10.Visible = false;
                            return;
                        }
                    case 4:
                        {
                            label6.Visible = true;
                            label7.Visible = true;
                            label8.Visible = true;
                            label9.Visible = true;
                            label10.Visible = false;
                            return;
                        }
                    case 5:
                        {
                            label6.Visible = true;
                            label7.Visible = true;
                            label8.Visible = true;
                            label9.Visible = true;
                            label10.Visible = true;
                            return;
                        }
                }
            }
        }

        private string taoMaDT()
        {
            string a = "CH";
            if ((dt.hienthi().Rows.Count + 1) < 10)
            {
                a += "00" + (dt.hienthi().Rows.Count + 1);
            }
            if (((dt.hienthi().Rows.Count + 1) < 100) && ((dt.hienthi().Rows.Count + 1) >= 10))
            {
                a += "0" + (dt.hienthi().Rows.Count + 1);
            }
            if (((dt.hienthi().Rows.Count + 1) >= 100))
            {
                a += (dt.hienthi().Rows.Count + 1);
            }
            return a;
        }

        private int checkVisi()
        {
            int a = 0;
            if(label15.Visible == true)
            {
                a++;
            }
            if (label16.Visible == true)
            {
                a++;
            }
            if (label17.Visible == true)
            {
                a++;
            }
            if (label18.Visible == true)
            {
                a++;
            }
            if (label19.Visible == true)
            {
                a++;
            }
            return a;
        }

        private string Helpme(int i)
        {
            string a = "";
            int check = 0;
            if(i == 1)
            {
                return dsCauhoi.mCH1;
            }
            if (i == 2)
            {
                if(dsCauhoi.mCH2 == dsCauhoi.mCH1)
                {
                    check = 1;
                    return a;
                }
                return dsCauhoi.mCH2;
            }
            if (i == 3)
            {
                if ((dsCauhoi.mCH3 == dsCauhoi.mCH2)||(dsCauhoi.mCH3 == dsCauhoi.mCH1))
                {
                    check = 1;
                    return a;
                }
                return dsCauhoi.mCH3;
            }
            if (i == 4)
            {
                if ((dsCauhoi.mCH4 == dsCauhoi.mCH3) || (dsCauhoi.mCH4 == dsCauhoi.mCH1)||(dsCauhoi.mCH4 == dsCauhoi.mCH2))
                {
                    check = 1;
                    return a;
                }
                return dsCauhoi.mCH4;
            }
            if (i == 5)
            {
                if ((dsCauhoi.mCH5 == dsCauhoi.mCH2) || (dsCauhoi.mCH5 == dsCauhoi.mCH1)|| (dsCauhoi.mCH5 == dsCauhoi.mCH3) || (dsCauhoi.mCH5 == dsCauhoi.mCH4))
                {
                    check = 1;
                    return a;
                }
                return dsCauhoi.mCH5;
            }            
            return a;
        }
        private void btnLuuDeThi_Click(object sender, EventArgs e)
        {
            int a = 0;
            if((customComboBox1.Texts =="")||(comboBoxHinhThucThi.Texts == "") ||(comboBoxHocKy.Texts == "") ||(comboBoxLanThi.Texts == "") ||(txtNamHoc.Texts == "")||(txtThoiLuong.Texts == ""))
            {
                MessageBox.Show("Cần nhập thông tin đầy đủ");
                return; }
            if (txtThoiLuong.Texts != "")
            {
                if ((Int32.Parse(txtThoiLuong.Texts) < 30) || (Int32.Parse(txtThoiLuong.Texts) > 180))
                {
                    MessageBox.Show("Thời lượng thi không đúng, cần phải nhỏ hơn 180p và lớn hơn 30p");
                    return;
                }
            }
            if (txtNamHoc.Texts != "")
            {
                if ((Int32.Parse(txtNamHoc.Texts) < 2000) || (Int32.Parse(txtThoiLuong.Texts) > 2030))
                {
                    MessageBox.Show("Năm học không đúng yêu cầu nhập lại");
                    return;
                }
            }
            if (label6.Text == "")
            {
                MessageBox.Show("Chưa chọn câu hỏi");
                return;
            }  
            if(Int32.Parse(comboBoxLanThi.Texts) != checkVisi() )
            {
                MessageBox.Show("Chưa chọn đủ câu hỏi");
                return;
            }
            try
            {
                dt.them(taoMaDT(), customComboBox1.Texts, comboBoxHinhThucThi.Texts, comboBoxHocKy.Texts, Int32.Parse(txtNamHoc.Texts), Int32.Parse(txtThoiLuong.Texts), Int32.Parse(comboBoxLanThi.Texts), dateTimePicker1.Value);
                for (int i = 0; i < Int32.Parse(comboBoxLanThi.Texts); i++)
                {
                    if (Helpme(i + 1) == "")
                    {
                        a = 1;
                    }
                }
                if (a == 0)
                {
                    for (int i = 0; i < Int32.Parse(comboBoxLanThi.Texts); i++)
                    {

                        dt.themChitietde(taoMaDT(), Helpme(i + 1), i + 1);
                    }
                    MessageBox.Show("Thêm đề thi mới thành công");
                }
                else
                {
                    MessageBox.Show("Có câu hỏi bị trùng.");
                }
            }
            catch
            {
                MessageBox.Show("Thêm đề thi mới thất bại");
            }
            //dt.them(taoMaDT(), "môn học", comboBoxHinhThucThi.Texts, comboBoxHocKy.Texts, Int32.Parse(txtNamHoc.Texts), Int32.Parse(txtThoiLuong.Texts), Int32.Parse(comboBoxLanThi.Texts), dateTime);
            //MessageBox.Show("Thêm câu hỏi mới thành công");
        }

        private void customComboBox1_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < dt.mamonhoc().Rows.Count; j++)

            {
                string text = dt.mamonhoc().Rows[j]["maMH"].ToString();
                this.customComboBox1.Items.Add(text);
            }
        }

        private void SoanDeThi_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            linkLabel1.Visible = false;
            
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if ((comboBoxLanThi.Texts != "")&& (label6.Visible == true))
            {
                if((dsCauhoi.closed == 1)&&(label6.Visible == true))
                {
                    switch (Int32.Parse(comboBoxLanThi.Texts))
                    {
                        case 1:
                            {
                                label6.Visible = true;
                                label7.Visible = false;
                                label8.Visible = false;
                                label9.Visible = false;
                                label10.Visible = false;

                                linkLabel1.Visible = true;                               
                                

                                label15.Visible = true;
                                label15.Text = dsCauhoi.CH1;
                                label16.Visible = false;
                                label17.Visible = false;
                                label18.Visible = false;
                                label19.Visible = false;
                                return;
                            }
                        case 2:
                            {
                                label6.Visible = true;
                                label7.Visible = true;
                                label8.Visible = false;
                                label9.Visible = false;
                                label10.Visible = false;

                                linkLabel1.Visible = true;
                                

                                label15.Visible = true;
                                label15.Text = dsCauhoi.CH1;
                                label16.Visible = true;
                                label16.Text = dsCauhoi.CH2;
                                label17.Visible = false;
                                label18.Visible = false;
                                label19.Visible = false;
                                return;
                            }
                        case 3:
                            {
                                label6.Visible = true;
                                label7.Visible = true;
                                label8.Visible = true;
                                label9.Visible = false;
                                label10.Visible = false;

                                linkLabel1.Visible = true;
                                

                                label15.Visible = true;
                                label15.Text = dsCauhoi.CH1;
                                label16.Visible = true;
                                label16.Text = dsCauhoi.CH2;
                                label17.Visible = true;
                                label17.Text = dsCauhoi.CH3;
                                label18.Visible = false;
                                label19.Visible = false;
                                return;
                            }
                        case 4:
                            {
                                label6.Visible = true;
                                label7.Visible = true;
                                label8.Visible = true;
                                label9.Visible = true;
                                label10.Visible = false;

                                linkLabel1.Visible = true;
                                

                                label15.Visible = true;
                                label15.Text = dsCauhoi.CH1;
                                label16.Visible = true;
                                label16.Text = dsCauhoi.CH2;
                                label17.Visible = true;
                                label17.Text = dsCauhoi.CH3;
                                label18.Visible = true;
                                label18.Text = dsCauhoi.CH4;
                                label19.Visible = false;
                                return;
                            }
                        case 5:
                            {
                                label6.Visible = true;
                                label7.Visible = true;
                                label8.Visible = true;
                                label9.Visible = true;
                                label10.Visible = true;

                                linkLabel1.Visible = true;
                                

                                label15.Visible = true;
                                label15.Text = dsCauhoi.CH1;
                                label16.Visible = true;
                                label16.Text = dsCauhoi.CH2;
                                label17.Visible = true;
                                label17.Text = dsCauhoi.CH3;
                                label18.Visible = true;
                                label18.Text = dsCauhoi.CH4;
                                label19.Visible = true;
                                label19.Text = dsCauhoi.CH5;
                                return;
                            }
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label8.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            linkLabel1.Visible = false;
            

            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
        }      
    }

}
