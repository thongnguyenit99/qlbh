using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class TonKhoBUS
    {
        TonKhoDAO tonKhoDAO = new TonKhoDAO();
        public DataTable LayThongTinTonKho()
        {
            return tonKhoDAO.LayThongTinTonKho();
        }
    }
}
