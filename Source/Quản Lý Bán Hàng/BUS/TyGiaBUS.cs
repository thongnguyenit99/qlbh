using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class TyGiaBUS
    {
        TyGiaDAO tyGiaDAO = new TyGiaDAO();
        public DataTable LayThongTinBangTyGia()
        {
            return tyGiaDAO.LayThongTinBangTyGia();
        }
        public int XoaTyGia(string MaTG)
        {
            return tyGiaDAO.XoaTyGia(MaTG);
        }
    }
}
