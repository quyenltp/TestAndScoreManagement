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

        public void themChitietde(string maDT, string maMH, int stt)
        {
            string sql = "insert into CHITIETDETHI values('" + maDT + "','" + maMH + "',N'" + stt + "')";
            da.AC(sql);
        }
    }
}
