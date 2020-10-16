using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class ThemNguoiDungBUS
    {
        ThemNguoiDungDAO themNguoiDungDAO = new ThemNguoiDungDAO();
        public DataTable GetInFoNhanVien()
        {
            return themNguoiDungDAO.GetInFoNhanVien();
        }
        public DataTable GetInForVaiTro()
        {
            return themNguoiDungDAO.GetInForVaiTro();
        }
        public bool CheckUserName(string tentk)
        {
            DataTable dt = themNguoiDungDAO.GetAllUserName();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["USERNAME"].ToString() == tentk)
                {
                    return false;
                }
            }
            return true;
        }
        public int ThemNguoiDungBTN(string tk, string pass, string manv, int RoleID, bool ql)
        {
            return themNguoiDungDAO.ThemNguoiDungBTN(tk, pass, manv, RoleID, ql);
        }
    }
}
