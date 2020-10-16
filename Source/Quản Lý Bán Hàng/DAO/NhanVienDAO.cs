using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class NhanVienDAO
    {
        DB db = new DB();
        public DataTable LayThongTinNhanVien()
        {
            string sql = "select MaNV as [Mã], TenNV as [Tên], DiaChi as [Địa chỉ], DienThoai as [Điện thoại], DiDong as [Di động], Email, ConQuanLy as [Còn quản lý] from NhanVien";
            return db.GetDataTable(sql);
        }
        public int XoaNhanVien(string manv)
        {
            string sql = string.Format("Delete NhanVien where MaNV like '{0}'", manv);
            return db.ExcuteSql(sql);
        }
    }
}
