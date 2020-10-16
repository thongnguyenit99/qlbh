using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class UC_PhieuChiThanhToanTraNgayBUS
    {
        UC_PhieuChiThanhToanTraNgayDAO UC_PhieuChiThanhToanTraNgayDAO = new UC_PhieuChiThanhToanTraNgayDAO();
        public DataTable LayThongTinPhieuNhapHangThanhToanNgay(string tungay, string denngay)
        {
            return UC_PhieuChiThanhToanTraNgayDAO.LayThongTinPhieuNhapHangThanhToanNgay(tungay, denngay);
        }
    }
}
