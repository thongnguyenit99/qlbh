using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class CapNhatDonViTinhDAO
    {
        DB db = new DB();
        public DataTable LayThongTinDonViTinh()
        {
            string sql = "select * from DonViTinh";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinDonViTinhTheoMa(string mdvt)
        {
            string sql = string.Format("select * from DonViTinh where MaDVT like '{0}'", mdvt);
            return db.GetDataTable(sql);
        }
        public int ThemDonViTinhBTN(string madvt, string tendvt, string ghichu, string conquanly)
        {
            string sql = string.Format("insert into DonViTinh(MaDVT, TenDVT, GhiChu, ConQuanLy) values('{0}', N'{1}', N'{2}', '{3}')",
                                        madvt, tendvt, ghichu, conquanly);
            return db.ExcuteSql(sql);
        }
        public int CapNhatDonViTinhBTN(string madvt, string tendvt, string ghichu, string conquanly)
        {
            string sql = string.Format("update DonViTinh set TenDVT = '{0}', GhiChu = N'{1}', ConQuanLy = N'{2}' where MaDVT like '{3}'",
                                                            tendvt, ghichu, conquanly, madvt);
            return db.ExcuteSql(sql);
        }
    }

}
