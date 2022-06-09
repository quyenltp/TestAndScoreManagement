using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAndScore.Data;

namespace PlayerUI.CSDL
{
    class DanhSachDeThi
    {
        Data a = new Data();
        public DataTable HienThiTatCa()
        {
            string sql = "SELECT maDT as N'Mã đề thi', maMH as N'Mã môn học', hinhthuc as N'Hình thức thi',hocki as N'Học kỳ', namhoc as N'Năm học', thoiluong as N'Thời lượng', socauhoi as N'Số câu hỏi', ngaythi as N'Ngày thi' FROM DBO.DETHI ORDER BY ngaythi";
            return a.GET(sql);
        }
    }
}
