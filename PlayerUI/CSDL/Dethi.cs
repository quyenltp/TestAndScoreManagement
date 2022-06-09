using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TestAndScore.Data;

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
        public DataTable HienThiChonLoc(string made, string mamon, string hinhthuc, string hocki, string namhoc, string thoiluong, string socauhoi, string ngaythi)
        {
            string sql = "SELECT maDT as N'Mã đề thi'," +
                " maMH as N'Mã môn học', hinhthuc as N'Hình thức thi',hocki as N'Học kỳ '," +
                " namhoc as N'Năm học', thoiluong as N'Thời lượng', socauhoi as N'Số câu hỏi'," +
                " ngaythi as N'Ngày thi' FROM DBO.DETHI WHERE "
                + made == "" ? "" : ("maDT = " + "'" + made + "'" + " AND ")
                + mamon == "" ? "" : ("maMH = " + "'" + mamon + "'" + " AND ")
                + hinhthuc == "" ? "" : ("hinhthuc = " + "N'" + hinhthuc + "'" + " AND ")
                + hocki == "(Tất cả)" ? "" : ("hocki = " + "N'" + hocki + "'" + " AND ")
                + namhoc == "(Tất cả)" ? "" : ("namhoc = " + "'" + namhoc + "'" + " AND ")
                + thoiluong == "" ? "" : ("thoiluong = " + "'" + thoiluong + "'" + " AND ")
                + socauhoi == "" ? "" : ("maMH = " + "'" + socauhoi + "'" + " AND ")
                + ngaythi == "" ? "" : "ngaythi = " + "'" + ngaythi + "'" +
                " ORDER BY ngaythi";
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
