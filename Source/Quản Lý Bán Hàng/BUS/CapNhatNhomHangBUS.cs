using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class CapNhatNhomHangBUS
    {
        CapNhatNhomHangDAO capNhatNhomHangDAO = new CapNhatNhomHangDAO();
        public DataTable LayThongTinNhomHangTheoMaNH(string mdvt)
        {
            return capNhatNhomHangDAO.LayThongTinNhomHangTheoMaNH(mdvt);
        }
        public string DeNghiMaDonViTinh()
        {
            string t = "NH000001";
            DataTable dt = capNhatNhomHangDAO.LayThongTinNhomHang();
            string temp = dt.Rows.Count.ToString();
            t = t.Substring(0, t.Length - temp.Length) + (int.Parse(temp) + 1).ToString();
            return t;
        }
        public bool KiemTraMaDonViTinhTonTai(string madvt)
        {
            DataTable dt = capNhatNhomHangDAO.LayThongTinNhomHangTheoMaNH(madvt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public int ThemNhomHangBTN(string madvt, string tendvt, string ghichu, string conquanly)
        {
            return capNhatNhomHangDAO.ThemNhomHangBTN(madvt, tendvt, ghichu, conquanly);
        }
        public int CapNhatNhomHangBTN(string madvt, string tendvt, string ghichu, string conquanly)
        {
            return capNhatNhomHangDAO.CapNhatNhomHangBTN(madvt, tendvt, ghichu, conquanly);
        }
    }
}
