using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Bán_Hàng.DAO
{
    public class DangNhapDAO
    {
        DB db = new DB();
        public bool CheckLogin(string taikhoan, string pass,  ref int roleId)
        {
            string sql =
            string.Format("select tk.UserName, tk.Passwd, tk.RoleID from TaiKhoan tk where tk.UserName = '{0}' and tk.Passwd = '{1}' ", taikhoan, pass);
            DataTable dt = db.GetDataTable(sql);
            if(dt.Rows.Count > 0 && dt != null)
            {
                roleId = int.Parse(dt.Rows[0]["RoleID"].ToString());
                return true;
            }
            return false;
        }
    }
}
