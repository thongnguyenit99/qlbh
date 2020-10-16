using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Bán_Hàng.BUS
{
    public class TrangChuBUS
    {
        TrangChuDAO trangChuDAO = new TrangChuDAO();
        // hàm lấy ra các nút mà tài khoản không có quyền
        public DataTable GetAllVisiableButton(int roleuser)
        {
            return trangChuDAO.GetAllVisiableButton(roleuser);
        }
        public DataTable GetAllRoleMenuBar(int RoleUser)
        {
            return trangChuDAO.GetAllRoleMenuBar(RoleUser);
        }
    }
}
