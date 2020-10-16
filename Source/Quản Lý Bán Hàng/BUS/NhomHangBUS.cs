using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class NhomHangBUS
    {
        NhomHangDAO nhomHangDAO = new NhomHangDAO();
        public DataTable LayThongTinNhomHang()
        {
            return nhomHangDAO.LayThongTinNhomHang();
        }
        public int XoaNhomHang(string manh)
        {
            return nhomHangDAO.XoaNhomHang(manh);
        }
    }
}
