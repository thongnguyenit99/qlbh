using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class TheoHangHoa_PNH_DAO
    {
        DB db = new DB();
        public DataTable LayThongTinNhaCungCap()
        {
            string sql = "select TenNCC as [Ten], MaNCC as[Ma] from NhaCungCap";
            return db.GetDataTable(sql);
        }
        public DataTable LayHangHoaTheoPhieuNhapHang(string tungay, string denngay)
        {
            string sql =string.Format("select pnh.MaPNH as[ChungTu], pnh.NgayLap as [Ngay], ncc.TenNCC as[NhaCungCap], ctpnh.MaSanPham as [MaHang], ctpnh.TenSanPham as [TenHang], ctpnh.DonVi as[DonVi]," +
                        " kh.TenKH as [KhoHang], ctpnh.SoLuong as[SoLuong], ctpnh.DonGia as [DonGia], ctpnh.ThanhTien as [ThanhTien]" +
                        "from PhieuNhapHang pnh, CT_PhieuNhapHang ctpnh, NhaCungCap ncc, KhoHang kh where pnh.MaPNH = ctpnh.MaPhieuNhapHang and pnh.MaNCC = ncc.MaNCC and pnh.MaKho = kh.MaKH " +
                        "and DATEDIFF(day, '{0}', NgayLap) >= 0 and DATEDIFF(day, NgayLap, '{1}') >= 0", tungay, denngay);
            return db.GetDataTable(sql);
        }
        public DataTable LayHangHoaTheoPhieuNhapHang_MaNCC(string tungay, string denngay, string mancc)
        {
            string sql = string.Format("select pnh.MaPNH as[ChungTu], pnh.NgayLap as [Ngay], ncc.TenNCC as[NhaCungCap], ctpnh.MaSanPham as [MaHang], ctpnh.TenSanPham as [TenHang], ctpnh.DonVi as[DonVi]," +
                        " kh.TenKH as [KhoHang], ctpnh.SoLuong as[SoLuong], ctpnh.DonGia as [DonGia], ctpnh.ThanhTien as [ThanhTien]" +
                        "from PhieuNhapHang pnh, CT_PhieuNhapHang ctpnh, NhaCungCap ncc, KhoHang kh where pnh.MaPNH = ctpnh.MaPhieuNhapHang and pnh.MaNCC = ncc.MaNCC and pnh.MaKho = kh.MaKH " +
                        "and DATEDIFF(day, '{0}', NgayLap) >= 0 and DATEDIFF(day, NgayLap, '{1}') >= 0 and pnh.MaNCC like '{2}'", tungay, denngay, mancc);
            return db.GetDataTable(sql);
        }
    }
}
