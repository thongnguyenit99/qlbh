using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Quan_Ly_Ban_Hang.DAO
{
    public class BoPhanDAO
    {
        DB db = new DB();
        public DataTable LayThongTinBoPhan()
        {
            string sql = "select MaBP as[Mã], TenBP as [Tên], GhiChu as [Ghi Chú], ConQuanLy as [Còn quản lý] from bophan";
            return db.GetDataTable(sql);
        }
        public int XoaBoPhan(string mabp)
        {
            string sql = string.Format("Delete BoPhan where MaBP like '{0}'", mabp);
            return db.ExcuteSql(sql);
        }
    }
}
