using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class MuaHangDAO
    {
        DB db = new DB();
        public DataTable LayThongTinNhaCungCapTheoTen()
        {
            string sql = "select TenNCC as [Nhà Phân Phối], MaNCC as [Mã] from NhaCungCap";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhaCungCapTheoMa()
        {
            string sql = "select  MaNCC as [Mã], TenNCC as [Nhà Phân Phối] from NhaCungCap";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinPhieuNhapHangHang()
        {
            string sql = "select * from PhieuNhapHang";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinHangHoaTheoMau(string mahh)
        {
            string sql = "select * from HangHoa ";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinHangHoaTheoMaHHVaMaKho(string mahh, string makho)
        {
            string sql = string.Format("select * from HangHoa where MaHH like '{0}' and MaKho like '{1}'", mahh, makho);
            return db.GetDataTable(sql);
        }
        public int ThemHangHoa(HangHoaDTO hh)
        {
            string sql = string.Format("insert into HangHoa(MaHH, MaDV, TenHH, MaNH, MaLHH, MaKho, Anh, TonKhoToiThieu, TonKhoHienTai, GiaMua, GiaBanLe, GiaBanSi, IsDelete) " +
"values('{0}', '{1}', N'{2}', '{3}', '{4}', '{5}', '{6}', {7}, {8}, {9}, {10}, {11}, {12})", hh.MaHH, hh.MaDV, hh.TenHH, hh.MaNH, hh.MaLHH, hh.MaKho, hh.Anh, hh.TonKhoToiThieu, hh.TonKhoHienTai, hh.GiaMua, hh.GiaBanLe, hh.GiaBanSi, 0);
            return db.ExcuteSql(sql);
        }
        public DataTable KiemTrahangHoaNayDaTonTaioKhoNay(string masp, string makho)
        {
            string sql = string.Format("select * from HangHoa where MaHH like '{0}' and MaKho like '{1}'", masp, makho);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNV()
        {
            string sql = "select TenNV as [Tên], MaNV as [Mã] from NhanVien";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinKho()
        {
            string sql = "select TenKH as [Tên], MaKH as [Mã] from KhoHang";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinDK_ThanhToan()
        {
            string sql = "select TenDKTT as [Tên] , MaDKTT as [Mã] from DK_ThanhToan";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinHT_ThanhToan()
        {
            string sql = "select TenHHTT as [Tên] , MaHHTT as [Mã] from HT_ThanhToan";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinHangHoa()
        {
            string sql = "select MaHH as [Mã Hàng], TenHH as [Tên Hàng], TonKhoHienTai as [Tồn Kho], kh.TenKH as [Kho Hàng], GiaMua as [Giá Mua] ,GiaBanLe as [Giá Bán Lẻ], GiaBanSi as [Giá Bán Sỉ]" +
                        "from HangHoa hh, KhoHang kh where kh.MaKH = hh.MaKho";

            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinHoaDonAo()
        {
            string sql = "select * from ChiTietHoaDonAo_MH";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhaCungCapTheoMaNCC(string MaNCC)
        {
            string sql = string.Format("select * from NhaCungCap  where MaNCC = '{0}'", MaNCC);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinHangHoaTheoMaHH(string MaHH)
        {
            string sql = string.Format("select TenHH, dvt.TenDVT, GiaMua, hh.GiaBanSi, hh.GiaBanLe, TonKhoHienTai from HangHoa hh, DonViTinh dvt where MaHH like '{0}' and hh.MaDV = dvt.MaDVT", MaHH);
            return db.GetDataTable(sql);
        }
        public DataTable LayPhieuNhapHangTheoMaPhieuNhapHang(string mapnh)
        {
            string sql = string.Format("select * from PhieuNhapHang where MaPNH like '{0}'", mapnh);
            return db.GetDataTable(sql);
        }
        public int ThemPhieuNhapNhang(PhieuNhapHangDTO pnh)
        {
            string sql = string.Format("insert into PhieuNhapHang(MaPNH, MaNV, MaNCC, DiaChi, GhiChu, MaKho, SoVAT, SoPhieuVT, DK_ThanhToan, HT_ThanhToan, HanThanhToan, NgayLap, VAT, CK, TongThanhTien, IsDaThanhToan)" +
                         "values('{0}', '{1}', '{2}', N'{3}', N'{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', {14}, '{15}')", 
                         pnh.MaPNH, pnh.MaNV, pnh.MaNCC, pnh.DiaChi, pnh.GhiChu, pnh.MaKho, pnh.SoVAT, pnh.SoPhieuVT, pnh.DK_ThanhToan, pnh.HT_ThanhToan, pnh.HanThanhToan, pnh.NgayLap, pnh .VAT, pnh.CK, pnh.TongThanhTien, "false");
            return db.ExcuteSql(sql);
        }
        public int ThemCT_PhieuNhapHang(CT_PhieuNhapHangDTO ctpnh)
        {
            string sql = string.Format("insert into CT_PhieuNhapHang(MaPhieuNhapHang, MaSanPham, TenSanPham, DonVi, SoLuong, DonGia, ThanhTien, GhiChu)values('{0}', '{1}', N'{2}', N'{3}', {4}, {5}, {6}, N'{7}')",
                           ctpnh.MaPhieuNhapHang, ctpnh.MaSanPham, ctpnh.TenSanPham, ctpnh.DonVi, ctpnh.SoLuong, ctpnh.DonGia, ctpnh.ThanhTien, ctpnh.GhiChu);
            return db.ExcuteSql(sql);
        }
        public int CapNhatSoLuongTonKhoHienTaiCuaHangHoa(string mahh, int soluong,string makho)
        {
            string sql = string.Format("update HangHoa set TonKhoHienTai = {0} where MaHH like '{1}' and MaKho like '{2}'", soluong, mahh, makho);
            return db.ExcuteSql(sql);
        }
        public int CapNhatPhieuNhapHang(PhieuNhapHangDTO pnh)
        {
            string sql = string.Format("update PhieuNhapHang set MaNV = '{0}', MaNCC = '{1}', DiaChi = N'{2}', GhiChu = N'{3}', MaKho = '{4}', SoVAT = '{5}', SoPhieuVT = '{6}', DK_ThanhToan = '{7}'," +
                    " HT_ThanhToan = '{8}', HanThanhToan = '{9}', NgayLap = '{10}', VAT = '{11}', CK = '{12}', TongThanhTien = {13} where MaPNH like '{14}'",
                     pnh.MaNV, pnh.MaNCC, pnh.DiaChi, pnh.GhiChu, pnh.MaKho, pnh.SoVAT, pnh.SoPhieuVT, pnh.DK_ThanhToan, pnh.HT_ThanhToan, pnh.HanThanhToan, pnh.NgayLap, pnh.VAT,
                     pnh.CK, pnh.TongThanhTien, pnh.MaPNH);
            return db.ExcuteSql(sql);
        }
        public int XoaPhieuNhapHang(string mpnh)
        {
            string sql = string.Format("delete PhieuNhapHang where MaPNH like '{0}'", mpnh);
            return db.ExcuteSql(sql);
        }
        public int XoaCT_PhieuNhapHang(string mpnh)
        {
            string sql = string.Format("delete CT_PhieuNhapHang where MaPhieuNhapHang like '{0}'", mpnh);
            return db.ExcuteSql(sql);
        }
        public DataTable LayThongTinPhieuNhapHangTheo_MaPNH(string mapnh1)
        {
            string sql = string.Format("select * from PhieuNhapHang where MaPNH like '{0}'", mapnh1);
            return db.GetDataTable(sql);
        }
        public int CapNhatViTriCT_PhieuNhapHang(string mapnh, int vitri)
        {
            string sql = string.Format("update CT_PhieuNhapHang set ViTri = {0} where MaPhieuNhapHang like '{1}' and ViTri  = {2}", 
                vitri, mapnh, vitri + 1);
            return db.ExcuteSql(sql);
        }
        public DataTable LayChiTietPhieuNhapHangTheoMaPNH(string MaPNH)
        {
            string sql = string.Format("select * from CT_PhieuNhapHang where MaPhieuNhapHang like '{0}'", MaPNH);
            return db.GetDataTable(sql);
        }
        public int XoaCT_PhieuNhapHangThemMaPNH_MaSP_ViTri(string mapnh, string tensp, int vitri)
        {
            string sql = string.Format("delete CT_PhieuNhapHang where MaPhieuNhapHang like '{0}' and MaSanPham like '{1}' and ViTri = {2}", mapnh, tensp, vitri);
            return db.ExcuteSql(sql);
        }
        public int XoaChiTietPhieuNhapHangAO()
        {
            string sql = "delete ChiTietHoaDonAo_MH";
            return db.ExcuteSql(sql);
        }
        public int TheoChiTietHoaDonAo_MH(string mh, string tenhang, string donvi, int soluong, float dongia, float thanhtien, string ghichu)
        {
            string sql = string.Format("insert into ChiTietHoaDonAo_MH([Mã Hàng], [Tên Hàng], [Đơn Vị], [Số Lượng], [Đơn Giá], [Thành Tiền], [Ghi Chú])" +
                        "values('{0}', N'{1}', N'{2}', {3}, {4}, {5}, N'{6}')", 
                                mh, tenhang, donvi, soluong, dongia, thanhtien, ghichu);

            return db.ExcuteSql(sql);
        }
        public int CapNhatCT_PNH(CT_PhieuNhapHangDTO ctpnh)
        {
            string sql = string.Format("update CT_PhieuNhapHang set TenSanPham = N'{0}', SoLuong = {1}, DonVi = N'{2}', DonGia = {3}, ThanhTien = {4}, GhiChu = N'{5}' " +
                "where MaPhieuNhapHang like '{6}' and MaSanPham like '{7}'",
                ctpnh.TenSanPham, ctpnh.SoLuong, ctpnh.DonVi, ctpnh.DonGia, ctpnh.ThanhTien, ctpnh.GhiChu, ctpnh.MaPhieuNhapHang, ctpnh.MaSanPham);
            return db.ExcuteSql(sql);
        }
        public DataTable KiemTraChiTietPhieuNhapHangDaTonTaiTheo_MaPNH_MaSP(string mapnh, string masp, int vitri)
        {
            string sql = string.Format("select * from CT_PhieuNhapHang where MaPhieuNhapHang like '{0}' and MaSanPham like '{1}' and ViTri = {2}", mapnh, masp, vitri);
            return db.GetDataTable(sql);
        }

    }
}
