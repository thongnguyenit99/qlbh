using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class CapNhatVaiTroDAO
    {
        DB db = new DB();
        public DataTable LayThongTinVaiTro(int tenvt)
        {
            string sql = string.Format("select * from RoleUser where id = {0}", tenvt);
            return db.GetDataTable(sql);
        }
        public DataTable LayMenuBarID(int id)
        {
            string sql = string.Format("select * from RoleMenubar where RoleUserId = {0}", id);
            return db.GetDataTable(sql);
        }
        public DataTable LayQuyenTruyCapThanhMeNu(int vt)
        {
            string sql = string.Format("select * from RoleMenubar where RoleUserId = {0}", vt);
            return db.GetDataTable(sql);
        }
        public DataTable LayBangPhanQuyen(int vt)
        {
            string sql = string.Format("select f.FormName, rf.TruyCap, rf.Them, rf.Sua, rf.Xoa, rf.In_DL, rf.Nhap, rf.Xuat " +
                                        "from RoleForm rf, form f" +
                                        " where f.Id = rf.FormId and rf.RoleId = {0}", vt);
            return db.GetDataTable(sql);
        }
        public int CapNhatVaiTro(string mavt, string tenvaitro, string diengiai, bool conquanly)
        {
            string sql = string.Format("update RoleUser set RoleName = N'{0}', DescriptionName = '{1}', KichHoat = '{2}' where MaVT like '{3}'",
                                                            tenvaitro, diengiai, conquanly, mavt);
            return db.ExcuteSql(sql);
        }
        public int CapNhatBangPhanQuyen(int roldeid, int formID, bool truycap, bool them, bool sua, bool xoa, bool in_dl, bool nhap, bool xuat)
        {
            string sql = string.Format("update RoleForm set TruyCap = '{0}', Them = '{1}', Sua = '{2}', Xoa = '{3}', In_DL = '{4}', Nhap = '{5}', Xuat = '{6}'where RoleID = {7} and FormId = {8}" ,
                                        truycap, them, sua, xoa, in_dl, nhap, xuat, roldeid, formID);
            return db.ExcuteSql(sql);
        }
        public DataTable DeCuMaVT()
        {
            string sql = @"select *from RoleUser";
            return db.GetDataTable(sql);
        }
        public DataTable KiemTraVaiTroTonTai(string mavt)
        {
            string sql = string.Format("select * from RoleUser where MaVT = '{0}'", mavt);
            return db.GetDataTable(sql);
        }
        public int ThemVaiTro(string mavt, string tenvt, string diengiai, bool kichhoat)
        {
            string sql = string.Format("insert into RoleUser (MaVT, RoleName, DescriptionName, KichHoat) values('{0}', '{1}', '{2}', '{3}')",
                                        mavt, tenvt, diengiai, kichhoat);
            return db.ExcuteSql(sql);
        }
        public int ThemQuyenMotChucNangTrenThanhMeNu(int roleID, int menubarid, int trangthai)
        {
            string sql = string.Format("insert into RoleMenubar (RoleUserID, MeNuBarId, TrangThai) values ({0}, {1}, {2})", roleID, menubarid, trangthai);
            return db.ExcuteSql(sql);
        }
        public DataTable LayBangPhanQuyenAdmin()
        {
            string sql = "select f.FormName, rf.TruyCap, rf.Them, rf.Sua, rf.Xoa, rf.In_DL, rf.Nhap, rf.Xuat " +
                                        "from RoleForm rf, form f" +
                                        " where f.Id = rf.FormId and rf.RoleId = 1";
            return db.GetDataTable(sql);
        }
        public int ThemBangPhanQuyen(int roldeid, int formID, bool truycap, bool them, bool sua, bool xoa, bool in_dl, bool nhap, bool xuat)
        {
            string sql = string.Format("insert into RoleForm (RoleId, FormId, TruyCap, Them, Sua, Xoa, In_DL, Nhap, Xuat) values({0}, {1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                        roldeid, formID, truycap, them, sua, xoa, in_dl, nhap, xuat);
            return db.ExcuteSql(sql);
        }
        public int UpadateRoleMeNuBar(int roleID, int menubarid, int trangThai)
        {
            string sql = string.Format("update RoleMenubar set TrangThai = {0} where RoleUserId = {1} and MeNuBarId = {2}",trangThai, roleID, menubarid);
            return db.ExcuteSql(sql);
        }
    }
}
