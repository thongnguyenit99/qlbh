using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quản_Lý_Bán_Hàng.DAO;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class TonKhoDAO
    {
        DB db = new DB();
        public DataTable LayThongTinTonKho()
        {
            string sql = "select hh.MaHH as[MaHang], kh.TenKH as [KhoHang], hh.TenHH as [TenHang], dv.TenDVT as[DonVi], hh.TonKhoHienTai as[SoLuong], nh.Ten_NH as[NhomHang], hh.ConQuanLy " +
           " from KhoHang kh, HangHoa hh, DonViTinh dv, NhomHang nh where kh.MaKH = hh.MaKho and hh.MaDV = dv.MaDVT and hh.MaNH = nh.Ma_NH ";
            return db.GetDataTable(sql);
        }
    }
}
