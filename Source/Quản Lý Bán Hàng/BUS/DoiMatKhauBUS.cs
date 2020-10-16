using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class DoiMatKhauBUS
    {
        DoiMatKhauDA0 doiMatKhauDA0 = new DoiMatKhauDA0();
        public string LayMatKhauTheoTaiKhoan(string tk)
        {
            DataTable dt = doiMatKhauDA0.LayMatKhauTheoTaiKhoan(tk);
            return dt.Rows[0]["Passwd"].ToString();
        }
        public int CapNhatMatKhau(string tk, string passnew)
        {
            return doiMatKhauDA0.CapNhatMatKhau(tk, passnew);
        }
    }
}
