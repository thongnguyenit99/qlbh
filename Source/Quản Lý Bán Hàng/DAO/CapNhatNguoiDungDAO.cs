using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class CapNhatNguoiDungDAO
    {
        DB db = new DB();
        public DataTable LayThongTinTatCaNV()
        {
            string sql = @"select nv.id, nv.maNV, TenNV, bp.TenBP from NhanVien nv, BoPhan bp where nv.BoPhan = bp.MaBP";
            return db.GetDataTable(sql);
        }
        public DataTable LayViTriTuTenTaiKhoan(string username)
        {
            string sql = string.Format("select nv.id,tk.UserName, tk.Passwd, tk.RoleID,tk.Descripttion, nv.MaNV from TaiKhoan tk, NhanVien nv where UserName = '{0}' and tk.MaNV = nv.MaNV", username);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinVaiTro()
        {
            string sql = @"select * from RoleUser";
            return db.GetDataTable(sql);
        }
        public DataTable LayTTTaiKhoanNhanVien(string username)
        {
            string sql = "select * from TaiKhoan tk, NhanVien  nv where tk.MaNV = nv.MaNV and UserName like N'" + username + "'";
            return db.GetDataTable(sql);
        }
        public int CapNhatNguoiDungBUSbtn(string tk, string manv, string mk, int vt, string diengiai, bool conquanly)
        {
            string sql = string.Format("update TaiKhoan set Passwd = '{0}', MaNV = '{1}', RoleID = {2}, ConQuanLy = '{3}', Descripttion = '{4}' where UserName = '{5}'",
                                        mk, manv, vt, conquanly, diengiai, tk);
            return db.ExcuteSql(sql);
        }
        public DataTable LayMaNVTuTenNV(string tennv)
        {
            string sql = string.Format("select MaNV from NhanVien where TenNV like N'{0}'", tennv);
            return db.GetDataTable(sql);
        }
        public DataTable LayIdVaiTroTuTenVT(string tenvt)
        {
            string sql = string.Format("select id from RoleUser where RoleName like N'{0}'", tenvt);
            return db.GetDataTable(sql);
        }
    }
}
