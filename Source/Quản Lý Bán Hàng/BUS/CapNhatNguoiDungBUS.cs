using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class CapNhatNguoiDungBUS
    {
        CapNhatNguoiDungDAO CapNhatNguoiDungDAO = new CapNhatNguoiDungDAO();
        public DataTable LayThongTinTatCaNV()
        {
            return CapNhatNguoiDungDAO.LayThongTinTatCaNV();
        }
        public DataTable LayTTTaiKhoanNhanVien(string username)
        {
            return CapNhatNguoiDungDAO.LayTTTaiKhoanNhanVien(username);
        }
        public DataTable LayViTriTuTenTaiKhoan(string username)
        {
            return CapNhatNguoiDungDAO.LayViTriTuTenTaiKhoan(username);
        }
        public DataTable LayThongTinVaiTro()
        {
            return CapNhatNguoiDungDAO.LayThongTinVaiTro();
        }
        public int CapNhatNguoiDungBUSbtn(string tk, string manv, string mk, int vt, string diengiai, bool conquanly)
        {
            return CapNhatNguoiDungDAO.CapNhatNguoiDungBUSbtn(tk, manv, mk, vt, diengiai, conquanly);
        }
        public DataTable LayMaNVTuTenNV(string tennv)
        {
            return CapNhatNguoiDungDAO.LayMaNVTuTenNV(tennv);
        }
        public DataTable LayIdVaiTroTuTenVT(string tenvt)
        {
            return CapNhatNguoiDungDAO.LayIdVaiTroTuTenVT(tenvt);
        }
    }
}
