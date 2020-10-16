using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quản_Lý_Bán_Hàng.DAO;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class DoiMatKhauDA0
    {
        DB db = new DB();
        public DataTable LayMatKhauTheoTaiKhoan(string tk)
        {
            string sql = string.Format("select Passwd from TaiKhoan where UserName like N'{0}'", tk);
            return db.GetDataTable(sql);
        }
        public int CapNhatMatKhau(string tk, string passnew)
        {
            string sql = string.Format("update TaiKhoan set Passwd = '{0}' where UserName like N'{1}'", passnew, tk);
            return db.ExcuteSql(sql);

        }
    }
}
