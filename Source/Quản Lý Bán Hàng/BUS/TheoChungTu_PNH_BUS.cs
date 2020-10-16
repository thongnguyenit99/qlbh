using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Ban_Hang.DAO;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.BUS
{
    public class TheoChungTu_PNH_BUS
    {
        TheoChungTu_PNH_DAO TheoChungTu_PNH_DAO = new TheoChungTu_PNH_DAO();
        DataTable dt;
        public DataTable LayThongTinNhaCungCap()
        {
            return TheoChungTu_PNH_DAO.LayThongTinNhaCungCap();
        }
        public List<TheoChungTu_PNH_DTO> LayThongTinPhieuNhapHangTheoChungTu(string ngaybd, string ngaykt)
        {
            dt = TheoChungTu_PNH_DAO.LayThongTinPhieuNhapHangTheoChungTu(ngaybd, ngaykt);
            List<TheoChungTu_PNH_DTO> lst_pnhct = new List<TheoChungTu_PNH_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] temp = dt.Rows[i]["Ngày"].ToString().Split(' ');
                lst_pnhct.Add(new TheoChungTu_PNH_DTO()
                {
                    ChungTu = dt.Rows[i]["Chứng Từ"].ToString(),
                    Ngay = temp[0],
                    KhoHang = dt.Rows[i]["Kho hàng"].ToString(),
                    SoPhieuVietTay = dt.Rows[i]["Số Phiếu Viết Tay"].ToString(),
                    SoHoaDonVAT = dt.Rows[i]["Số Hóa Đơn VAT"].ToString(),
                    NhaCungCap = dt.Rows[i]["Nhà Cung Cấp"].ToString(),
                    CK = dt.Rows[i]["CK"].ToString(),
                    Vat = dt.Rows[i]["Vat"].ToString(),
                    ThanhToan = dt.Rows[i]["Thanh Toán"].ToString(),
                    GhiChu = dt.Rows[i]["Ghi Chú"].ToString(),
                });
            }

            return lst_pnhct;
        }
        public List<TheoChungTu_PNH_DTO> LayThongTinPhieuNhapHangTheoChungTu_MNCC(string ngaybd, string ngaykt, string mancc)
        {
            dt = TheoChungTu_PNH_DAO.LayThongTinPhieuNhapHangTheoChungTu_MNCC(ngaybd, ngaykt, mancc);
            List<TheoChungTu_PNH_DTO> lst_pnhct = new List<TheoChungTu_PNH_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] temp = dt.Rows[i]["Ngày"].ToString().Split(' ');
                lst_pnhct.Add(new TheoChungTu_PNH_DTO()
                {
                    ChungTu = dt.Rows[i]["Chứng Từ"].ToString(),
                    Ngay = temp[0],
                    KhoHang = dt.Rows[i]["Kho hàng"].ToString(),
                    SoPhieuVietTay = dt.Rows[i]["Số Phiếu Viết Tay"].ToString(),
                    SoHoaDonVAT = dt.Rows[i]["Số Hóa Đơn VAT"].ToString(),
                    NhaCungCap = dt.Rows[i]["Nhà Cung Cấp"].ToString(),
                    CK = dt.Rows[i]["CK"].ToString(),
                    Vat = dt.Rows[i]["Vat"].ToString(),
                    ThanhToan = dt.Rows[i]["Thanh Toán"].ToString(),
                    GhiChu = dt.Rows[i]["Ghi Chú"].ToString(),
                });
            }

            return lst_pnhct;
        }

        public List<TheoChungTuCT_PNH_DTO> LayThongTinCTPhieuPhapHangTheoChungTu()
        {
            dt = TheoChungTu_PNH_DAO.LayThongTinCTPhieuPhapHangTheoChungTu();
            List<TheoChungTuCT_PNH_DTO> lst_pnhct = new List<TheoChungTuCT_PNH_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst_pnhct.Add(new TheoChungTuCT_PNH_DTO()
                {
                    MaHang = dt.Rows[i]["MaHang"].ToString(),
                    TenHang = dt.Rows[i]["TenHang"].ToString(),
                    KhoHang = dt.Rows[i]["KhoHang"].ToString(),
                    DVT = dt.Rows[i]["DonVi"].ToString(),
                    SoLuong = dt.Rows[i]["SoLuong"].ToString(),
                    DonGia = dt.Rows[i]["DonGia"].ToString(),
                    ThanhTien = dt.Rows[i]["ThanhTien"].ToString(),
                    MaPhieuNhapHang = dt.Rows[i]["MaPhieuNhapHang"].ToString(),
                }) ;
            }

            return lst_pnhct;
        }
        public int XoaPhieuNhapHang(string mapnh, string khohang)
        {
            DataTable dt = TheoChungTu_PNH_DAO.LayPhieuChiTheoMaChungTu(mapnh);
            if (dt.Rows.Count == 0)
            {
                DataTable dt1 = TheoChungTu_PNH_DAO.LayThongTinKhoHang();
                string temp = "";
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (dt1.Rows[i]["TenKH"].ToString() == khohang)
                    {
                        temp = dt1.Rows[i]["MaKH"].ToString();
                    }
                }
                MuaHangBUS muaHangBUS = new MuaHangBUS();
                if (muaHangBUS.XoaCT_PhieuNhapHang(mapnh, temp) > 0)
                {
                    TheoChungTu_PNH_DAO.XoaPhieuNhapHang(mapnh);
                    return 1;
                }
            }
            else
            {
                return -1;
            }
            return 0;
        }
    }
}
