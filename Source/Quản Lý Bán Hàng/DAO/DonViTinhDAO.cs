using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class DonViTinhDAO
    {
        DB db = new DB();
        public DataTable LayDuLieuBangDonVi()
        {
            string sql = "select MaDVT as [Mã], TenDVT as [Tên], GhiChu as[Ghi chú], ConQuanLy as [Còn Quản Lý] from DonViTinh";
            return db.GetDataTable(sql);
        }
        public int XoaNhaCungCap(string madvt)
        {
            string sql = string.Format("Delete DonViTinh Where MaDVT like '{0}'", madvt);
            return db.ExcuteSql(sql);
        }
    }
}
