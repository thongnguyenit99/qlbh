using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class CapNhatKhoHangBUS
    {
        CapNhatKhoHangDAO capNhatKhoHangDAO = new CapNhatKhoHangDAO();
        public DataTable LayThongTinNhanVien()
        {
            return capNhatKhoHangDAO.LayThongTinNhanVien();
        }
        public DataTable LayThongTinKhoHangTheoMaKH(string makh)
        {
            return capNhatKhoHangDAO.LayThongTinKhoHangTheoMaKH(makh);
        }
        public int LayViTriNhanVienQuanLy(string makh)
        {
            DataTable dt = capNhatKhoHangDAO.LayThongTinNhanVien();
            DataTable dt1 = capNhatKhoHangDAO.LayThongTinKhoHangTheoMaKH(makh);
            if (dt1.Rows[0]["NguoiQuanLy"].ToString() != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Mã"].ToString() == dt1.Rows[0]["NguoiQuanLy"].ToString())
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public bool KiemTraMaKhoHangDaTonTai(string makh)
        {
            DataTable dt = capNhatKhoHangDAO.LayThongTinKhoHangTheoMaKH(makh);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        public string DeXuatMaKH()
        {
            DataTable dt = capNhatKhoHangDAO.LayThongTinKhoHang();
            string temp = dt.Rows[dt.Rows.Count - 1]["Id"].ToString();
            string MaKH = dt.Rows[dt.Rows.Count - 1]["MaKH"].ToString();
            MaKH = MaKH.Substring(0, MaKH.Length - temp.Length) + (int.Parse(temp) + 1).ToString();
            return MaKH;
        }
        public int ThemKhoHangBTN(KhoHangDTO kho)
        {
            return capNhatKhoHangDAO.ThemKhoHangBTN(kho);
        }
        public int CapNhatKhoHangBTN(KhoHangDTO kho)
        {
            return capNhatKhoHangDAO.CapNhatKhoHangBTN(kho);
        }
    }
}
