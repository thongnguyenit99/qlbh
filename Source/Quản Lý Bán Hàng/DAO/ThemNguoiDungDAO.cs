using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class ThemNguoiDungDAO
    {
        DB db = new DB();
        public DataTable GetInFoNhanVien()
        {
            string sql = "select * from NhanVien";
            return db.GetDataTable(sql);
        }
        public DataTable GetInForVaiTro()
        {
            string sql = "select * from RoleUser";
            return db.GetDataTable(sql);
        }
        public DataTable GetAllUserName()
        {
            string sql = "select * from TaiKhoan";
            return db.GetDataTable(sql);
        }
        public int ThemNguoiDungBTN(string tk, string pass, string manv, int RoleID, bool ql)
        {
            string sql = string.Format("insert into TaiKhoan (UserName, Passwd, MaNV, RoleID, ConQuanLy) values('{0}', '{1}', '{2}', {3}, '{4}')", tk, pass, manv, RoleID, ql);
            return db.ExcuteSql(sql);
        }
    }
}
