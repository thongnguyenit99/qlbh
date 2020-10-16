using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Quan_Ly_Ban_Hang.BUS
{
    public class CapNhatKhuVucBUS
    {
        CapNhatKhuVucDAO capNhatKhuVucDAO = new CapNhatKhuVucDAO();
        public int KiemTraMaKhuVucDaTonTai(string makv)
        {
            DataTable dt = capNhatKhuVucDAO.KiemTraMaKhuVucDaTonTai(makv);
            return dt.Rows.Count;
        }
        public int ThemKhuVuc(string ma, string ten, string ghichu, string conquanly)
        {
            return capNhatKhuVucDAO.ThemKhuVuc(ma, ten, ghichu, conquanly);
        }
        public DataTable LayThongTinMotKhuVucTheoID(int id)
        {
            return capNhatKhuVucDAO.LayThongTinMotKhuVucTheoID(id);
        }
        public int CapNhatKhuVucBTN(string ma, string ten, string ghichu, string conquanly)
        {
            return capNhatKhuVucDAO.CapNhatKhuVucBTN(ma, ten, ghichu, conquanly);
        }
        public string DeCuMaKV()
        {
            DataTable dt = capNhatKhuVucDAO.LayThongTinKhuVuc();
            string temp = dt.Rows[dt.Rows.Count - 1]["Id"].ToString();
            string tenvt = dt.Rows[dt.Rows.Count - 1]["MaKV"].ToString();
            tenvt = tenvt.Substring(0, tenvt.Length - temp.Length) + (int.Parse(temp) + 1).ToString();
            return tenvt;
        }
    }
}
