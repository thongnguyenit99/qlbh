using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class KhuVucDAO
    {
        DB db = new DB();
        public DataTable LayThongTinKhuVuc()
        {
            string sql = "select * from KhuVuc";
            return db.GetDataTable(sql);
        }
        public int XoaMotKhuVuc(string makv)
        {
            string sql = string.Format("delete KhuVuc where MaKV like '{0}'", makv);
            return db.ExcuteSql(sql);
        }
    }
}
