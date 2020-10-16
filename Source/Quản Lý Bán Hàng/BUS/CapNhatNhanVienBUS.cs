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
    public class CapNhatNhanVienBUS
    {
        CapNhatNhanVienDAO capNhatNhanVienDAO = new CapNhatNhanVienDAO();
        DataTable dt;
        public DataTable LayThongTinNhanVienTheoMaNV(string manv)
        {
            return capNhatNhanVienDAO.LayThongTinNhanVienTheoMaNV(manv);
        }
        public string DeXuatMaNV()
        {
            dt = capNhatNhanVienDAO.LayThongTinNhanVien();
            string temp = dt.Rows.Count.ToString();
            string MaNV = dt.Rows[dt.Rows.Count - 1]["MaNV"].ToString();
            MaNV = MaNV.Substring(0, MaNV.Length - temp.Length) + (int.Parse(temp) + 1).ToString();
            return MaNV;
        }
        public DataTable LayThongTinBoPhanCB()
        {
            return capNhatNhanVienDAO.LayThongTinBoPhanCB();
        }
        public DataTable LayThongTinNhanVienCB()
        {
            return capNhatNhanVienDAO.LayThongTinNhanVienCB();
        }
        public int LayViTriBoPhan(string manv)
        {
            dt = capNhatNhanVienDAO.LayThongTinNhanVienTheoMaNV(manv);
            DataTable dt1 = capNhatNhanVienDAO.LayThongTinBoPhanCB();
            if (dt.Rows[0]["BoPhan"].ToString() != null)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (dt1.Rows[i]["Mã"].ToString() == dt.Rows[0]["BoPhan"].ToString())
                        return i;
                }
            }

            return -1;
        }
        public int LayViTriNhanVien(string manv)
        {
            dt = capNhatNhanVienDAO.LayThongTinNhanVienTheoMaNV(manv);
            DataTable dt1 = capNhatNhanVienDAO.LayThongTinNhanVienCB();
            if (dt.Rows[0]["QuanLy"].ToString() != null)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (dt1.Rows[i]["Mã"].ToString() == dt.Rows[0]["QuanLy"].ToString())
                        return i;
                }
            }

            return -1;
        }
        public int KiemTraMaNVTonTai(string manv)
        {
            dt = capNhatNhanVienDAO.LayThongTinNhanVienTheoMaNV(manv);
            return dt.Rows.Count;
        }
        public int ThemNhanVienBTN(NhanVienDTO nv)
        {
            return capNhatNhanVienDAO.ThemNhanVienBTN(nv);
        }
        public int CapNhatNhanVienBTN(NhanVienDTO nv)
        {
            return capNhatNhanVienDAO.CapNhatNhanVienBTN(nv);
        }
    } 
}
