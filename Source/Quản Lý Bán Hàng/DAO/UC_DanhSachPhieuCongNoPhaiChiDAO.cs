using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quản_Lý_Bán_Hàng.DAO;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class UC_DanhSachPhieuCongNoPhaiChiDAO
    {
        DB db = new DB();
        public DataTable LayThongTinPhieuChi_CongNo(string ngaybd, string ngaykt)
        {
            string sql = string.Format("select MaPNH as[ChungTu], NgayLap as [Ngay], pnh.MaNCC, ncc.TenNCC as[NhaCungCap], TongThanhTien as[SoTien], GhiChu as [DienGiai]" +
                " from PhieuNhapHang pnh, NhaCungCap ncc where IsDaThanhToan = 0 and pnh.MaNCC = ncc.MaNCC and DK_ThanhToan like 'DKTT01' and NgayLap BETWEEN  '{0}' and '{1}'", ngaybd, ngaykt);
            return db.GetDataTable(sql);
        }
    }
}
