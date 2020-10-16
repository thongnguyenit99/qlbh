using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class KhuVucBUS
    {
        KhuVucDAO khuVucDAO = new KhuVucDAO();
        public DataTable LayThongTinKhuVuc()
        {
            return khuVucDAO.LayThongTinKhuVuc();
        }
        public int XoaMotKhuVuc(string makv)
        {
            return khuVucDAO.XoaMotKhuVuc(makv);
        }
    }
}
