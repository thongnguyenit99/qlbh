using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quản_Lý_Bán_Hàng.DAO;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class TyGiaDAO
    {
        DB db = new DB();
        public DataTable LayThongTinBangTyGia()
        {
            string sql = "select MaTG as [Mã], TenTG as [Tên], TyGiaQD as [Tỷ giá quy đổi], ConQuanLy as [Còn Quản Lý] from TyGia";
            return db.GetDataTable(sql);
        }
        public int XoaTyGia(string MaTG)
        {
            string sql = string.Format("Delete TyGia where MaTG like '{0}'", MaTG);
            return db.ExcuteSql(sql);
        }
    }
}
