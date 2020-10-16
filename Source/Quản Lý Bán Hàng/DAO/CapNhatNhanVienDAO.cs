using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quản_Lý_Bán_Hàng.DAO;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class CapNhatNhanVienDAO
    {
        DB db = new DB();
        public DataTable LayThongTinNhanVien()
        {
            string sql = "select * from NhanVien";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhanVienTheoMaNV(string manv)
        {
            string sql = string.Format("select * from NhanVien where MaNV like '{0}'", manv);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinBoPhanCB()
        {
            string sql = "select TenBP as [Tên], MaBP as [Mã] from bophan";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhanVienCB()
        {
            string sql = "select TenNV as [Tên], MaNV as [Mã] from NhanVien";
            return db.GetDataTable(sql);
        }
        public int ThemNhanVienBTN(NhanVienDTO nv)
        {
            string sql = string.Format("insert into NhanVien (MaNV, TenNV, DiaChi, DienThoai, DiDong, Email, QuanLy, BoPhan, ConQuanLy)" +
                                       "values('{0}', N'{1}', N'{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                       nv.MaNV, nv.TenNV, nv.DiaChi, nv.DienThoai, nv.DiDong, nv.Email, nv.QuanLy, nv.BoPhan, nv.ConQuanLy);
            return db.ExcuteSql(sql);
        }
        public int CapNhatNhanVienBTN(NhanVienDTO nv)
        {
            string sql = string.Format("update NHANVIEN set TenNV = N'{0}', DiaChi = N'{1}', DienThoai = '{2}', DiDong = '{3}'," +
                " Email = '{4}', QuanLy = '{5}', BoPhan = '{6}', ConQuanLy = '{7}' where MaNV like '{8}'",
                    nv.TenNV, nv.DiaChi, nv.DienThoai, nv.DiDong, nv.Email, nv.QuanLy, nv.BoPhan, nv.ConQuanLy, nv.MaNV);
            return db.ExcuteSql(sql);
        }
    }
}
