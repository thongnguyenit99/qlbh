using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quản_Lý_Bán_Hàng.DAO;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class UC_DanhSachPhieuChiDAO
    {
        DB db = new DB();
        public DataTable LayDanhSachPhieuChi(string tungay, string denngay)
        {
            string sql = string.Format("select * from DanhSachPhieuChi where NgayLap between '{0}' and '{1}'", tungay, denngay);
            return db.GetDataTable(sql);
        }
        public int XoaPhieuChi(string mapc)
        {
            string sql = string.Format("delete DanhSachPhieuChi where MaPC like '{0}'", mapc);
            return db.ExcuteSql(sql);
        }
        public int CapNhatPhieuNhapHang(string mapnh)
        {
            string sql = string.Format("update PhieuNhapHang set IsDaThanhToan = 0 where MaPNH like '{0}'", mapnh);
            return db.ExcuteSql(sql);
        }
    }
}
