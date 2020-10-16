using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Quan_Ly_Ban_Hang.DAO
{
    public class TheoChungTu_PNH_DAO
    {
        DB db = new DB();
        public DataTable LayThongTinNhaCungCap()
        {
            string sql = "select TenNCC as [Ten], MaNCC as[Ma] from NhaCungCap";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinPhieuNhapHangTheoChungTu(string ngaybd, string ngaykt)
        {
            string sql = string.Format("select MaPNH as[Chứng Từ], NgayLap as [Ngày], SoPhieuVT as [Số Phiếu Viết Tay], kh.TenKH as [Kho Hàng], SoVAT as [Số Hóa Đơn VAT], ncc.TenNCC as [Nhà Cung Cấp]," +
                    "pnh.CK, VAT as[Vat], TongThanhTien as [Thanh Toán], GhiChu as[Ghi Chú]" +
                    "from PhieuNhapHang pnh, NhaCungCap ncc, KhoHang kh where pnh.MaNCC = ncc.MaNCC and pnh.MaKho = kh.MaKH and " +
                    "DATEDIFF(day, '{0}', pnh.ngaylap) >= 0 and DATEDIFF(day, pnh.ngaylap , '{1}') >= 0", 
                    ngaybd, ngaykt);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinPhieuNhapHangTheoChungTu_MNCC(string ngaybd, string ngaykt, string mancc)
        {
            string sql = string.Format("select MaPNH as[Chứng Từ], NgayLap as [Ngày], SoPhieuVT as [Số Phiếu Viết Tay], kh.TenKH as [Kho Hàng], SoVAT as [Số Hóa Đơn VAT], ncc.TenNCC as [Nhà Cung Cấp]," +
                    "pnh.CK, VAT as[Vat], TongThanhTien as [Thanh Toán], GhiChu as[Ghi Chú]" +
                    "from PhieuNhapHang pnh, NhaCungCap ncc, KhoHang kh where pnh.MaNCC = ncc.MaNCC and pnh.MaKho = kh.MaKH and " +
                    "DATEDIFF(day, '{0}', pnh.ngaylap) >= 0 and DATEDIFF(day, pnh.ngaylap , '{1}') >= 0 and ncc.MaNCC like '{2}'",
                    ngaybd, ngaykt, mancc);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinKhoHang()
        {
            string sql = "select * from KhoHang";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinCTPhieuPhapHangTheoChungTu()
        {
            string sql = "select MaPhieuNhapHang, MaSanPham as [MaHang], TenSanPham as [TenHang], kh.TenKH as[KhoHang], DonVi, SoLuong, DonGia, ThanhTien " +
            "from CT_PhieuNhapHang ctpnh, HangHoa hh, KhoHang kh, PhieuNhapHang pnh " +
            " where ctpnh.MaSanPham = hh.MaHH and pnh.MaKho = kh.MaKH and hh.MaKho = pnh.MaKho and ctpnh.MaPhieuNhapHang = pnh.MaPNH";
            return db.GetDataTable(sql);
        }
        public DataTable LayPhieuChiTheoMaChungTu(string mact)
        {
            string sql = string.Format("select * from DanhSachPhieuChi where MaPNH like '{0}'", mact);
            return db.GetDataTable(sql);
        }
        public int XoaPhieuNhapHang(string mapnh)
        {
            string sql = string.Format("delete PhieuNhapHang where MaPNH like '{0}'", mapnh);
            return db.ExcuteSql(sql);
        }
        public DataTable LayThongTinCT_phieuNhapHang(string mapnh)
        {
            string sql = string.Format("select * from CT_PhieuNhapHang where MaPhieuNhapHang like '{0}'", mapnh);
            return db.GetDataTable(sql);
        }
        public int XoaCT_PhieuNhapHang(string mapnh)
        {
            string sql = string.Format("delete CT_PhieuNhapHang where MaPhieuNhapHang like '{0}'", mapnh);
            return db.ExcuteSql(sql);
        }
    }
}
