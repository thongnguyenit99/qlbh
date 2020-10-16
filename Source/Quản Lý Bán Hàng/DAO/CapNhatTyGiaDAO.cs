using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class CapNhatTyGiaDAO
    {
        DB db = new DB();
        public DataTable LayThongTinBangTyGia()
        {
            string sql = "select * from TyGia";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinBangTyGiaTheoMa(string matg)
        {
            string sql = string.Format("select * from TyGia where MaTG like '{0}'", matg);
            return db.GetDataTable(sql);
        }
        public int ThemTyGiaBTN(string matg, string tentg, float gia, string conquanly)
        {
            string sql = string.Format("insert into TyGia (MaTG, tenTG, TyGiaQD, ConQuanLy) values('{0}', '{1}', {2}, '{3}')", matg, tentg, gia, conquanly);
            return db.ExcuteSql(sql);
        }
        public int CapNhatTyGiaBTN(string matg, string tentg, float gia, string conquanly)
        {
            string sql = string.Format("update TyGia set TenTG = N'{0}', TyGiaQD = {1}, ConQuanLy = '{2}' where MaTG like '{3}'", tentg, gia, conquanly, matg);
            return db.ExcuteSql(sql);
        }
    }
}
