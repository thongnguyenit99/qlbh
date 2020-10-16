using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class UC_PhieuChiThanhToanTraNgayDAO
    {
        DB db = new DB();
        public DataTable LayThongTinPhieuNhapHangThanhToanNgay(string tungay, string denngay)
        {
            string sql = string.Format("select pnh.MaPNH as [ChungTu], NgayLap as [Ngay], dktt.TenDKTT as[LoaiPhieu], pnh.MaNCC as[MaKH], " +
                    "ncc.TenNCC as[KhachHang], pnh.DiaChi, ncc.DienThoai, TongThanhTien as [SoTien]" +
                    "from PhieuNhapHang pnh, DK_ThanhToan dktt, NhaCungCap ncc" +
                    " where pnh.DK_ThanhToan = dktt.MaDKTT and pnh.MaNCC = ncc.MaNCC and NgayLap between '{0}' and '{1}'" +
                    "and pnh.DK_ThanhToan like 'DKTT02' and IsDaThanhToan = 0", tungay, denngay);

            return db.GetDataTable(sql);
        }
    }
}
