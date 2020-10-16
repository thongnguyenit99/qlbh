using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class UC_DanhSachPhieuChiBUS
    {
        UC_DanhSachPhieuChiDAO uC_DanhSachPhieuChiDAO = new UC_DanhSachPhieuChiDAO();
        public DataTable LayDanhSachPhieuChi(string tungay, string dennggay)
        {
            return uC_DanhSachPhieuChiDAO.LayDanhSachPhieuChi(tungay, dennggay);
        }
        public int XoaPhieuChi(string mapc, string mapnh)
        {
            if(uC_DanhSachPhieuChiDAO.XoaPhieuChi(mapc) > 0)
            {
                uC_DanhSachPhieuChiDAO.CapNhatPhieuNhapHang(mapnh);
                //if(uC_DanhSachPhieuChiDAO.CapNhatPhieuNhapHang(mapnh) > 0)
                //{
                return 1;
                //}
            }
            return 0;
        }
     }
}
