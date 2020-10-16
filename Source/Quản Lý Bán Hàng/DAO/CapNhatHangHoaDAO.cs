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
    public class CapNhatHangHoaDAO
    {
        DB db = new DB();
        public DataTable LayThongTinHangHoa()
        {
            string sql = "Select Max(Id) as Id from HangHoa";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinHangHoaTheoMaHH(string mahh)
        {
            string sql = string.Format("Select * from HangHoa where MaHH like '{0}'", mahh);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinLoaiHangHoa()
        {
            string sql = "select TenLHH as [Tên], MaLHH as [Mã] from LoaiHangHoa";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinKhoHang()
        {
            string sql = "select TenKH as [Kho Hàng], MaKH as [Mã] from KhoHang";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhomHang()
        {
            string sql = "select Ten_NH as [Nhóm Hàng], Ma_NH as [Mã] from NhomHang";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinDonVi()
        {
            string sql = "select TenDVT as [Đơn Vị], MaDVT as [Mã] from DonViTinh";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhaCungCap()
        {
            string sql = "select TenNCC as [Nhà Phân Phối], MaNCC as [Mã] from NhaCungCap";
            return db.GetDataTable(sql);
        }
        public int ThemtHangHoaBTN(HangHoaDTO hh)
        {
            string sql = string.Format("insert into HangHoa(MaHH, TenHH, MaDV, MaNH, MaLHH, MaKho, MaVachNSX, XuatXu, TonKhoToiThieu, TonKhoHienTai, Anh, MaNCC, GiaMua, GiaBanSi, GiaBanLe, ConQuanLy, IsDelete)" +
                                        "values('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', N'{7}', {8}, {9}, '{10}', '{11}', {12}, {13}, {14}, '{15}', {16})", 
                                        hh.MaHH, hh.TenHH, hh.MaDV, hh.MaNH, hh.MaLHH, hh.MaKho, hh.MaVachNSX, hh.XuatXu, hh.TonKhoToiThieu, hh.TonKhoHienTai, hh.Anh, hh.MaNCC,hh.GiaMua, hh.GiaBanSi, hh.GiaBanLe, hh.ConQuanLy, 0);
            return db.ExcuteSql(sql);
        }
        public int CapNhatHangHoaBTN(HangHoaDTO hh)
        {
            string sql = string.Format("update HangHoa set TenHH = N'{0}', MaDV = '{1}', MaNH = '{2}', MaLHH = '{3}', MaKho = '{4}', MaVachNSX = '{5}', XuatXu = N'{6}', TonKhoToiThieu = {7}, TonKhoHienTai = {8}, Anh = '{9}', MaNCC = '{10}', GiaMua = {11}, GiaBanSi = {12}, GiaBanLe = {13}, ConQuanLy = '{14}', IsDelete = {15} where MaHH like '{16}'",
                                       hh.TenHH, hh.MaDV, hh.MaNH, hh.MaLHH, hh.MaKho, hh.MaVachNSX, hh.XuatXu, hh.TonKhoToiThieu, hh.TonKhoHienTai, hh.Anh, hh.MaNCC, hh.GiaMua, hh.GiaBanSi, hh.GiaBanLe, hh.ConQuanLy, 0, hh.MaHH);
            return db.ExcuteSql(sql);
        }
    }
}
