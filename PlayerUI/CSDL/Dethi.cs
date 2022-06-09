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
        public void them(string maDT, string tenmon, int hocki , string namhoc,int thoiluong, string mach, string maMH)
        {
            string sql = "insert into DETHI values('" + maDT + "','" + tenmon + "','" + hocki + "',N'" + namhoc + "',N'" + thoiluong + "',N'" + mach + "',N'" + maMH + "') ";
            da.AC(sql);
        }
    }
}
