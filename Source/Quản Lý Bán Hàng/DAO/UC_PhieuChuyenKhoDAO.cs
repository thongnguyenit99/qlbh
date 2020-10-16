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
    public class UC_PhieuChuyenKhoDAO
    {
        DB db = new DB();
        public DataTable LayThongTinKhoHang()
        {
            string sql = "select * from KhoHang";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhanVien()
        {
            string sql = "select * from NhanVien";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinPhieuChuyenKho()
        {
            string sql = "select Max(Id) as [Id] from ChuyenKho";
            return db.GetDataTable(sql);
        }
        public DataTable LayCT_phhieuChuyenKho_Ao()
        {
            string sql = "select * from CT_ChuyenKho_Ao";
            return db.GetDataTable(sql);
        }
        public DataTable LayDanhSachHangHoa()
        {
            string sql = "select MaHH as [MaSP], TenHH as [TenHang], TonKhoHienTai as [SoLuongTon], GiaMua as [Gia],  kh.TenKH as [KhoHang] " +
                "from HangHoa hh, KhoHang kh where hh.MaKho = kh.MaKH";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinHangHoaTheoMaHH(string mahh)
        {
            string sql = string.Format("select hh.*, dvt.TenDVT from HangHoa hh, DonViTinh dvt where hh.MaDV = dvt.MaDVT and MaHH like '{0}'", mahh);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinChiTietPhieuChuyenKhoTheoMa(string mapck)
        {
            string sql = string.Format("select * from CT_ChuyenKho where MaPhieuChuyenKho like '{0}'", mapck);
            return db.GetDataTable(sql);
        }
        public int XoaChiTietPhieuChuyenKhoAo()
        {
            string sql = "delete CT_ChuyenKho_Ao";
            return db.ExcuteSql(sql);
        }
        public int XoaChiTietPhieuChuyenKhoTheoMa(string MaPCK)
        {
            string sql = string.Format("delete CT_ChuyenKho where MaPhieuChuyenKho like '{0}'", MaPCK);
            return db.ExcuteSql(sql);
        }
        public int XoaPhieuhuyenKhotheoMa(string MAPCK)
        {
            string sql = string .Format("delete ChuyenKho where MaCK like '{0}'", MAPCK);
            return db.ExcuteSql(sql);
        }
        // THÊM
        public int ThemPhieuChuyenKho(PhieuChuyenKhoDTO pck)
        {
            string sql = string.Format("insert into ChuyenKho(MaCK, MaPVT, KhoXuatHang, KhoNhanHang, NguoiChuyen, NguoiNhan, NgayChuyen, SL_HangChuyen, TongTien, GhiChu)" +
" values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, {8}, '{9}')",pck.MaCK, pck.MaPVT, pck.KhoXuatHang, pck.KhoNhanHang, pck.NguoiChuyen, pck.NguoiNhan, pck.NgayChuyen, pck.SL_HangChuyen, pck.TongTien, pck.GhiChu);
            return db.ExcuteSql(sql);
        }
        public int ThemCT_PhieuChuyenKho(CT_PhieuChuyenKhoDTO ct_pck)
        {
            string sql = string.Format("insert into CT_ChuyenKho(MaPhieuChuyenKho, MaSanPham, TenSanPham, DonVi, SoLuong, DonGia, ThanhTien)" +
            " values('{0}', '{1}', N'{2}', N'{3}', {4}, {5}, {6})", ct_pck.MaPhieuChuyenKho, ct_pck.MaSanPham, ct_pck.TenSanPham, ct_pck.DonVi, ct_pck.SoLuong, ct_pck.DonGia, ct_pck.ThanhTien);

            return db.ExcuteSql(sql);
        }
    }
}
