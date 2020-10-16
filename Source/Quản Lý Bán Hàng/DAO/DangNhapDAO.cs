using Quan_Ly_Ban_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<RoleForm> GetListRolform(int roleId)
        {
            var rs = new List<RoleForm>();
            string sql = string.Format("select * from RoleForm where RoleId = {0}", roleId);
            var dt = db.GetDataTable(sql);
            foreach(DataRow row in dt.Rows)
            {
                RoleForm Roleform = new RoleForm()
                {
                    Id = int.Parse(row["Id"].ToString()),
                    RoleId = int.Parse(row["RoleId"].ToString()),
                    FormId = int.Parse(row["FormId"].ToString()),
                    TruyCap = bool.Parse(row["TruyCap"].ToString()),
                    Them = bool.Parse(row["Them"].ToString()),
                    Sua = bool.Parse(row["Sua"].ToString()),
                    Xoa = bool.Parse(row["Xoa"].ToString()),
                    In_DL = bool.Parse(row["In_DL"].ToString()),
                    Nhap = bool.Parse(row["Nhap"].ToString()),
                    Xuat = bool.Parse(row["Xuat"].ToString())
                };
                rs.Add(Roleform);
            }
            return rs;
        }
    }
}
