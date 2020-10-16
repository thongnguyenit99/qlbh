using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        public DataTable LayThongTinKhuVuc()
        {
            return khachHangDAO.LayThongTinKhuVuc();
        }
        public DataTable LayThongTinKhachHang()
        {
            return khachHangDAO.LayThongTinKhachHang();
        }
        public DataTable LayKhachHangTheoTenKhuVuc(string tenkv)
        {
            return khachHangDAO.LayKhachHangTheoTenKhuVuc(tenkv);
        }
        public int XoaKhachHang(string Makh)
        {
            return khachHangDAO.XoaKhachHang(Makh);
        }
    }
}
