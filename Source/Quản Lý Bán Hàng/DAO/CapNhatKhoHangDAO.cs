using Quản_Lý_Bán_Hàng.DAO;
using Quan_Ly_Ban_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class CapNhatKhoHangDAO
    {
        DB db = new DB();
        public DataTable LayThongTinNhanVien()
        {
            string sql = "select TenNV as [Tên Nhân Viên], MaNV as [Mã] from NhanVien";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinKhoHangTheoMaKH(string makh)
        {
            string sql = string.Format("select * from khohang where MaKH like '{0}'", makh);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinKhoHang()
        {
            string sql = "Select * from KhoHang";
            return db.GetDataTable(sql);
        }
        public int CapNhatKhoHangBTN(KhoHangDTO kho)
        {
            string sql = string.Format("update KhoHang set  TenKH = N'{0}', NguoiQuanLy = '{1}', KyHieu = '{2}', DiaChi = N'{3}', DienThoai = '{4}', Fax = '{5}', Email = '{6}', DienGiai = '{7}', ConQuanLy = '{8}', NguoiLienHe = N'{9}' where MaKH like '{10}'",
                                                            kho.TenKH, kho.NguoiQuanLy, kho.KyHieu, kho.DiaChi, kho.DienThoai, kho.Fax, kho.Email, kho.DienGiai, kho.ConQuanLy, kho.NguoiLienHe, kho.MaKH);
            return db.ExcuteSql(sql);
        }
        public int ThemKhoHangBTN(KhoHangDTO kho)
        {
            string sql = string.Format("insert into KhoHang(MaKH, TenKH, NguoiQuanLy, KyHieu, NguoiLienHe, DiaChi, DienThoai, Fax, Email, DienGiai, ConQuanLy)" +
                                       "values('{0}', N'{1}', '{2}', '{3}', N'{4}', N'{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",
                                       kho.MaKH, kho.TenKH, kho.NguoiQuanLy, kho.KyHieu, kho.NguoiLienHe, kho.DiaChi, kho.DienThoai, kho.Fax, kho.Email, kho.DienThoai, kho.ConQuanLy);
            return db.ExcuteSql(sql);
        }
    }
}
