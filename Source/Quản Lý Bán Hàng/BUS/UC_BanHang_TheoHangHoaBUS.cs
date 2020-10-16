using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class UC_BanHang_TheoHangHoaBUS
    {
        UC_BanHang_TheoHangHoaDAO uC_BanHang_TheoHangHoaDAO = new UC_BanHang_TheoHangHoaDAO();
        public DataTable LayThongTinPhieuNhapHangTheoHangHoa(string tungay, string denngay)
        {
            return uC_BanHang_TheoHangHoaDAO.LayThongTinPhieuNhapHangTheoHangHoa(tungay, denngay);
        }
        public DataTable LayThongTinPhieuNhapHangTheoHangHoa_MaKH(string tungay, string denngay, string MaKH)
        {
            return uC_BanHang_TheoHangHoaDAO.LayThongTinPhieuNhapHangTheoHangHoa_MaKH(tungay, denngay, MaKH);
        }
    }
}
