using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class NhatKyHeThongDAO
    {
        DB db = new DB();
        public DataTable LayRaTenForm(int id)
        {
            string sql = string.Format("select FormName as[Ten] from Form where id = {0}", id);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhatKy()
        {
            string sql = "select * from NhatKyHeThong";
            return db.GetDataTable(sql);
        }
        public int ThemNhatKyHeThong(string mand, string maytinh, string thoigian, string chucnang, string hanhdong, string doituong)
        {
            string sql = string.Format("insert into NhatKyHeThong(MaND, TenMT, ThoiGian, ChucNang, HanhDong, DoiTuong) values ('{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}')", mand, maytinh, thoigian, chucnang, hanhdong, doituong);
            return db.ExcuteSql(sql);
        }
        public int XoaThongTinNhatKy(string mank)
        {
            string sql = string.Format("delete NhatKyHeThong where MaND like '{0}'", mank);
            return db.ExcuteSql(sql);
        }
    }
}
