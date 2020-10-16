using Quan_Ly_Ban_Hang.DAO;
using Quan_Ly_Ban_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class CapNhatNhaCungCapBUS
    {
        CapNhatNhaCungCapDAO CapNhatNhaCungCapDAO = new CapNhatNhaCungCapDAO();
        public DataTable LayThongTinKhuVuc()
        {
            return CapNhatNhaCungCapDAO.LayThongTinKhuVuc();
        }
        public string DeXuatMaNhaCungCap()
        {
            DataTable dt = CapNhatNhaCungCapDAO.LayThongTinNhaCungCap();
            string temp = dt.Rows[dt.Rows.Count - 1]["Id"].ToString();
            string MaNCC = dt.Rows[dt.Rows.Count - 1]["MaNCC"].ToString();
            MaNCC = MaNCC.Substring(0, MaNCC.Length - temp.Length) + (int.Parse(temp) + 1).ToString();
            return MaNCC;
        }
        public bool KiemTraMaNhaCungCap(string mancc)
        {
            DataTable dt = CapNhatNhaCungCapDAO.KiemTraMaNhaCungCap(mancc);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable LayThongTinNhaCungCapTheoMaNCC(string mancc)
        {
            return CapNhatNhaCungCapDAO.LayThongTinNhaCungCapTheoMaNCC(mancc);
        }
        public int ThemNhaCungCap(NhaCungCapDTO temp)
        {
            return CapNhatNhaCungCapDAO.ThemNhaCungCap(temp);
        }
        public string LayViTriCuaKhuVuc(string mancc)
        {
            DataTable dt = CapNhatNhaCungCapDAO.LayMaKVTheoMaNCC(mancc);
            return dt.Rows[0]["MaKV"].ToString(); 
               
        }
        public int CapNhatNhaCungCapBTN(NhaCungCapDTO temp)
        {
            return CapNhatNhaCungCapDAO.CapNhatNhaCungCapBTN(temp);
        }
    }
}
