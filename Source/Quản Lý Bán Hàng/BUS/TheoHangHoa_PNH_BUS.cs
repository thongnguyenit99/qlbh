using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class TheoHangHoa_PNH_BUS
    {
        TheoHangHoa_PNH_DAO TheoHangHoa_PNH_DAO = new TheoHangHoa_PNH_DAO();
        public DataTable LayThongTinNhaCungCap()
        {
            return TheoHangHoa_PNH_DAO.LayThongTinNhaCungCap();
        }
        public DataTable LayHangHoaTheoPhieuNhapHang(string tungay, string denngay)
        {
            return TheoHangHoa_PNH_DAO.LayHangHoaTheoPhieuNhapHang(tungay, denngay);
        }
        public DataTable LayHangHoaTheoPhieuNhapHang_MaNCC(string tungay, string denngay, string mancc)
        {
            return TheoHangHoa_PNH_DAO.LayHangHoaTheoPhieuNhapHang_MaNCC(tungay, denngay, mancc);
        }
    }
}
