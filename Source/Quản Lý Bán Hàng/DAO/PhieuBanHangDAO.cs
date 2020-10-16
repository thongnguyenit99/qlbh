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
    public class PhieuBanHangDAO
    {
        DB db = new DB();
        public DataTable LayThongTinKhachHang_Ma()
        {
            string sql = "select MakH as[Mã], TenKH [Khách Hàng] from khachhang";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinKhachHang_Ten()
        {
            string sql = "select TenKH [Khách Hàng], MakH as[Mã] from khachhang";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinPhieuNhapHang()
        {
            string sql = "select * from PhieuBanHang";
            return db.GetDataTable(sql);
        }
        public DataTable LayToanBoThongTinKhachHangTheoMaKH(string MaKH)
        {
            string sql = "select * from KhachHang where MaKH like 'KH000001'";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinCT_PhieuMuaHangAo()
        {
            string sql = "select * from CT_PhieuBanHang_AO";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinGiaBan()
        {
            string sql = "Select * from GiaBan";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinPhieuBanHangTheoMaPBH(string mapbh)
        {
            string sql = string.Format("select * from PhieuBanHang where MaPBH like '{0}'", mapbh);
            return db.GetDataTable(sql);
        }
        public int ThemPhieuBanHang(PhieuBanHangDTO pbh)
        {
            string sql = string.Format("insert into PhieuBanHang(MaPBH, MaNV, MaKH, DiaChi, GhiChu, MaKho, SoVAT, SoPhieuVT, DK_ThanhToan, HT_ThanhToan, HanThanhToan, NgayGiao, NgayLap, VAT, CK, TongThanhTien, IsDaThuTien)" +
                        "values('{0}', '{1}', '{2}', N'{3}', N'{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', {16})", 
                        pbh.MaPBH, pbh.MaNV, pbh.MaKH, pbh.DiaChi, pbh.GhiChu, pbh.MaKho, pbh.SoVAT, pbh.SoPhieuVT, pbh.DK_ThanhToan, pbh.HT_ThanhToan, pbh.HanThanhToan, pbh.NgayGiao, pbh.NgayLap, pbh.VAT, pbh.CK, pbh.TongThanhTien, 0);
            return db.ExcuteSql(sql);
        }
        public int ThemCT_PhieuBanHang(CT_PhieuBanHangDTO ctpbh)
        {
            string sql = string.Format("insert into CT_Phieu_Ban_Hang(MaPhieuBanHang, MaSanPham, TenSanPham, SoLuong, DonVi, LoaiGia, DonGia, ThanhTien, CK, ChietKhau, ThanhToan, ViTri)" +
                        "values('{0}', '{1}', N'{2}',{3}, N'{4}',{5}, {6}, {7}, {8}, {9}, {10}, {11})", ctpbh.MaPhieuBanHang, ctpbh.MaSanPham, ctpbh.TenSanPham, ctpbh.SoLuong, ctpbh.DonVi, ctpbh.LoaiGia, ctpbh.DonGia, ctpbh.ThanhTien, ctpbh.CK, ctpbh.ChietKhau, ctpbh.ThanhToan, ctpbh.ViTri);
            return db.ExcuteSql(sql);
        }

        public DataTable LaySoLuongHangHoaTonKhoTheoMaHangHoa(string Mahh, string makho)
        {
            string sql = string.Format("select  TonKhoHienTai, TonKhoToiThieu from HangHoa where MaHH like '{0}' and MaKho like '{1}'", Mahh, makho);
            return db.GetDataTable(sql);
        }
        public int CapNhatTonKhoHienTaiCuaHangHoa(string mhh, int soluong, string makho)
        {
            string sql = string.Format("update HangHoa set TonKhoHienTai = {0} where MaHH like '{1}' and MaKho like '{2}'", soluong, mhh, makho);
            return db.ExcuteSql(sql);
        }
        public int XoaPhieuBanHang(string mapbh)
        {
            string sql = string.Format("delete PhieuBanHang where MaPBH like '{0}'", mapbh);
            return db.ExcuteSql(sql);
        }
        public int XoaCT_PhieuBanHang(string mapbh)
        {
            string sql = string.Format("delete CT_Phieu_Ban_Hang where MaPhieuBanHang like '{0}'", mapbh);
            return db.ExcuteSql(sql);
        }
        public int XoaCT_PhieuMuaHangAO()
        {
            string sql = "delete CT_PhieuBanHang_AO";
            return db.ExcuteSql(sql);
        }
        public int ThemDuLieuBangPhieuMuaHangAo(string mahang, string tenhang, string donvi, int loaigia, int soluong, float dongia, float thanhtien,float ck, float chietkhau, float thanhtoan)
        {
            string sql = string.Format("insert into CT_PhieuBanHang_AO([Mã Hàng], [Tên Hàng], [Đơn Vị], [Loại Giá], [Số Lượng], [Đơn Giá], [Thành Tiền], CK, [Chiết Khấu], [Thanh Toán]) " +
            " values('{0}', N'{1}', N'{2}', {3}, {4}, {5}, {6}, {7}, {8}, {9})", 
            mahang, tenhang, donvi, loaigia, soluong, dongia, thanhtien, ck, chietkhau, thanhtoan);
            return db.ExcuteSql(sql);
        }
        public DataTable LayThongTinPhieuBanHangTheoMa(string mapbh)
        {
            string sql = string.Format("select pbh.MaKH, MaPBH, pbh.DiaChi, kh.DienThoai, pbh.NgayLap, pbh.GhiChu, pbh.SoVAT, pbh.MaNV, pbh.SoPhieuVT, pbh.MaKho, pbh.HanThanhToan, pbh.VAT, pbh.CK, pbh.TongThanhTien, " +
"pbh.HT_ThanhToan, pbh.DK_ThanhToan, pbh.HanThanhToan, pbh.NgayGiao from PhieuBanHang pbh, KhachHang kh,KhoHang khohang, DK_ThanhToan dktt, HT_ThanhToan httt " +
"where MaPBH like '{0}' and pbh.MaKho = khohang.MaKH and pbh.DK_ThanhToan = dktt.MaDKTT and pbh.HT_ThanhToan = httt.MaHHTT and pbh.MaKH = kh.MaKH ", mapbh);
            return db.GetDataTable(sql);
        }
        public DataTable LayChiTietPhieuBanHangTheoMa(string mapbh)
        {
            string sql = string.Format("select * from CT_Phieu_Ban_Hang where MaPhieuBanHang like '{0}'", mapbh);
            return db.GetDataTable(sql);
        }
        public int CapNhatPhieuBanHang(PhieuBanHangDTO pbh)
        {
            string sql = string.Format("update PhieuBanHang set MaNV = '{0}', MaKH = '{1}', DiaChi = N'{2}', GhiChu = N'{3}', MaKho = '{4}', SoVAT = '{5}', SoPhieuVT = '{6}', DK_ThanhToan = '{7}', " +
            " HT_ThanhToan = '{8}', HanThanhToan = '{9}', NgayGiao = '{10}', NgayLap = '{11}', VAT = '{12}', CK = '{13}', TongThanhTien = {14} where MaPBH like '{15}'",
            pbh.MaNV, pbh.MaKH, pbh.DiaChi, pbh.GhiChu, pbh.MaKho, pbh.SoVAT, pbh.SoPhieuVT, pbh.DK_ThanhToan, pbh.HT_ThanhToan, pbh.HanThanhToan, pbh.NgayGiao, pbh.NgayLap, pbh.VAT, pbh.CK, pbh.TongThanhTien, pbh.MaPBH);
            return db.ExcuteSql(sql);
        }
        public int CapNhatCT_PhieuBanHang(CT_PhieuBanHangDTO ctpbh)
        {
            string sql = string.Format("update CT_Phieu_Ban_Hang set MaSanPham = '{0}', TenSanPham = N'{1}', DonVi = N'{2}', LoaiGia = {3}, SoLuong = {4}, DonGia = {5}, " +
            "ThanhTien = {6}, CK = {7}, ChietKhau = {8}, ThanhToan = {9} where MaPhieuBanHang like '{10}' and ViTri = {11}",
            ctpbh.MaSanPham, ctpbh.TenSanPham, ctpbh.DonVi, ctpbh.LoaiGia, ctpbh.SoLuong, ctpbh.DonGia, ctpbh.ThanhTien, ctpbh.CK, ctpbh.ChietKhau, ctpbh.ThanhToan, ctpbh.MaPhieuBanHang, ctpbh.ViTri);
            return db.ExcuteSql(sql);
        }
        public DataTable LaySoLuongCuaSanPhamTrongCT_PhieuBanHang_Theo_MaPBH_MaSP(string mapbh, string masanpham, int vt)
        {
            string sql = string.Format("select * from CT_Phieu_Ban_Hang where MaPhieuBanHang like '{0}' and MaSanPham like '{1}' and ViTri = {2}", mapbh, masanpham, vt);
            return db.GetDataTable(sql);
        }
    }
}
