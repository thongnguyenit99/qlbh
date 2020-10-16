using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class NhapTuExcelDAO
    {
        DB db = new DB();
        public int ThemNhaCungCap(NhaCungCapDTO_BD ncc)
        {
            string sql = string.Format("insert into NhaCungCap(MaNCC, TenNCC, MaKV, NguoiLienHe, DiaChi, DienThoai, DiDong, Fax, ChucVu, ConQuanLy) " +
                        "values('{0}', N'{1}', '{2}', N'{3}', N'{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                        ncc.MaNCC, ncc.TenNCC, ncc.MaKV, ncc.NguoiLienHe, ncc.DiaChi, ncc.DienThoai, ncc.DiDong, ncc.Fax, ncc.ChucVu, ncc.ConQuanLy);
            return db.ExcuteSql(sql);
        }
        public int CapNhatNhaCungCap(NhaCungCapDTO_BD ncc)
        {
            string sql = string.Format("update NhaCungCap set TenNCC = N'{0}', MaKV = '{1}', NguoiLienHe = N'{2}', DiaChi =  N'{3}', DienThoai = '{4}'," +
                " DiDong = '{5}', Fax = '{6}', ChucVu = '{7}', ConQuanLy = '{8}' where MaNCC like '{9}'",
                       ncc.TenNCC, ncc.MaKV, ncc.NguoiLienHe, ncc.DiaChi, ncc.DienThoai, ncc.DiDong, ncc.Fax, ncc.ChucVu, ncc.ConQuanLy, ncc.MaNCC);
            return db.ExcuteSql(sql);
        }
        public DataTable KiemTraNhaCungCapDaTonTai(string mancc)
        {
            string sql = string.Format("select * from NhaCungCap where MaNCC like '{0}'", mancc);
            return db.GetDataTable(sql);
        }
    }
}
