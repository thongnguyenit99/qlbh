using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class  CapNhatBoPhanDAO
    {
        DB db = new DB();
        public DataTable LayThongTinDonViTinh()
        {
            string sql = "select * from BoPhan";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinBoPhanTheoMa(string mabp)
        {
            string sql = string.Format("select * from BoPhan where MaBP like '{0}'", mabp);
            return db.GetDataTable(sql);
        }
        public int ThemBoPhanBTN(string mabp, string tenbp, string ghichu, string conquanly)
        {
            string sql = string.Format("insert into BoPhan(MaBP, TenBP, GhiChu, ConQuanLy) values('{0}', N'{1}', N'{2}', '{3}')",
                                        mabp, tenbp, ghichu, conquanly);
            return db.ExcuteSql(sql);
        }
        public int CapNhatBoPhanBTN(string mabp, string tenbp, string ghichu, string conquanly)
        {
            string sql = string.Format("update BoPhan set TenBP = '{0}', GhiChu = N'{1}', ConQuanLy = N'{2}' where MaBP like '{3}'",
                                                            tenbp, ghichu, conquanly, mabp);
            return db.ExcuteSql(sql);
        }
    }
}
