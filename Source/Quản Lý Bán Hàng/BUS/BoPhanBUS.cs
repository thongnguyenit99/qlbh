using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Quan_Ly_Ban_Hang.BUS
{
    public class BoPhanBUS
    {
        BoPhanDAO boPhanDAO = new BoPhanDAO();
        public DataTable LayThongTinBoPhan()
        {
            return boPhanDAO.LayThongTinBoPhan();
        }
        public  int XoaBoPhan(string mabp)
        {
            return boPhanDAO.XoaBoPhan(mabp);
        }
    }
}
