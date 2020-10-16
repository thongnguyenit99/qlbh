using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class UC_DanhSachPhieuCongNoPhaiChiBUS
    {
        UC_DanhSachPhieuCongNoPhaiChiDAO UC_DanhSachPhieuCongNoPhaiChiDAO = new UC_DanhSachPhieuCongNoPhaiChiDAO();
        public DataTable LayThongTinPhieuChi_CongNo(string ngaybd, string ngaykt)
        {
            return UC_DanhSachPhieuCongNoPhaiChiDAO.LayThongTinPhieuChi_CongNo(ngaybd, ngaykt);
        }
    }
}
