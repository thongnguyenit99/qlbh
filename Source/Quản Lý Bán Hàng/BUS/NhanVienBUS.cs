using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nhanVienDAO = new NhanVienDAO();

        public DataTable LayThongTinNhanVien()
        {
            return nhanVienDAO.LayThongTinNhanVien();
        }
        public int XoaNhanVien(string manv)
        {
            return nhanVienDAO.XoaNhanVien(manv);
        }
    }
}
