using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class UC_BanHang_DanhSachPhieuCongNoChiTietBUS
    {
        UC_BanHang_DanhSachPhieuCongNoChiTietDAO uC_BanHang_DanhSachPhieuCongNoChiTietDAO = new UC_BanHang_DanhSachPhieuCongNoChiTietDAO();
        public DataTable LayThongTinPhieuBanHangCongNo(string tungay, string denngay)
        {
            return uC_BanHang_DanhSachPhieuCongNoChiTietDAO.LayThongTinPhieuBanHangCongNo(tungay, denngay);
        }
    }
}
