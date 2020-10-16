using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class CapNhatBoPhanBUS
    {
        CapNhatBoPhanDAO capNhatBoPhanDAO = new CapNhatBoPhanDAO();
        public DataTable LayThongTinDonViTinhTheoMa(string mabp)
        {
            return capNhatBoPhanDAO.LayThongTinBoPhanTheoMa(mabp);
        }
        public string DeNghiMaBoPhan()
        {
            string t = "BP0001";
            DataTable dt = capNhatBoPhanDAO.LayThongTinDonViTinh();
            string temp = dt.Rows.Count.ToString();
            t = t.Substring(0, t.Length - temp.Length) + (int.Parse(temp) + 1).ToString();
            return t;
        }
        public bool KiemTraMaBoPhanTonTai(string mabp)
        {
            DataTable dt = capNhatBoPhanDAO.LayThongTinBoPhanTheoMa(mabp);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public int ThemDonViTinhBTN(string mabp, string tenbp, string ghichu, string conquanly)
        {
            return capNhatBoPhanDAO.ThemBoPhanBTN(mabp, tenbp, ghichu, conquanly);
        }
        public int CapNhatDonViTinhBTN(string mabp, string tenbp, string ghichu, string conquanly)
        {
            return capNhatBoPhanDAO.CapNhatBoPhanBTN(mabp, tenbp, ghichu, conquanly);
        }
    }
}
