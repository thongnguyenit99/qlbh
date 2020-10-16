using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class NhaCungCapDAO
    {
        DB db = new DB();
        public DataTable LayThongTinKhuVuc()
        {
            string sql = "select * from KhuVuc";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhaCungCap()
        {
            string sql = "select ncc.*, TenKV from NhaCungCap ncc, KhuVuc kv where ncc.MaKV = kv.MaKV";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhaCungCapTheoKV(string makv)
        {
            string sql = string.Format("select MaNCC as [Mã số], TenNCC as [Tên nhà cung cấp], NguoiLienHe as [Người liên hệ]," +
                         "ChucVu as [Chức vụ], DiaChi as [Địa chỉ], DienThoai as [Điện thoại], DiDong as [Di Động], Fax, ConQuanLy as[Còn còn lý] from NhaCungCap where MaKV like '{0}'", makv);
            return db.GetDataTable(sql);
        }
        public int XoaNhaCungCap(string mancc)
        {
            string sql = string.Format("delete NhaCungCap where MaNCC like '{0}'", mancc);
            return db.ExcuteSql(sql);
        }
    }
}
