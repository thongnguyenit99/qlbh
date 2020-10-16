using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class PhanQuyenDAO
    {
        DB db = new DB();
        public DataTable getAllRolForm(int roleID)
        {
            string sql = string.Format("select f.FormName, TruyCap, Them, Sua, Xoa, In_DL, Nhap, Xuat from RoleForm ru, Form f where ru.FormId = f.Id and ru.RoleId = {0}", roleID);
            return db.GetDataTable(sql);
        }
        public DataTable getAllRoleUser()
        {
            string sql = "select * from RoleUser";
            return db.GetDataTable(sql);
        }
        public DataTable getUserName(int roleID)
        {
            string sql = string.Format("select UserName from TaiKhoan where RoleID = {0}", roleID);
            return db.GetDataTable(sql);
        }
        public DataTable getDaTaUser(int roleID)
        {
            string sql = string.Format("select tk.UserName, ru.RoleName, nv.TenNV, nv.ConQuanLy from TaiKhoan tk, RoleUser ru, NhanVien nv where tk.RoleID = ru.Id and tk.MaNV = nv.MaNV and tk.RoleID = {0}", roleID);
            return db.GetDataTable(sql);
        }
        public int XoaVaiTro(int id)
        {
            string sql = string.Format("delete RoleUser where id = {0}", id);
            string sql1 = string.Format("delete TaiKhoan where RoleID ={0}", id);
            string sql2 = string.Format("delete RoleMenubar where RoleUserId = {0}", id);
            string sql3 = string.Format("delete RoleForm where RoleId = {0}", id);
            //string sql4 = string.Format("DBCC CHECKIDENT ('RoleUser', RESEED, {0})", id);
            db.ExcuteSql(sql1);
            db.ExcuteSql(sql2);
            db.ExcuteSql(sql3);
            int x = db.ExcuteSql(sql);
            //db.ExcuteSql(sql4);
            return x;
        }
        public int XoaTaiKhoan(string tentk)
        {
            string sql = string.Format("delete TaiKhoan where UserName like N'{0}'", tentk);
          //  string sql4 = "DBCC CHECKIDENT ('TaiKhoan', RESEED, 0)";
            int x = db.ExcuteSql(sql);
           // db.ExcuteSql(sql4);
            return x;
        }

    }
}
