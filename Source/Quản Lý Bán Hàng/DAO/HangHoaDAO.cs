using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class HangHoaDAO
    {
        DB db = new DB();
        public DataTable LayThongTinNhomHang()
        {
            string sql = "select Ma_NH as [Mã], Ten_NH as [Tên Nhóm Hàng] from NhomHang";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongHangHoa()
        {
            string sql = "select MaHH as [Mã Hàng], TenHH as [Tên hàng], dvt.TenDVT as [Đơn vị], MaNH as [Mã Nhóm Hàng], GiaMua as [Giá mua], GiaBanSi as [Giá bán sỉ]," +
                        "GiaBanLe as [Giá bán lẻ], TonKhoToiThieu as [Tối thiểu], lhh.TenLHH as [Tính chất], kh.TenKH as [Kho mặc định], hh.ConQuanLy as [Còn quản lý]" +
                        "from HangHoa hh, DonViTinh dvt, KhoHang kh, LoaiHangHoa lhh where hh.MaDV = dvt.MaDVT and hh.MaKho = kh.MaKH and hh.MaLHH = lhh.MaLHH and IsDelete = 0";
            return db.GetDataTable(sql);
        }
        public DataTable LayHangHoaTheoMaNhomHang(string manh)
        {
            string sql = string.Format("select MaHH as [Mã Hàng], TenHH as [Tên hàng], dvt.TenDVT as [Đơn vị], GiaMua as [Giá mua], GiaBanSi as [Giá bán sỉ]," +
                        "GiaBanLe as [Giá bán lẻ], TonKhoToiThieu as [Tối thiểu], lhh.TenLHH as [Tính chất], kh.TenKH as [Kho mặc định], hh.ConQuanLy as [Còn quản lý]" +
                        "from HangHoa hh, DonViTinh dvt, KhoHang kh, LoaiHangHoa lhh where hh.MaDV = dvt.MaDVT and hh.MaKho = kh.MaKH and hh.MaLHH = lhh.MaLHH and hh.MaNH like '{0}'", manh);
            return db.GetDataTable(sql);
        }
        public int XoaHangHoa(string mahh)
        {
            string sql = string.Format("Update HangHoa Set IsDelete = 1 where MaHH like '{0}'", mahh);
            return db.ExcuteSql(sql);
        }
    }
}
