using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Bán_Hàng.BUS
{
    public class DangNhapBUS
    {
        DangNhapDAO DangNhapDAO = new DangNhapDAO();
        public bool CheckLogin( string tk, string mk, ref int role)
        {
            return DangNhapDAO.CheckLogin(tk, mk, ref role);
        }
    }
}
