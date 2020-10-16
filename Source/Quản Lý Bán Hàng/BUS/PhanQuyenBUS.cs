using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class PhanQuyenBUS
    {
        PhanQuyenDAO phanQuyenDAO = new PhanQuyenDAO();
        public DataTable getAllRolForm(int roleID)
        {
            return phanQuyenDAO.getAllRolForm(roleID);
        }
        public DataTable getAllRoleUser()
        {
            return phanQuyenDAO.getAllRoleUser();
        }
        public DataTable getUserName(int roleID)
        {
            return phanQuyenDAO.getUserName(roleID);
        }
        public DataTable getDaTaUser(int roleID)
        {
            return phanQuyenDAO.getDaTaUser(roleID);
        }
        public int XoaVaiTro(int id)
        {
            return phanQuyenDAO.XoaVaiTro(id);
        }
        public int XoaTaiKhoan(string tentk)
        {
            return phanQuyenDAO.XoaTaiKhoan(tentk);
        }
    }
}
