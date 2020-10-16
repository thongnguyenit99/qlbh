using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class UC_BanHang_TheoChungTuDAO
    {
        DB db = new DB();
        public DataTable LayThongTinPhieuBanHangTheoMauCT(string tungay, string denngay)
        {
            string sql = string.Format("select MaPBH as[ChungTu], NgayLap as[Ngay], SoPhieuVT as[SoPhieuVietTay], SoVAT as[SoHoaDonVAT], kh.TenKH as [KhachHang], CK, VAT, TongThanhTien as[ThanhToan], GhiChu, khohang.TenKH as[KhoHang] " +
                        "from PhieuBanHang pbh, KhachHang kh, KhoHang khohang where pbh.MaKH = kh.MaKH and pbh.MaKho = khohang.MaKH and NgayLap between '{0}' and '{1}'", tungay, denngay);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinPhieuBanHangTheoMauCT_MaKH(string tungay, string denngay, string MaKH)
        {
            string sql = string.Format("select MaPBH as[ChungTu], NgayLap as[Ngay], SoPhieuVT as[SoPhieuVietTay], SoVAT as[SoHoaDonVAT], kh.TenKH as [KhachHang], CK, VAT, TongThanhTien as[ThanhToan], GhiChu, khohang.TenKH as[KhoHang] " +
                        "from PhieuBanHang pbh, KhachHang kh, KhoHang khohang where pbh.MaKH = kh.MaKH and pbh.MaKho = khohang.MaKH and NgayLap between '{0}' and '{1}' and pbh.maKH like '{2}'", tungay, denngay, MaKH);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinCT_PhieuBanHangTheoChungTu()
        {
            string sql = "select  MaPhieuBanHang, MaSanPham as[MaHang], TenSanPham as[TenHang], kh.TenKH as[KhoHang], ctpbh.DonVi, SoLuong, DonGia, ThanhTien, ctpbh.CK as [CK]  " +
                    "from PhieuBanHang pbh, CT_Phieu_Ban_Hang ctpbh, KhoHang kh, HangHoa hh " +
                    " where pbh.MaPBH = ctpbh.MaPhieuBanHang and pbh.MaKho = kh.MaKH and ctpbh.MaSanPham = hh.MaHH and hh.MaKho = pbh.MaKho";
            return db.GetDataTable(sql);
        }
        public DataTable ChuyenTenKhoThanhMaKho(string tenkho)
        {
            string sql = string.Format("select MaKH from KhoHang where TenKH like N'{0}'", tenkho);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinKhachHang()
        {
            string sql = "select MaKH as [Ma], TenKH as [Tên Khách Hàng] from KhachHang";
            return db.GetDataTable(sql);
        }
        public DataTable KiemTraXemPhieuNhapHangDaCoPhieuThu(string mapbh)
        {
            string sql = string.Format("select * from DanhSachPhieuThu where MaPBH like '{0}'", mapbh);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinCT_PhieuMuaHangTheoMa(string mapbh)
        {
            string sql = string.Format("select * from CT_Phieu_Ban_Hang where MaPhieuBanHang like '{0}'", mapbh);
            return db.GetDataTable(sql);
        }
        public int XoaPhieuBanHang(string mapbh)
        {
            string sql = string.Format("delete PhieuBanHang where MaPBH like '{0}'", mapbh);
            return db.ExcuteSql(sql);
        }
        public int XoaCT_PhieuMuaHang(string mapbh)
        {
            string sql = string.Format("delete CT_Phieu_Ban_Hang where MaPhieuBanHang like '{0}'", mapbh);
            return db.ExcuteSql(sql);
        }
    }
}
