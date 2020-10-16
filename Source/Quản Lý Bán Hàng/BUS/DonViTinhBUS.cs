using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class DonViTinhBUS
    {
        DonViTinhDAO donViTinhDAO = new DonViTinhDAO();
        public DataTable LayDuLieuBangDonVi()
        {
            return donViTinhDAO.LayDuLieuBangDonVi();
        }
        public int XoaNhaCungCap(string madvt)
        {
            return donViTinhDAO.XoaNhaCungCap(madvt);
        }
    }
}
