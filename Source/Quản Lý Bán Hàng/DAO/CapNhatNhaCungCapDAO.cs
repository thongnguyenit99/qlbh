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
    public class CapNhatNhaCungCapDAO
    {
        DB db = new DB();
        public DataTable LayThongTinKhuVuc()
        {
            string sql = "Select MakV as[Mã Khu Vực], TenKV as [Tên Khu Vực] from KhuVuc";
            return db.GetDataTable(sql);
        }
        public DataTable LayThongTinNhaCungCapTheoMaNCC(string mancc)
        {
            string sql = string.Format("select * from NhaCungCap where MaNCC like '{0}'", mancc);
            return db.GetDataTable(sql);
        }

        public DataTable LayThongTinNhaCungCap()
        {
            string sql = "Select * from NhaCungCap";
            return db.GetDataTable(sql);
        }
        public DataTable KiemTraMaNhaCungCap(string mancc)
        {
            string sql = string.Format("select * from NhaCungCap where MaNCC like '{0}'", mancc);
            return db.GetDataTable(sql);
        }
        public DataTable LayMaKVTheoMaNCC(string mancc)
        {
            string sql = string.Format("Select MaKV from NhaCungCap where MaNCC like '{0}'", mancc);
            return db.GetDataTable(sql);
        }
        public int ThemNhaCungCap(NhaCungCapDTO temp)
        {
            string sql = string.Format("insert into NhaCungCap (MaNCC, TenNCC, MaKV, NguoiLienHe, DiaChi, MaSoThue, DienThoai, DiDong, Fax, Email, Website, SoTaiKhoan, TenNganHang, GioiHanNo, ChietKhau, ChucVu, ConQuanLy)" +
                                        "values('{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', N'{12}', N'{13}', '{14}', '{15}', '{16}')",
                                        temp.MaNCC, temp.TenNCC, temp.MaKV, temp.NguoiLienHe, temp.DiaChi, temp.MaSoThue, temp.DienThoai, temp.DiDong, temp.Fax, temp.mail, temp.Website, temp.SoTaiKhoan, temp.TenNganHang, temp.GioiHanNo, temp.ChietKhau, temp.ChietKhau, temp.ConQuanLy);
            return db.ExcuteSql(sql);
        }
        public int CapNhatNhaCungCapBTN(NhaCungCapDTO temp)
        {
            string sql = string.Format("update NhaCungCap set TenNCC = N'{0}', MaKV = '{1}', NguoiLienHe = N'{2}', DiaChi = N'{3}', MaSoThue = '{4}', DienThoai = '{5}'," +
                      "DiDong = '{6}', Fax = '{7}', Email = '{8}', Website = '{9}', SoTaiKhoan = '{10}', TenNganHang = N'{11}', GioiHanNo = '{12}', ChietKhau = '{13}', ChucVu = '{14}', ConQuanLy = '{15}' where MaNCC = '{16}'",
                                       temp.TenNCC, temp.MaKV, temp.NguoiLienHe, temp.DiaChi, temp.MaSoThue, temp.DienThoai, temp.DiDong, temp.Fax, temp.mail, temp.Website, temp.SoTaiKhoan, temp.TenNganHang, temp.GioiHanNo, temp.ChietKhau, temp.ChietKhau, temp.ConQuanLy, temp.MaNCC);
            return db.ExcuteSql(sql);
        }
    }
}
