using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Quan_Ly_Ban_Hang.BUS
{
    public class KhoHangBUS
    {
        KhoHangDAO khoHangDAO = new KhoHangDAO();
        public DataTable LayThongTinKhoHang()
        {
            return khoHangDAO.LayThongTinKhoHang();
        }
        public int XoaThongTinKhoHang(string makh)
        {
            return khoHangDAO.XoaThongTinKhoHang(makh);
        }
    } 
}
