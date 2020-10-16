using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class UC_BanHang_DanhSachPhieuThuBUS
    {
        UC_BanHang_DanhSachPhieuThuDAO uC_BanHang_DanhSachPhieuThuDAO = new UC_BanHang_DanhSachPhieuThuDAO();
        public DataTable LayDanhSachPhieuThuTheoNgay(string tungay, string denngay)
        {
            return uC_BanHang_DanhSachPhieuThuDAO.LayDanhSachPhieuThuTheoNgay(tungay, denngay);
        }
        public int XoaPhieuThuTien(string mapt, string mapbh)
        {
            int temp = uC_BanHang_DanhSachPhieuThuDAO.XoaPhieuThuTien(mapt);
            if(temp > 0)
            {
                uC_BanHang_DanhSachPhieuThuDAO.CapNhatPhieuBanHang(mapbh);
            }
            return temp;
        }
    }
}
