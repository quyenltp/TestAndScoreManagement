using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAndScore.Data
{
    class Dethi
    {
        Data da = new Data();
        public DataTable hienthi()
        {
            string sql = "select * from DETHI ";
            return da.GET(sql);
        }

        public DataTable HienThiTatCa()
        {
            string sql = "SELECT maDT as N'Mã đề thi', maMH as N'Mã môn học', hinhthuc as N'Hình thức thi',hocki as N'Học kỳ', namhoc as N'Năm học', thoiluong as N'Thời lượng', socauhoi as N'Số câu hỏi', ngaythi as N'Ngày thi' FROM DBO.DETHI ORDER BY ngaythi";
            return da.GET(sql);
        }
        public DataTable HienThiChonLoc(string dk)
        {
            string sql = "SELECT maDT as N'Mã đề thi'," +
                " maMH as N'Mã môn học', hinhthuc as N'Hình thức thi',hocki as N'Học kỳ '," +
                " namhoc as N'Năm học', thoiluong as N'Thời lượng', socauhoi as N'Số câu hỏi'," +
                " ngaythi as N'Ngày thi' FROM DBO.DETHI WHERE " + dk;
            return da.GET(sql);
        }

        public DataTable HienThiTheoNam(string nam)
        {
            string sql = "SELECT maDT as N'Mã đề thi', maMH as N'Mã môn học', hinhthuc as N'Hình thức thi', hocki as N'Học kỳ ', namhoc as N'Năm học'," +
                        " thoiluong as N'Thời lượng', socauhoi as N'Số câu hỏi', ngaythi as N'Ngày thi' FROM DBO.DETHI WHERE namhoc = '" + nam + "'";
            return da.GET(sql);
        }
        public DataTable timmaMonhoc(string dk)
        {
            string sql = "select * from MONTHI where tenMH like '%" + dk + "%'";
            return da.GET(sql);
        }
        public DataTable mamonhoc()
        {
            string sql = "select maMH from MONTHI";
            return da.GET(sql);
        }
        public void them(string maDT, string maMH, string hinhthuc , string hocki,int namhoc, int thoiluong, int socauhoi, DateTime ngaythi)
        {
            string sql = "insert into DETHI values('" + maDT + "','" + maMH + "',N'" + hinhthuc + "',N'" + hocki + "',N'" + namhoc + "',N'" + thoiluong + "',N'" + socauhoi + "',N'" + ngaythi + "') ";
            da.AC(sql);
        }
    }
}
