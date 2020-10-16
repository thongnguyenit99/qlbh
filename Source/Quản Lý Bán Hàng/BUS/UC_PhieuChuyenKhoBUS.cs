using Quan_Ly_Ban_Hang.DAO;
using Quan_Ly_Ban_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class UC_PhieuChuyenKhoBUS
    {
        UC_PhieuChuyenKhoDAO UC_PhieuChuyenKhoDAO = new UC_PhieuChuyenKhoDAO();
        public DataTable LayThongTinKhoHang()
        {
            return UC_PhieuChuyenKhoDAO.LayThongTinKhoHang();
        }
        public DataTable LayThongTinNhanVien()
        {
            return UC_PhieuChuyenKhoDAO.LayThongTinNhanVien();
        }
        public string PhatSinhMaPhieuChuyenKho()
        {
            DataTable dt = UC_PhieuChuyenKhoDAO.LayThongTinPhieuChuyenKho();

            try
            {
                string tam = "000000";
                int id = int.Parse(dt.Rows[0]["Id"].ToString()) + 1;
                string maphieu = "CK" + GlobalVar.tendn + tam.Substring(0, tam.Length - id.ToString().Length) + id.ToString();
                return maphieu;

            }
            catch
            {
                return "CK" + GlobalVar.tendn + "000001";
            }
        }
        public DataTable LayCT_phhieuChuyenKho_Ao()
        {
            return UC_PhieuChuyenKhoDAO.LayCT_phhieuChuyenKho_Ao();
        }
        public DataTable LayDanhSachHangHoa()
        {
            return UC_PhieuChuyenKhoDAO.LayDanhSachHangHoa();
        }
        public DataTable LayThongTinHangHoaTheoMaHH(string mahh)
        {
            return UC_PhieuChuyenKhoDAO.LayThongTinHangHoaTheoMaHH(mahh);
        }
        public int XoaChiTietPhieuChuyenKhoAo()
        {
            return UC_PhieuChuyenKhoDAO.XoaChiTietPhieuChuyenKhoAo();
        }
        public int XoaDulieuPhieuChuyenKhoVaCapNhatLaiSoLuong(string MaPCK, string khoxuat, string khonhan)
        {
            PhieuBanHangBUS phieuBanHangBUS = new PhieuBanHangBUS();
            DataTable dt = UC_PhieuChuyenKhoDAO.LayThongTinChiTietPhieuChuyenKhoTheoMa(MaPCK);
            int temp = UC_PhieuChuyenKhoDAO.XoaChiTietPhieuChuyenKhoTheoMa(MaPCK);
            if(temp > 0)
            {
                if(dt.Rows.Count > 0 && dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count;i++)
                    {
                        // cập nhật số lượng ở kho xuất
                        phieuBanHangBUS.CapNhatSoLuongHangHoa(dt.Rows[0]["MaSanPham"].ToString(), int.Parse(dt.Rows[0]["SoLuong"].ToString()), khoxuat);
                        // cập nhật số lượng ở kho nhận
                        phieuBanHangBUS.CapNhatSoLuongHangHoa(dt.Rows[0]["MaSanPham"].ToString(), -int.Parse(dt.Rows[0]["SoLuong"].ToString()), khonhan);
                    }
                }
                UC_PhieuChuyenKhoDAO.XoaPhieuhuyenKhotheoMa(MaPCK);
            }

            return temp;
        }
        public int ThemPhieuChuyenKho(PhieuChuyenKhoDTO pck)
        {
            return UC_PhieuChuyenKhoDAO.ThemPhieuChuyenKho(pck);
        }
        public int ThemCT_PhieuChuyenKho(CT_PhieuChuyenKhoDTO ct_pck)
        {
            return UC_PhieuChuyenKhoDAO.ThemCT_PhieuChuyenKho(ct_pck);
        }
    }
}
