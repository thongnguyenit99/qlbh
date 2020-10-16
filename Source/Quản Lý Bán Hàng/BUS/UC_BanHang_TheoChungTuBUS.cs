using Quan_Ly_Ban_Hang.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class UC_BanHang_TheoChungTuBUS
    {
        UC_BanHang_TheoChungTuDAO uC_BanHang_TheoChungTuDAO = new UC_BanHang_TheoChungTuDAO();
        public List<TheoChungTu_PBH_DTO> LayThongTinPhieuBanHangTheoMauCT(string tungay, string denngay)
        {
            DataTable dt = uC_BanHang_TheoChungTuDAO.LayThongTinPhieuBanHangTheoMauCT(tungay, denngay);
            List<TheoChungTu_PBH_DTO> lst_pbhct = new List<TheoChungTu_PBH_DTO>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] temp = dt.Rows[i]["Ngay"].ToString().Split(' ');
                    lst_pbhct.Add(new TheoChungTu_PBH_DTO()
                    {
                        ChungTu = dt.Rows[i]["ChungTu"].ToString(),
                        Ngay = temp[0],
                        KhoHang = dt.Rows[i]["KhoHang"].ToString(),
                        SoPhieuVietTay = dt.Rows[i]["SoPhieuVietTay"].ToString(),
                        SoHoaDonVAT = dt.Rows[i]["SoHoaDonVAT"].ToString(),
                        KhachHang = dt.Rows[i]["KhachHang"].ToString(),
                        CK = dt.Rows[i]["CK"].ToString(),
                        VAT = dt.Rows[i]["VAT"].ToString(),
                        ThanhToan = dt.Rows[i]["ThanhToan"].ToString(),
                        GhiChu = dt.Rows[i]["GhiChu"].ToString(),
                    });
                }
            }
            return lst_pbhct;
        }
        public List<TheoChungTuCT_PBH_DTO> LayThongTinCTPhieuBanHangTheoChungTu()
        {
            DataTable dt = uC_BanHang_TheoChungTuDAO.LayThongTinCT_PhieuBanHangTheoChungTu();
            List<TheoChungTuCT_PBH_DTO> lst_pbhct = new List<TheoChungTuCT_PBH_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst_pbhct.Add(new TheoChungTuCT_PBH_DTO()
                {
                    MaHang = dt.Rows[i]["MaHang"].ToString(),
                    TenHang = dt.Rows[i]["TenHang"].ToString(),
                    KhoHang = dt.Rows[i]["KhoHang"].ToString(),
                    DVT = dt.Rows[i]["DonVi"].ToString(),
                    SoLuong = dt.Rows[i]["SoLuong"].ToString(),
                    DonGia = dt.Rows[i]["DonGia"].ToString(),
                    ThanhTien = dt.Rows[i]["ThanhTien"].ToString(),
                    MaPhieuBanHang = dt.Rows[i]["MaPhieuBanHang"].ToString(),
                    CK = dt.Rows[i]["CK"].ToString() + " %",
                });
            }

            return lst_pbhct;
        }
        public List<TheoChungTu_PBH_DTO> LayThongTinPhieuBanHangTheoMauCT_MaKH(string tungay, string denngay, string MaKH)
        {
            DataTable dt = uC_BanHang_TheoChungTuDAO.LayThongTinPhieuBanHangTheoMauCT_MaKH(tungay, denngay, MaKH);
            List<TheoChungTu_PBH_DTO> lst_pbhct = new List<TheoChungTu_PBH_DTO>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] temp = dt.Rows[i]["Ngay"].ToString().Split(' ');
                    lst_pbhct.Add(new TheoChungTu_PBH_DTO()
                    {
                        ChungTu = dt.Rows[i]["ChungTu"].ToString(),
                        Ngay = temp[0],
                        KhoHang = dt.Rows[i]["KhoHang"].ToString(),
                        SoPhieuVietTay = dt.Rows[i]["SoPhieuVietTay"].ToString(),
                        SoHoaDonVAT = dt.Rows[i]["SoHoaDonVAT"].ToString(),
                        KhachHang = dt.Rows[i]["KhachHang"].ToString(),
                        CK = dt.Rows[i]["CK"].ToString(),
                        VAT = dt.Rows[i]["VAT"].ToString(),
                        ThanhToan = dt.Rows[i]["ThanhToan"].ToString(),
                        GhiChu = dt.Rows[i]["GhiChu"].ToString(),
                    });
                }
            }
            return lst_pbhct;
        }
        public DataTable LayThongTinKhachHang()
        {
            return uC_BanHang_TheoChungTuDAO.LayThongTinKhachHang();
        }
        public int XoaThongTinPhieuBanHang(string mapbh, string tenkho)
        {
            MuaHangBUS muaHangBUS = new MuaHangBUS();
            DataTable dt1 = uC_BanHang_TheoChungTuDAO.ChuyenTenKhoThanhMaKho(tenkho);
            string makho = "";
            if (dt1.Rows.Count > 0 && dt1 != null)
            {
                makho = dt1.Rows[0]["MaKH"].ToString();
            }
            DataTable kt = uC_BanHang_TheoChungTuDAO.KiemTraXemPhieuNhapHangDaCoPhieuThu(mapbh);
            if ( kt.Rows.Count == 0)
            {
                DataTable dt = uC_BanHang_TheoChungTuDAO.LayThongTinCT_PhieuMuaHangTheoMa(mapbh);
                if(uC_BanHang_TheoChungTuDAO.XoaCT_PhieuMuaHang(mapbh) > 0)
                {
                    for(int i = 0; i < dt.Rows.Count;i++)
                    {
                        muaHangBUS.CapNhatSoLuongHangHoa(dt.Rows[i]["MaSanPham"].ToString(), int.Parse(dt.Rows[i]["SoLuong"].ToString()), makho);
                    }
                    uC_BanHang_TheoChungTuDAO.XoaPhieuBanHang(mapbh);
                    return 1;
                }
            }
            else
                return -1;

            return 0;
        }
    }
}
