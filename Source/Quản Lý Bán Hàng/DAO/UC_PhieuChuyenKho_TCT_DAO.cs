using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class UC_PhieuChuyenKho_TCT_DAO
    {
        DB db = new DB();
        public DataTable LayThongTinPhieuChuyenKho()
        {
            string sql = "";
            return db.GetDataTable(sql);
        }
    }
}
