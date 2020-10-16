using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class UC_BanHang_DanhSachPhieuTraNgayBUS
    {
        UC_BanHang_DanhSachPhieuTraNgayDAO uC_BanHang_DanhSachPhieuTraNgayDAO = new UC_BanHang_DanhSachPhieuTraNgayDAO();
        public DataTable LayThongTinPhieuThuTheoTraNgay(string tungay, string denngay)
        {
            return uC_BanHang_DanhSachPhieuTraNgayDAO.LayThongTinPhieuThuTheoTraNgay(tungay, denngay);
        }
    }
}
