using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class HangHoaBUS
    {
        HangHoaDAO hangHoaDAO = new HangHoaDAO();
        public DataTable LayThongTinNhomHang()
        {
            return hangHoaDAO.LayThongTinNhomHang();
        }
        public DataTable LayThongHangHoa()
        {
            return hangHoaDAO.LayThongHangHoa();
        }
        public DataTable LayHangHoaTheoMaNhomHang(string manh)
        {
            return hangHoaDAO.LayHangHoaTheoMaNhomHang(manh);
        }
        public int XoaHangHoa(string mahh)
        {
            return hangHoaDAO.XoaHangHoa(mahh);
        }
    }
}
