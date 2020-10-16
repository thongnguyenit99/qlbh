using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class UC_BanHang_TheoHangHoaDAO
    {
        DB db = new DB();
        public DataTable LayThongTinPhieuNhapHangTheoHangHoa(string tungay, string denngay)
        {
            string sql = string.Format("select pbh.MaPBH as[ChungTu], pbh.NgayLap as [Ngay], ctpbh.MaSanPham as [MaHang], ctpbh.TenSanPham as [TenHang], ctpbh.DonVi as[DonVi], " +
                "kh.TenKH as [KhoHang], ctpbh.SoLuong as[SoLuong], ctpbh.DonGia as [DonGia], ctpbh.ThanhTien as [ThanhTien], ctpbh.CK as [CK], khang.TenKH as[KhachHang] " +
                "from PhieuBanHang pbh, CT_Phieu_Ban_Hang ctpbh, KhoHang kh, KhachHang khang " +
                "where pbh.MaPBH = ctpbh.MaPhieuBanHang and pbh.MaKH = khang.MaKH and pbh.MaKho = kh.MaKH and NgayLap between '{0}' and '{1}'", tungay, denngay);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinPhieuNhapHangTheoHangHoa_MaKH(string tungay, string denngay, string MaKH)
        {
            string sql = string.Format("select pbh.MaPBH as[ChungTu], pbh.NgayLap as [Ngay], ctpbh.MaSanPham as [MaHang], ctpbh.TenSanPham as [TenHang], ctpbh.DonVi as[DonVi], " +
                "kh.TenKH as [KhoHang], ctpbh.SoLuong as[SoLuong], ctpbh.DonGia as [DonGia], ctpbh.ThanhTien as [ThanhTien], ctpbh.CK as [CK], khang.TenKH as[KhachHang] " +
                "from PhieuBanHang pbh, CT_Phieu_Ban_Hang ctpbh, KhoHang kh, KhachHang khang " +
                "where pbh.MaPBH = ctpbh.MaPhieuBanHang and pbh.MaKH = khang.MaKH and pbh.MaKho = kh.MaKH and NgayLap between '{0}' and '{1}' and pbh.MaKH like '{2}'", tungay, denngay, MaKH);
            return db.GetDataTable(sql);
        }
    }
}
