using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class CapNhatHangHoaBUS
    {
        CapNhatHangHoaDAO capNhatHangHoaDAO = new CapNhatHangHoaDAO();
        DataTable dt;
        public string DeXuatMaHangHoa()
        {
            DataTable dt = capNhatHangHoaDAO.LayThongTinHangHoa();
            string temp = "HH00000";
            string Id = (int.Parse(dt.Rows[dt.Rows.Count - 1]["Id"].ToString()) + 1).ToString();
            temp = temp.Substring(0, temp.Length - Id.Length) + (int.Parse(Id)).ToString();
            return temp;
        }
        public DataTable LayThongTinHangHoaTheoMaHH(string mahh)
        {
            return capNhatHangHoaDAO.LayThongTinHangHoaTheoMaHH(mahh);
        }
        public DataTable LayThongTinLoaiHangHoa()
        {
            return capNhatHangHoaDAO.LayThongTinLoaiHangHoa();
        }
        public DataTable LayThongTinKhoHang()
        {
            return capNhatHangHoaDAO.LayThongTinKhoHang();
        }
        public DataTable LayThongTinNhomHang()
        {
            return capNhatHangHoaDAO.LayThongTinNhomHang();
        }
        public DataTable LayThongTinDonVi()
        {
            return capNhatHangHoaDAO.LayThongTinDonVi();
        }
        public DataTable LayThongTinNhaCungCap()
        {
            return capNhatHangHoaDAO.LayThongTinNhaCungCap();
        }
        public int LayViTriCuaLoaiHangHoa(string mahh)
        {
            DataTable dt1 = capNhatHangHoaDAO.LayThongTinHangHoaTheoMaHH(mahh);
            dt = capNhatHangHoaDAO.LayThongTinLoaiHangHoa();
            if (dt1.Rows[0]["MaLHH"].ToString() != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Mã"].ToString() == dt1.Rows[0]["MaLHH"].ToString())
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public int LayViTriCuaKhoHang(string mahh)
        {
            dt = capNhatHangHoaDAO.LayThongTinKhoHang();
            DataTable dt1 = capNhatHangHoaDAO.LayThongTinHangHoaTheoMaHH(mahh);
            if (dt1.Rows[0]["MaKho"].ToString() != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Mã"].ToString() == dt1.Rows[0]["MaKho"].ToString())
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public int LayViTriCuaNhomHang(string mahh)
        {
            dt = capNhatHangHoaDAO.LayThongTinNhomHang();
            DataTable dt1 = capNhatHangHoaDAO.LayThongTinHangHoaTheoMaHH(mahh);
            if (dt1.Rows[0]["MaNH"].ToString() != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Mã"].ToString() == dt1.Rows[0]["MaNH"].ToString())
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public int LayViTriCuaDonVi(string mahh)
        {
            dt = capNhatHangHoaDAO.LayThongTinDonVi();
            DataTable dt1 = capNhatHangHoaDAO.LayThongTinHangHoaTheoMaHH(mahh);
            if (dt1.Rows[0]["MaDV"].ToString() != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Mã"].ToString() == dt1.Rows[0]["MaDV"].ToString())
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public int LayViTriNhaCungCap(string mahh)
        {
            dt = capNhatHangHoaDAO.LayThongTinNhaCungCap();
            DataTable dt1 = capNhatHangHoaDAO.LayThongTinHangHoaTheoMaHH(mahh);
            if (dt1.Rows[0]["MaNCC"].ToString() != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Mã"].ToString() == dt1.Rows[0]["MaNCC"].ToString())
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public int KiemTrMaHangHoaDaTonTai(string mahh)
        {
            dt = capNhatHangHoaDAO.LayThongTinHangHoaTheoMaHH(mahh);
            return dt.Rows.Count;
        }
        public int ThemHangHoaBTN(HangHoaDTO hh)
        {
            return capNhatHangHoaDAO.ThemtHangHoaBTN(hh);
        }
        public int CapNhatHangHoaBTN(HangHoaDTO hh)
        {
            return capNhatHangHoaDAO.CapNhatHangHoaBTN(hh);
        }
    }
}
