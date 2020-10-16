using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quản_Lý_Bán_Hàng.DAO;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class NhomHangDAO
    {
        DB db = new DB();
        public DataTable LayThongTinNhomHang()
        {
            string sql = "select Ma_NH as [Mã], Ten_NH as [Tên], GhiChu as [Ghi Chú], ConQuanLy as [Còn quản lý] from NhomHang";
            return db.GetDataTable(sql);
        }
        public int XoaNhomHang(string manh)
        {
            string sql = string.Format("Delete NhomHang Where Ma_NH like '{0}'", manh);
            return db.ExcuteSql(sql);
        }

    }
}
