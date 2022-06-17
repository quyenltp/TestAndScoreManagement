using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAndScore;

namespace TestAndScore.Data
{
        class CauHoi
        {
            Data da = new Data();
            public DataTable hienthi()
            {
                string sql = "select * from CAUHOI ";
                return da.GET(sql);
            }
            public DataTable timkiem(string dk)
            {
                string sql = "select * from CAUHOI where maMH like '%" + dk + "%'";
                return da.GET(sql);
            }
            public DataTable mamonhoc()
            {
                string sql = "select maMH from MONTHI";
                return da.GET(sql);
            }
            
            public DataSet laycauhoi(string dk)
        {
            string sql = "select * from CAUHOI where maMH like '%" + dk + "%'";
            return da.GET2(sql);
        }

            public void them(string maCH, string mamon, string dokho, string noidung)
            {
                string sql = "insert into CAUHOI values('" + maCH + "','" + mamon + "',N'" + dokho + "',N'" + noidung + "') ";
                da.AC(sql);
            }
            public void sua(string maCH, string maMH, string dokho,string noidung)
            {
                string sql = "update CAUHOI set maMH='" + maMH + "',dokho=N'" + dokho + "',noidung=N'" + noidung + "' where ma_cau_hoi='" + maCH + "'";
                da.AC(sql);
            }
            public void xoa(string malop)
            {
                string sql = "delete from CAUHOI where ma_cau_hoi='" + malop + "'";
                da.AC(sql);
            }
        }
    }

