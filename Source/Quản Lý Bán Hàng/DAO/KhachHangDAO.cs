using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class KhachHangDAO
    {
        DB db = new DB();
        public DataTable LayThongTinKhuVuc()
        {
            string sql = "select * from KhuVuc";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinKhachHang()
        {
            string sql = "select MaKH, TenKV, TenKH, NguoiLienHe, DiaChi, DienThoai, DiDong, Fax, Email, Website, MaSoThue, SoTaiKhoan, TenNganHang, kh.ConQuanLy" +
                         " from KhachHang kh, KhuVuc kv where kh.MaKV = kv.MaKV";
            return db.GetDataTable(sql);
        }
        public DataTable LayKhachHangTheoTenKhuVuc(string tenkv)
        {
            string sql = string.Format("select  kh.* from KhuVuc kv, KhachHang kh where kh.MaKV = kv.MaKV and kv.TenKV like N'{0}'", tenkv);
            return db.GetDataTable(sql);
        }
        public int XoaKhachHang(string Makh)
        {
            string sql = string.Format("delete KhachHang where MaKH like '{0}'", Makh);
            return db.ExcuteSql(sql);
        }
    }
}
