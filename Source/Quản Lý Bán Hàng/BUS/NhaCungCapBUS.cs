using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    class NhaCungCapBUS
    {
        NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();
        public DataTable LayThongTinKhuVuc()
        {
            return nhaCungCapDAO.LayThongTinKhuVuc();
        }
        public DataTable LayThongTinNhaCungCap()
        {
            return nhaCungCapDAO.LayThongTinNhaCungCap();
        }
        public DataTable LayThongTinNhaCungCapTheoKV(string makv)
        {
            return nhaCungCapDAO.LayThongTinNhaCungCapTheoKV(makv);
        }
        public int XoaNhaCungCap(string mancc)
        {
            return nhaCungCapDAO.XoaNhaCungCap(mancc);
        }
    }
}
