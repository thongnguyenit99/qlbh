using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class CapNhaVaiTroBUS
    {
        CapNhatVaiTroDAO CapNhatVaiTrodao = new CapNhatVaiTroDAO();
        public DataTable LayThongTinVaiTro(int tenvt)
        {
            return CapNhatVaiTrodao.LayThongTinVaiTro(tenvt);
        }
        public int LayQuyenTruyCapThanhMeNu(int vt)
        {
            DataTable dt = CapNhatVaiTrodao.LayQuyenTruyCapThanhMeNu(vt);
            return dt.Rows.Count;
        }
        public DataTable LayBangPhanQuyen(int vt)
        {
            return CapNhatVaiTrodao.LayBangPhanQuyen(vt);
        }
        public DataTable LayMenuBarID(int id)
        {
            return CapNhatVaiTrodao.LayMenuBarID(id);
        }
        public int CapNhatVaiTro(string mavt, string tenvaitro, string diengiai, bool conquanly)
        {
            return CapNhatVaiTrodao.CapNhatVaiTro(mavt, tenvaitro, diengiai, conquanly);
        }
        public int CapNhatBangPhanQuyen(int roldid, int formID, bool truycap, bool them, bool sua, bool xoa, bool in_dl, bool nhap, bool xuat)
        {
            return CapNhatVaiTrodao.CapNhatBangPhanQuyen(roldid, formID, truycap, them, sua, xoa, in_dl, nhap, xuat);
        }
        public string DeCuMaVT(ref int id)
        {
            DataTable dt = CapNhatVaiTrodao.DeCuMaVT();
            string temp = dt.Rows[dt.Rows.Count - 1]["Id"].ToString();
            id = int.Parse(temp);
            string tenvt = dt.Rows[dt.Rows.Count - 1]["MaVT"].ToString();
            tenvt = tenvt.Substring(0, tenvt.Length - temp.Length) + temp;
            return tenvt;
        }
        public bool KiemTraVaiTroTonTai(string mavt)
        {
            DataTable dt = CapNhatVaiTrodao.KiemTraVaiTroTonTai(mavt);
            if (dt.Rows.Count < 1)
                return false;
            return true;
        }
        public DataTable LayBangPhanQuyenAdmin()
        {
            return CapNhatVaiTrodao.LayBangPhanQuyenAdmin();
        }
        public int ThemVaiTro(string mavt, string tenvt, string diengiai, bool kichhoat)
        {
            return CapNhatVaiTrodao.ThemVaiTro(mavt, tenvt, diengiai, kichhoat);
        }
        public int ThemQuyenMotChucNangTrenThanhMeNu(int roleID, int menubarid, int trangthai)
        {
            return CapNhatVaiTrodao.ThemQuyenMotChucNangTrenThanhMeNu(roleID, menubarid, trangthai);
        }
        public int ThemBangPhanQuyen(int roldeid, int formID, bool truycap, bool them, bool sua, bool xoa, bool in_dl, bool nhap, bool xuat)
        {
            return CapNhatVaiTrodao.ThemBangPhanQuyen(roldeid, formID, truycap, them, sua, xoa, in_dl, nhap, xuat);
        }
        public int UpadateRoleMeNuBar(int roleID, int menubarid, int trangthai)
        {
            return CapNhatVaiTrodao.UpadateRoleMeNuBar(roleID, menubarid, trangthai);
        }
    }
}
