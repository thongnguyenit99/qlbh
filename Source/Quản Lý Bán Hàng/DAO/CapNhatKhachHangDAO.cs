using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class CapNhatKhachHangDAO
    {
        DB db = new DB();
        public DataTable LayThongTinKhuVuc()
        {
            string sql = "select MaKV, TenKV from khuVuc";
            return db.GetDataTable(sql);
        }
        public DataTable DeNghiMaKhacHang()
        {
            string sql = "select Id, MaKH from KhachHang";
            return db.GetDataTable(sql);
        }
        public DataTable KiemTraMaKhachHangTonTai(string makh)
        {
            string sql = string.Format("select * from KhachHang where MaKH like '{0}'", makh);
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinKhachHangTheoMaKH(string makh)
        {
            string sql = string.Format("select * from KhachHang where MaKH = '{0}'", makh);
            return db.GetDataTable(sql);
        }
        public int ThemKhachHangBTN(string MaKH, string ten, string makhuvuc, string diachi, string masothue, string fax,
                                    string dienthoai, string mobile, string email, string website, string taikhoan, 
                                    string nganhang, string gioihanno, string nohientai, string chietkhau, string nickyahoo
                                    , string nguoilienhe, string nickype, string LoaiKH, string conquanly)
        {
            string sql = string.Format("insert into KhachHang(MaKH, TenKH, MaKV, DiaChi, MaSoThue, Fax, DienThoai, DiDong, Email, Website, SoTaiKhoan, TenNganHang, GioiHanNo, NoHienTai, ChietKhau, NickYahoo, NguoiLienHe, NickSkype, LoaiKH, ConQuanLy) values" +
                                        "('{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', N'{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}')", 
                                        MaKH, ten, makhuvuc, diachi, masothue, fax, dienthoai, mobile, email, website, taikhoan, nganhang, gioihanno, nohientai, chietkhau, nickyahoo, nguoilienhe, nickype, LoaiKH, conquanly);
            return db.ExcuteSql(sql);
        }
        public int CapNhatKhachHangBTN(string MaKH, string ten, string makhuvuc, string diachi, string masothue, string fax,
                            string dienthoai, string mobile, string email, string website, string taikhoan,
                            string nganhang, string gioihanno, string nohientai, string chietkhau, string nickyahoo
                            , string nguoilienhe, string nickype, string LoaiKH, string conquanly)
        {
            string sql = string.Format("update KhachHang set  TenKH = N'{0}', MaKV = '{1}', LoaiKH = '{2}', NguoiLienHe = N'{3}', DiaChi = N'{4}', MaSoThue = '{5}', DienThoai = '{6}', DiDong = '{7}', Fax = '{8}', Email = '{9}', Website = '{10}', SoTaiKhoan = '{11}'," +
                                       " TenNganHang = N'{12}', GioiHanNo = '{13}', NoHienTai = '{14}', ChietKhau = '{15}', NickYahoo = '{16}', NickSkype = '{17}', ConQuanLy = '{18}' where MaKH = '{19}'",
                                        ten, makhuvuc, LoaiKH, nguoilienhe, diachi, masothue, dienthoai, mobile, fax, email, website, taikhoan, nganhang, gioihanno, nohientai, chietkhau, nickyahoo, nickype, conquanly, MaKH);
            return db.ExcuteSql(sql);
        }
    }
}
