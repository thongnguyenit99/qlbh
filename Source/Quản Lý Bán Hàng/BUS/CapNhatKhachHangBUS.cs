using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class CapNhatKhachHangBUS
    {
        CapNhatKhachHangDAO CapNhatKhachHangDAO = new CapNhatKhachHangDAO();
        public DataTable LayThongTinKhuVuc()
        {
            return CapNhatKhachHangDAO.LayThongTinKhuVuc();
        }
        public string DeNghiMaKhacHang()
        {
            DataTable dt = CapNhatKhachHangDAO.DeNghiMaKhacHang();
            string temp = dt.Rows[dt.Rows.Count - 1]["Id"].ToString();
            string MaKH = dt.Rows[dt.Rows.Count - 1]["MaKH"].ToString();
            MaKH = MaKH.Substring(0, MaKH.Length - temp.Length) + (int.Parse(temp) + 1).ToString();
            return MaKH;
        }
        public int KiemTraMaKhachHangTonTai(string makh)
        {
            DataTable dt = CapNhatKhachHangDAO.KiemTraMaKhachHangTonTai(makh);
            return dt.Rows.Count;
        }
        public DataTable LayThongTinKhachHangTheoMaKH(string makh)
        {
            return CapNhatKhachHangDAO.LayThongTinKhachHangTheoMaKH(makh);
        }
        public int ViTriKhoVuc(string makh)
        {
            DataTable dt = CapNhatKhachHangDAO.LayThongTinKhachHangTheoMaKH(makh);
            string makv = dt.Rows[0]["MaKV"].ToString();
            DataTable dt1 = CapNhatKhachHangDAO.LayThongTinKhuVuc();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if(makv == dt1.Rows[i]["MaKV"].ToString())
                {
                    return i;
                }
            }
            return 0;
        }
        public int ThemKhachHangBTN(string MaKH, string ten, string makhuvuc, string diachi, string masothue, string fax,
                            string dienthoai, string mobile, string email, string website, string taikhoan,
                            string nganhang, string gioihanno, string nohientai, string chietkhau, string nickyahoo
                            , string nguoilienhe, string nickype, string LoaiKH, string conquanly)
        {
            return CapNhatKhachHangDAO.ThemKhachHangBTN( MaKH,  ten,  makhuvuc,  diachi,  masothue,  fax, dienthoai,  mobile,  email,  website,  taikhoan,
                             nganhang,  gioihanno,  nohientai,  chietkhau,  nickyahoo,  nguoilienhe,  nickype, LoaiKH, conquanly);
        }
        public int CapNhatKhachHangBTN(string MaKH, string ten, string makhuvuc, string diachi, string masothue, string fax,
                    string dienthoai, string mobile, string email, string website, string taikhoan,
                    string nganhang, string gioihanno, string nohientai, string chietkhau, string nickyahoo
                    , string nguoilienhe, string nickype, string LoaiKH, string conquanly)
        {
            return CapNhatKhachHangDAO.CapNhatKhachHangBTN(MaKH, ten, makhuvuc, diachi, masothue, fax, dienthoai, mobile, email, website, taikhoan,
                             nganhang, gioihanno, nohientai, chietkhau, nickyahoo, nguoilienhe, nickype, LoaiKH, conquanly);
        }
    }
}
