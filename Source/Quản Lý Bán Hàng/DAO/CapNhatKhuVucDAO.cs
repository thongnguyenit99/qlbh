using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class CapNhatKhuVucDAO
    {
        DB db = new DB();
        public DataTable KiemTraMaKhuVucDaTonTai(string makv)
        {
            string sql = string.Format("select * from KhuVuc where MaKV like N'{0}'", makv);
            return db.GetDataTable(sql);
        }
        public int ThemKhuVuc(string ma, string ten, string ghichu, string conquanly)
        {
            string sql = string.Format("insert into KhuVuc (MaKV, TenKV, GhiChu, ConQuanLy) values('{0}', '{1}', '{2}', '{3}')", 
                                        ma, ten, ghichu, conquanly);
            return db.ExcuteSql(sql);
        }
        public DataTable LayThongTinMotKhuVucTheoID(int id)
        {
            string sql = string.Format("select * from KhuVuc where Id = {0}", id);
            return db.GetDataTable(sql);
        }
        public int CapNhatKhuVucBTN(string ma, string ten, string ghichu, string conquanly)
        {
            string sql = string.Format("update KhuVuc set TenKV = N'{0}', GhiChu = N'{1}', ConQuanLy = N'{2}' where MaKV like '{3}'", ten, ghichu, conquanly, ma);
            return db.ExcuteSql(sql);
        }
        public DataTable LayThongTinKhuVuc()
        {
            string sql = "Select * from KhuVuc";
            return db.GetDataTable(sql);
        }
    }
}
