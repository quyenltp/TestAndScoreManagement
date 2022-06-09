using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAndScore.Data;

namespace PlayerUI.CSDL
{
    class DeThi
    {
        Data a = new Data();

        public DataTable HienThiTatCa()
        {
            string sql = "SELECT maDT as N'Mã đề thi', maMH as N'Mã môn học', hinhthuc as N'Hình thức thi',hocki as N'Học kỳ ', namhoc as N'Năm học', thoiluong as N'Thời lượng', socauhoi as N'Số câu hỏi', ngaythi as N'Ngày thi' FROM DBO.DETHI ORDER BY ngaythi";
            return a.GET(sql);
        }

        public DataTable HienThiChonLoc(string made, string mamon, string hinhthuc, string hocki, string namhoc, string thoiluong, string socauhoi, string ngaythi)
        {
            string sql = "SELECT maDT as N'Mã đề thi'," +
                " maMH as N'Mã môn học', hinhthuc as N'Hình thức thi',hocki as N'Học kỳ '," +
                " namhoc as N'Năm học', thoiluong as N'Thời lượng', socauhoi as N'Số câu hỏi'," +
                " ngaythi as N'Ngày thi' FROM DBO.DETHI WHERE "
                + made == ""?"":("maDT = " + "'" + made + "'" + " AND ")
                + hinhthuc == "" ? "" : ("maMH = " + "'" + mamon + "'" + " AND ")
                + hocki == "(Tất cả)" ? "" : ("hocki = " + "'" + hocki + "'" + " AND ")
                + namhoc == "(Tất cả)" ? "" : ("namhoc = " + "'" + namhoc + "'" + " AND ")
                + thoiluong == "" ? "" : ("thoiluong = " + "'" + thoiluong + "'" + " AND ")
                + ngaythi == ""? "":"ngaythi = " + "'" + ngaythi + "'" +
                " ORDER BY ngaythi";
            return a.GET(sql);
        }
    }
}
