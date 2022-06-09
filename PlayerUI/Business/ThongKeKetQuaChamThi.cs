using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThietKePhanMem.DataAcess;

namespace PlayerUI.Business
{
    public class ThongKeKetQuaChamThi
    {
        Data a = new Data();
        public Boolean Check_KQ(string mon, string lop, string giangvien)
        {
            //string sql = "SELECT LOP as N'Lớp' MONHOC as N'Môn học', TONGSOBAITHI as N'Tổng số bài thi',SOHOCVIENCHUATHI as N'Số học viên chưa thi ' FROM DBO.THONGKEBAITHI()";
            int a = 1; //xoá sau khi chèn sql
            if (a == 1) return true;
            else return false;
        }
    }
}
