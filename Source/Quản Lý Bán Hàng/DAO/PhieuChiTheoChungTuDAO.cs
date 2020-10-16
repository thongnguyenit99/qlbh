using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class PhieuChiTheoChungTuDAO
    {
        DB db = new DB();
        public DataTable LayThongTinChungTuTheoMa_PNH(string mapnh)
        {
            string sql = string.Format("select MaPNH, NgayLap, TongThanhTien, GhiChu, nv.TenNV, ncc.TenNCC, pnh.MaNCC, pnh.DiaChi  from PhieuNhapHang pnh, NhanVien nv, NhaCungCap ncc " +
                        " where MaPNH like '{0}' and pnh.MaNV = nv.MaNV and pnh.MaNCC = ncc.MaNCC", mapnh);
            return db.GetDataTable(sql);
        }
        public int CapNhatPhieuNhapHang(string mapnh)
        {
            string sql = string.Format("update PhieuNhapHang set IsDaThanhToan  = 1 where MaPNH like '{0}'", mapnh);
            return db.ExcuteSql(sql);
        }
        public DataTable LayThongTinDanhSachPhieuChi()
        {
            string sql = "select * from DanhSachPhieuChi";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinDanhSachPhieuThu()
        {
            string sql = "select * from DanhSachPhieuThu";
            return db.GetDataTable(sql);
        }
        public DataTable KiemTraMaPCDaTonTai(string mapc)
        {
            string sql = string.Format("select * from DanhSachPhieuChi where MaPC like '{0}'", mapc);
            return db.GetDataTable(sql);
        }
        public int XoaPhieuChiTheoMa(string mapc)
        {
            string sql = string.Format("delete DanhSachPhieuChi where MaPC like '{0}'", mapc);
            return db.ExcuteSql(sql);
        }
        public int LuuThongTinPhieuChi(string mapc, string mapnh, string ngaylappc, string mancc, string tenncc, float tongtien, string ghichu)
        {
            string sql = string.Format("insert into  DanhSachPhieuChi (MaPC, MaPNH, NgayLap, MaNCC, TenNCC, TongTien, GhiChu) values ('{0}', '{1}', '{2}', '{3}', N'{4}', {5}, N'{6}')"
                              , mapc, mapnh, ngaylappc, mancc, tenncc, tongtien, ghichu);
            return db.ExcuteSql(sql);
        }
        public DataTable LayThongTinNhanVien()
        {
            string sql = "select TenNV as[Tên], MaNV as [Mã] from NhanVien";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinPhieuBanHangTheoMa(string mapbh)
        {
            string sql = string.Format("select kh.TenKH, pbh.MaPBH, pbh.NgayLap, pbh.TongThanhTien, nv.TenNV, pbh.GhiChu, kh.MaKH " +
            "from PhieuBanHang pbh, KhachHang kh, NhanVien nv where pbh.MaNV = nv.MaNV and pbh.MaKH = kh.MaKH and MaPBH like '{0}'", mapbh);
            return db.GetDataTable(sql);
        }
        public DataTable KiemTraMaPhieuThuDaTonTai(string mapt)
        {
            string sql = string.Format("select * from DanhSachPhieuThu where MaPT like '{0}'", mapt);
            return db.GetDataTable(sql);
        }
        public int LuuThongTinPhieuThu(string mapt, string mapbh, string ngaylapppt, string makh, string tenkh, float tongtien, string ghichu)
        {
            string sql = string.Format("insert into DanhSachPhieuThu(MaPT, MaPBH, NgayLap, MaKH, TenKH, TongTien, GhiChu) values('{0}', '{1}', '{2}', '{3}', N'{4}', {5}, N'{6}')",
                                       mapt, mapbh, ngaylapppt,makh, tenkh, tongtien, ghichu);
            return db.ExcuteSql(sql);
        }
        public int CapNhatPhieuBanHang(string mapbh)
        {
            string sql = string.Format("update PhieuBanHang set IsDaThuTien  = 1 where MaPBH like '{0}'", mapbh);
            return db.ExcuteSql(sql);
        }
        public int XoaPhieuThuTheoMa(string mapt)
        {
            string sql = string.Format("delete DanhSachPhieuThu where MaPC like '{0}'", mapt);
            return db.ExcuteSql(sql);
        }
    }
}
