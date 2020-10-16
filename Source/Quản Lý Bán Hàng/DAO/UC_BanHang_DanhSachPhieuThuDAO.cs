using Quản_Lý_Bán_Hàng.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Quan_Ly_Ban_Hang.DAO
{
    public class UC_BanHang_DanhSachPhieuThuDAO
    {
        DB db = new DB();
        public DataTable LayDanhSachPhieuThuTheoNgay(string tungay, string denngay)
        {
            string sql = string.Format("select * from DanhSachPhieuThu where NgayLap between '{0}' and '{1}'", tungay, denngay);
            return db.GetDataTable(sql);
        }
        public int XoaPhieuThuTien(string mapt)
        {
            string sql = string.Format("delete DanhSachPhieuThu where MaPT like '{0}'", mapt);
            return db.ExcuteSql(sql);
        }
        public int CapNhatPhieuBanHang(string mapbh)
        {
            string sql = string.Format("update PhieuBanHang  set IsDaThuTien = 0 where MaPBH like '{0}'", mapbh);
            return db.ExcuteSql(sql);
        }
    }
}
