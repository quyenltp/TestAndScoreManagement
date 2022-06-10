using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAndScore;

namespace TestAndScore.Data
{
    class Chamthi
    {
        Data da = new Data();
        public DataTable hienthi()
        {
            string sql = "select * from DETHI ";
            return da.GET(sql);
        }
        public DataTable mamonhoc()
        {
            string sql = "select maMH from MONTHI";
            return da.GET(sql);
        }
        public DataTable hienthimonthi()
        {
            string sql = "select tenMH from MONTHI";
            return da.GET(sql);
        }
        public DataTable hienthilop()
        {
            string sql = "select tenlop from LOP";
            return da.GET(sql);
        }
        public DataTable hienthigiangvien()
        {
            string sql = "select tenGV from GIANGVIEN";
            return da.GET(sql);
        }
        public DataTable hienthithisinh()
        {
            string sql = "select mssv from THISINH ";
            return da.GET(sql);
        }

        public void them(string mssv, float diemthiso, string diemthichu, string ghichu, string hoten)
        {
            string sql = "insert into KETQUATHI values(N'" + mssv + "',N'" + "DT" + "','" + 1 + "',N'" + diemthiso + "',N'" + diemthichu + "',N' " + ghichu + "') ";
            string sql1 = "insert into THISINH values(N'" + mssv + "',N'" + hoten + "',N'" + "L3" + "')";
            da.AC(sql);
            da.AC(sql1);
        }
    }
}

