using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class CapNhatNhomHangDAO
    {
        DB db = new DB();
        public DataTable LayThongTinNhomHangTheoMaNH(string manh)
        {
            string sql = string.Format("select * from NhomHang where Ma_NH like '{0}'", manh);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhomHang()
        {
            string sql = "select * from NhomHang";
            return db.GetDataTable(sql);
        }
        public int ThemNhomHangBTN(string madvt, string tendvt, string ghichu, string conquanly)
        {
            string sql = string.Format("insert into NhomHang(Ma_NH, Ten_NH, GhiChu, ConQuanLy) values('{0}', N'{1}', N'{2}', '{3}')",
                                        madvt, tendvt, ghichu, conquanly);
            return db.ExcuteSql(sql);
        }
        public int CapNhatNhomHangBTN(string madvt, string tendvt, string ghichu, string conquanly)
        {
            string sql = string.Format("update NhomHang set Ten_NH = '{0}', GhiChu = N'{1}', ConQuanLy = N'{2}' where Ma_NH like '{3}'",
                                                            tendvt, ghichu, conquanly, madvt);
            return db.ExcuteSql(sql);
        }
    }
}
