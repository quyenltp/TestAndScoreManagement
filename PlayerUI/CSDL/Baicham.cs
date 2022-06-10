using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAndScore.Data;

namespace PlayerUI.CSDL
{
    class Baicham
    {
        Data da = new Data();
        public DataTable HienThiTheoNam(string nam)
        {
            string sql = "SELECT DISTINCT * FROM dbo.DETHI INNER JOIN dbo.KETQUATHI ON DETHI.maDT = dbo.KETQUATHI.maDT WHERE namhoc = '" + nam + "'";
            return da.GET(sql);
        }

        public DataTable DanhSachMonHoc()
        {
            string sql = "SELECT maMH, tenMH FROM dbo.MONTHI";
            return da.GET(sql);
        }
        public DataTable SoLuongDeThiTheoMon(string mamon, string namhoc)
        {
            string sql = "SELECT COUNT(*) FROM dbo.DETHI WHERE namhoc = '" + namhoc + "' AND maMH = '" + mamon + "'";
            return da.GET(sql);
        }

        public DataTable SoLuongBaiChamTheoMon(string mamon, string namhoc)
        {
            string sql = "SELECT COUNT(*) FROM dbo.DETHI INNER JOIN dbo.KETQUATHI ON KETQUATHI.maDT = DETHI.maDT WHERE namhoc = '" + namhoc + "' AND maMH = '" + mamon + "'";
            return da.GET(sql);
        }
    }
}
