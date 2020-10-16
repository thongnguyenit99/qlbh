using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class PhieuChiTheoChungTuBUS
    {
        PhieuChiTheoChungTuDAO PhieuChiTheoChungTuDAO = new PhieuChiTheoChungTuDAO();
        public DataTable LayThongTinChungTuTheoMa_PNH(string mapnh)
        {
            return PhieuChiTheoChungTuDAO.LayThongTinChungTuTheoMa_PNH(mapnh);
        }
        public int KiemTraMaPCDaTonTai(string mapc)
        {
            DataTable dt = PhieuChiTheoChungTuDAO.KiemTraMaPCDaTonTai(mapc);
            return dt.Rows.Count;
        }
        public int LuuThongTinPhieuChi(string mapc, string mapnh, string ngaylappc, string mancc, string tenncc, float tongtien, string ghichu)
        {
            if (PhieuChiTheoChungTuDAO.LuuThongTinPhieuChi(mapc, mapnh, ngaylappc, mancc, tenncc, tongtien, ghichu) > 0)
            {
                if (PhieuChiTheoChungTuDAO.CapNhatPhieuNhapHang(mapnh) > 0)
                {
                    return 1;
                }
                else// cập nhật thất bại
                {
                    PhieuChiTheoChungTuDAO.XoaPhieuChiTheoMa(mapc);
                    return 0;
                }

            }
            return 0;
        }
        public string PhatSinhMaPhieuChi(string mapnh, int neutrung)
        {
            DataTable dt = PhieuChiTheoChungTuDAO.LayThongTinDanhSachPhieuChi();
            string temp = mapnh.Substring(2, mapnh.Length - 8);
            string tam = "000001";
            int id = dt.Rows.Count + 1 + neutrung;
            if (dt.Rows.Count == 0)
            {
                temp = "PC" + temp + tam;
            }
            else
            {
                temp = "PC" + temp + tam.Substring(0, tam.Length - id.ToString().Length) + id.ToString();
            }
            return temp;
        }
        public string PhatSinhMaPhieuThu(string mapnh, int neutrung)
        {
            DataTable dt = PhieuChiTheoChungTuDAO.LayThongTinDanhSachPhieuThu();
            string temp = mapnh.Substring(2, mapnh.Length - 8);
            string tam = "000001";
            int id = dt.Rows.Count + 1 + neutrung;
            if (dt.Rows.Count == 0)
            {
                temp = "PT" + temp + tam;
            }
            else
            {
                temp = "PT" + temp + tam.Substring(0, tam.Length - id.ToString().Length) + id.ToString();
            }
            return temp;
        }
        public DataTable LayThongTinNhanVien()
        {
            return PhieuChiTheoChungTuDAO.LayThongTinNhanVien();
        }
        public DataTable LayThongTinPhieuBanHangTheoMa(string mapbh)
        {
            return PhieuChiTheoChungTuDAO.LayThongTinPhieuBanHangTheoMa(mapbh);
        }
        public int KiemTraMaPhieuThuDaTonTai(string mapt)
        {
           DataTable dt = PhieuChiTheoChungTuDAO.KiemTraMaPhieuThuDaTonTai(mapt);
            return dt.Rows.Count;
        }
        public int LuuThongTinPhieuThu(string mapt, string mapbh, string ngaylappt, string makh, string tenkh, float tongtien, string ghichu)
        {
            if (PhieuChiTheoChungTuDAO.LuuThongTinPhieuThu(mapt, mapbh, ngaylappt, makh, tenkh, tongtien, ghichu) > 0)
            {
                if (PhieuChiTheoChungTuDAO.CapNhatPhieuBanHang(mapbh) > 0)
                {
                    return 1;
                }
                else// cập nhật thất bại
                {
                    PhieuChiTheoChungTuDAO.XoaPhieuThuTheoMa(mapt);
                    return 0;
                }

            }
            return 0;
        }
    }
}
