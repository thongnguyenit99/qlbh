using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class CapNhatDonViTinhBUS
    {
        CapNhatDonViTinhDAO capNhatDonViTinhDAO = new CapNhatDonViTinhDAO();
        public DataTable LayThongTinDonViTinhTheoMa(string mdvt)
        {
            return capNhatDonViTinhDAO.LayThongTinDonViTinhTheoMa(mdvt);
        }
        public string DeNghiMaDonViTinh()
        {
            DataTable dt = capNhatDonViTinhDAO.LayThongTinDonViTinh();
            string temp = dt.Rows[dt.Rows.Count - 1]["Id"].ToString();
            string MaDVT = dt.Rows[dt.Rows.Count - 1]["MaDVT"].ToString();
            MaDVT = MaDVT.Substring(0, MaDVT.Length - temp.Length) + (int.Parse(temp) + 1).ToString();
            return MaDVT;
        }
        public bool KiemTraMaDonViTinhTonTai(string madvt)
        {
            DataTable dt = capNhatDonViTinhDAO.LayThongTinDonViTinhTheoMa(madvt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public int ThemDonViTinhBTN(string madvt, string tendvt, string ghichu, string conquanly)
        {
            return capNhatDonViTinhDAO.ThemDonViTinhBTN(madvt, tendvt, ghichu, conquanly);
        }
        public int CapNhatDonViTinhBTN(string madvt, string tendvt, string ghichu, string conquanly)
        {
            return capNhatDonViTinhDAO.CapNhatDonViTinhBTN(madvt, tendvt, ghichu, conquanly);
        }
    }
    
}
