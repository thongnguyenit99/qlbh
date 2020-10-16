using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class UC_BanHang_DanhSachPhieuCongNoChiTietDAO
    {
        DB db = new DB();
        public DataTable LayThongTinPhieuBanHangCongNo(string tungay, string denngay)
        {
            string sql = string.Format("select MaPBH as [ChungTu], pbh.NgayLap as [Ngay], pbh.MaKH, kh.TenKH, pbh.TongThanhTien as [SoTien], pbh.GhiChu " +
                "from PhieuBanHang pbh, KhachHang kh where IsDaThuTien = 0 and pbh.MaKH = kh.MaKH and NgayLap between '{0}' and '{1}' and pbh.DK_ThanhToan like 'DKTT01'", tungay, denngay);
            return db.GetDataTable(sql);
        }
    }
}
