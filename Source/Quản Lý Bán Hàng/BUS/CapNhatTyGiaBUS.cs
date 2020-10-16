using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class CapNhatTyGiaBUS
    {
        CapNhatTyGiaDAO CapNhatTyGiaDAO = new CapNhatTyGiaDAO();
        public DataTable LayThongTinBangTyGiaTheoMa(string matg)
        {
            return CapNhatTyGiaDAO.LayThongTinBangTyGiaTheoMa(matg);
        }
        public int KiemTraMaTGTonTai(string matg)
        {
            DataTable dt = CapNhatTyGiaDAO.LayThongTinBangTyGiaTheoMa(matg);
            return dt.Rows.Count;
        }
        public int ThemTyGiaBTN(string matg, string tentg, float gia, string conquanly)
        {
            return CapNhatTyGiaDAO.ThemTyGiaBTN(matg, tentg, gia, conquanly);
        }
        public int CapNhatTyGiaBTN(string matg, string tentg, float gia, string conquanly)
        {
            return CapNhatTyGiaDAO.CapNhatTyGiaBTN(matg, tentg, gia, conquanly);
        }

    }
}
