using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Bán_Hàng.DAO
{
    public class TrangChuDAO
    {
        DB db = new DB();
        // mặc định roleId giống RoldeUserId
        // Lấy ra danh sách các nút mà tài khoản này không có quyền và không thể nhìn thấy
        public DataTable GetAllVisiableButton(int roleUser)
        {
            string sql = string.Format("select nas.ButtonId from NoAcessButton nas where nas.RoleUserId = {0}", roleUser);
            return db.GetDataTable(sql);
        }
        public DataTable GetAllRoleMenuBar(int RoleUser)
        {
            string sql = string.Format("select MeNuBarId from RoleMenubar where RoleUserId = '{0}'", RoleUser);
            return db.GetDataTable(sql);
        }
    }
}
