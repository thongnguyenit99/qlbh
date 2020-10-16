using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class NhatKyHeThongBUS
    {
        NhatKyHeThongDAO nhatKyHeThongDAO = new NhatKyHeThongDAO();
        public string LayRaTenForm(int id)
        {
            try
            {
                DataTable dt = nhatKyHeThongDAO.LayRaTenForm(id);
                return dt.Rows[0]["Ten"].ToString();
            }
            catch
            {
                return "";
            }
        }
        public string LayRaTenMayTinh()
        {
            return System.Environment.MachineName.ToString();
        }
        public string PhatSinhMaND()
        {
            string mank;
            DataTable dt = nhatKyHeThongDAO.LayThongTinNhatKy();
            if (dt.Rows.Count == 0)
            {
                mank = "NK00000001";
            }
            else
            {
                string id = (dt.Rows.Count + 1).ToString();
                string temp = dt.Rows[0]["MaND"].ToString();
                mank = temp.Substring(0, temp.Length - id.Length) + id;

            }
            return mank;
        }
        public DataTable LayThongTinNhatKy()
        {
            return nhatKyHeThongDAO.LayThongTinNhatKy();
        }
        public int ThemNhatKyHeThong(string chucnang, string hanhdong, string doituong)
        {
            string maytinh = LayRaTenMayTinh();
            string mand = PhatSinhMaND();
            string thoigian = DateTime.Now.ToString();
            return nhatKyHeThongDAO.ThemNhatKyHeThong(mand, maytinh, thoigian, chucnang, hanhdong, doituong);
        }
        public int XoaThongTinNhatKy(string mank)
        {
            return nhatKyHeThongDAO.XoaThongTinNhatKy(mank);
        }
    }
}
