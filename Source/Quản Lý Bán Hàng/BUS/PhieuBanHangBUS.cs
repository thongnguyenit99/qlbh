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
    public class PhieuBanHangBUS
    {
        PhieuBanHangDAO phieuBanHangDAO = new PhieuBanHangDAO();
        DataTable dt;
        public DataTable LayThongTinKhachHang_Ma()
        {
            return phieuBanHangDAO.LayThongTinKhachHang_Ma();
        }
        public DataTable LayThongTinKhachHang_Ten()
        {
            return phieuBanHangDAO.LayThongTinKhachHang_Ten();
        }
        public string PhatSinhMaPhieuBH(string tentk)
        {
            dt = phieuBanHangDAO.LayThongTinPhieuNhapHang();
            string id;
            if (dt.Rows.Count == 0)
            {
                id = "1";
            }
            else
            {
                id = (int.Parse(dt.Rows[dt.Rows.Count - 1]["Id"].ToString()) + 1).ToString();
            }
            string temp = "BH" + tentk;
            string dayso = "000000";
            string MaPMH = temp + dayso.Substring(0, dayso.Length - id.Length) + id;
            return MaPMH;
        }
        public DataTable LayToanBoThongTinKhachHangTheoMaKH(string MaKH)
        {
            return phieuBanHangDAO.LayToanBoThongTinKhachHangTheoMaKH(MaKH);
        }
        public DataTable LayThongTinCT_PhieuMuaHangAo()
        {
            phieuBanHangDAO.XoaCT_PhieuMuaHangAO();
            return phieuBanHangDAO.LayThongTinCT_PhieuMuaHangAo();
        }
        public DataTable LayThongTinGiaBan()
        {
            return phieuBanHangDAO.LayThongTinGiaBan();
        }
        public bool KiemTraXemMaPBHDaTonTai(string mapbh)
        {
            if (phieuBanHangDAO.LayThongTinPhieuBanHangTheoMaPBH(mapbh).Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public int ThemPhieuBanHang(PhieuBanHangDTO pbh)
        {
            return phieuBanHangDAO.ThemPhieuBanHang(pbh);
        }
        public int ThemCT_PhieuBanHang(CT_PhieuBanHangDTO ctpbh)
        {
            return phieuBanHangDAO.ThemCT_PhieuBanHang(ctpbh);
        }
        public int TaoHangHoaMoiChoKho(string mahh, int soluong, string makho, string tensp)
        {
            DataTable dt = phieuBanHangDAO.LaySoLuongHangHoaTonKhoTheoMaHangHoa(mahh, makho);
            if (dt.Rows.Count == 0)
            {
                // chưa tồn tại thì thêm hàng hóa mới
                MuaHangBUS muaHangBUS = new MuaHangBUS();
                muaHangBUS.ThemHangHoa(mahh, tensp, makho, 0);
            }
            else
                return 0;
            return 1;
        }
        public int KiemTraHangHoaBanCoVuotTonKhoToiThieu(string mahh, int soluong, string makho, string tensp)
        {
            DataTable dt = phieuBanHangDAO.LaySoLuongHangHoaTonKhoTheoMaHangHoa(mahh, makho);
            if (dt.Rows.Count > 0)
            {
                if (int.Parse(dt.Rows[0]["TonKhoHienTai"].ToString()) - soluong >= int.Parse(dt.Rows[0]["TonKhoToiThieu"].ToString()))
                {
                    return 1;
                }
            }
            else
            {
                // chưa tồn tại thì thêm hàng hóa mới
                MuaHangBUS muaHangBUS = new MuaHangBUS();
                muaHangBUS.ThemHangHoa(mahh, tensp, makho, 0);
                return 1;
            }
            return 0;
        }
        public int XoaCT_PhieuBanHangTheoMa(string mapbh, string makho)
        {
            DataTable dt = phieuBanHangDAO.LayChiTietPhieuBanHangTheoMa(mapbh);
            phieuBanHangDAO.XoaCT_PhieuBanHang(mapbh);
            if(dt.Rows.Count > 0 && dt != null)
            {
                for(int i = 0; i < dt.Rows.Count;i++)
                {
                    MuaHangBUS muaHangBUS = new MuaHangBUS();
                    muaHangBUS.CapNhatSoLuongHangHoa(dt.Rows[i]["MaSanPham"].ToString(), int.Parse(dt.Rows[i]["SoLuong"].ToString()), makho);
                }
            }
            return 1;
        }
        public int CapNhatSoLuongHangHoa(string mahh, int soluong, string makho)
        {
            DataTable dt = phieuBanHangDAO.LaySoLuongHangHoaTonKhoTheoMaHangHoa(mahh, makho);
            if (dt.Rows.Count > 0 && dt != null)
            {
                if (phieuBanHangDAO.CapNhatTonKhoHienTaiCuaHangHoa(mahh, int.Parse(dt.Rows[0]["TonKhoHienTai"].ToString()) - soluong, makho) < 1)
                    return 0;
            }
            return 1;
        }
        public int XoaPhieuBanHang(string mapbh)
        {
            return phieuBanHangDAO.XoaPhieuBanHang(mapbh);
        }
        public int XoaCT_PhieuBanHang(string mapbh)
        {
            return phieuBanHangDAO.XoaCT_PhieuBanHang(mapbh);
        }
        public DataTable LayThongTinPhieuBanHangTheoMa(string mapbh)
        {
            return phieuBanHangDAO.LayThongTinPhieuBanHangTheoMa(mapbh);
        }

        public int GanGiaTriChoChiTietPhieuMuaHangAo(string mapbh)
        {
            DataTable dt = phieuBanHangDAO.LayChiTietPhieuBanHangTheoMa(mapbh);
            if (dt.Rows.Count > 0 && dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (phieuBanHangDAO.ThemDuLieuBangPhieuMuaHangAo(
                        dt.Rows[i]["MaSanPham"].ToString(), dt.Rows[i]["TenSanPham"].ToString(), dt.Rows[i]["DonVi"].ToString(),
                        int.Parse(dt.Rows[i]["LoaiGia"].ToString()), int.Parse(dt.Rows[i]["SoLuong"].ToString()), float.Parse(dt.Rows[i]["DonGia"].ToString()),
                        float.Parse(dt.Rows[i]["ThanhTien"].ToString()), float.Parse(dt.Rows[i]["CK"].ToString()), float.Parse(dt.Rows[i]["ChietKhau"].ToString()),
                        float.Parse(dt.Rows[i]["ThanhToan"].ToString())
                        ) < 1)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
        public DataTable LayThongTinChiTietAOKhongXoa()
        {
            return phieuBanHangDAO.LayThongTinCT_PhieuMuaHangAo();
        }
        public int CapNhatPhieuBanHang(PhieuBanHangDTO pbh)
        {
            return phieuBanHangDAO.CapNhatPhieuBanHang(pbh);
        }
        public int CapNhatCT_PhieuBanHang(CT_PhieuBanHangDTO ctpbh)
        {
            return phieuBanHangDAO.CapNhatCT_PhieuBanHang(ctpbh);
        }
        public DataTable LaySoLuongCuaSanPhamTrongCT_PhieuBanHang_Theo_MaPBH_MaSP(string mapbh, string masanpham, int vt)
        {
            return phieuBanHangDAO.LaySoLuongCuaSanPhamTrongCT_PhieuBanHang_Theo_MaPBH_MaSP(mapbh, masanpham, vt);
        }
    }
}
