using Quản_Lý_Bán_Hàng.DAO;
using Quan_Ly_Ban_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class KhoHangDAO
    {
        DB db = new DB();
        public DataTable LayThongTinKhoHang()
        {
            string sql = "select MaKH as [Mã], TenKH as [Tên],NguoiLienHe as [Liên Hệ], DiaChi as [Địa chỉ], DienThoai as [Điện thoại]," +
                          "KyHieu as[Ký hiệu], DienGiai as[Ghi chú], ConQuanLy as [Còn quản lý] from KhoHang";
            return db.GetDataTable(sql);
        }
        public int XoaThongTinKhoHang(string makh)
        {
            string sql = string.Format("Delete KhoHang where MaKH like '{0}'", makh);
            return db.ExcuteSql(sql);
        }
    }
}
