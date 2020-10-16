using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class UC_BanHang_DanhSachPhieuTraNgayDAO
    {
        DB db = new DB();
        public DataTable LayThongTinPhieuThuTheoTraNgay(string tungay, string denngay)
        {
            string sql = string.Format("select MaPBH as [ChungTu], pbh.NgayLap as [Ngay], pbh.MaKH, kh.TenKH, pbh.DiaChi, pbh.TongThanhTien as [SoTien] " +
"from PhieuBanHang pbh, DK_ThanhToan dktt, KhachHang kh " + " where pbh.IsDaThuTien = 0 and pbh.DK_ThanhToan like 'DKTT02' and pbh.DK_ThanhToan = dktt.MaDKTT " +
"and pbh.MaKH = kh.MaKH and NgayLap between '{0}' and '{1}'", tungay, denngay);

            return db.GetDataTable(sql);
        }
    }
}
