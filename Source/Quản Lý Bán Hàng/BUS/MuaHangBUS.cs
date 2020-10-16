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
    public class MuaHangBUS
    {
        MuaHangDAO muaHangDAO = new MuaHangDAO();
        public DataTable LayThongTinNhaCungCapTheoTen()
        {
            return muaHangDAO.LayThongTinNhaCungCapTheoTen();
        }
        public DataTable LayThongTinNhaCungCapTheoMa()
        {
            return muaHangDAO.LayThongTinNhaCungCapTheoMa();
        }
        public int LayViTriNCCTheoMa(string ma)
        {
            DataTable dt = muaHangDAO.LayThongTinNhaCungCapTheoMa();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Mã"].ToString() == ma)
                {
                    return i;
                }
            }
            return 0;
        }
        public int XoaCT_PhieuNhapHangThemMaPNH_MaSP_ViTri(string mapnh, string tensp, int vitri)
        {
            int temp = muaHangDAO.XoaCT_PhieuNhapHangThemMaPNH_MaSP_ViTri(mapnh, tensp, vitri);
            DataTable dt = muaHangDAO.LayChiTietPhieuNhapHangTheoMaPNH(mapnh);
            if(dt.Rows.Count > 0 && dt != null)
            {
                for(int i = vitri; i <= dt.Rows.Count; i++)
                {
                    muaHangDAO.CapNhatViTriCT_PhieuNhapHang(mapnh, vitri);
                }
            }
            return temp;
        }
        public int TheoChiTietHoaDonAo_MH(string mh, string tenhang, string donvi, int soluong, float dongia, float thanhtien, string ghichu)
        {
            return muaHangDAO.TheoChiTietHoaDonAo_MH(mh, tenhang, donvi, soluong, dongia, thanhtien, ghichu);
        }
        public int KiemTrahangHoaNayDaTonTaioKhoNay(string masp, string makho)
        {
            DataTable dt = muaHangDAO.KiemTrahangHoaNayDaTonTaioKhoNay(masp, makho);
            return dt.Rows.Count;
        }
        public int LayViTriNCCTheoTen(string Ten)
        {
            DataTable dt = muaHangDAO.LayThongTinNhaCungCapTheoTen();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Nhà Phân Phối"].ToString() == Ten)
                {
                    return i;
                }
            }
            return 0;
        }
        public string PhatSinhMaPhieu(string tentk)
        {
            DataTable dt = muaHangDAO.LayThongTinPhieuNhapHangHang();
            string id;
            if (dt.Rows.Count == 0)
            {
                id = "1";
            }
            else
            {
                id = (int.Parse(dt.Rows[dt.Rows.Count - 1]["Id"].ToString()) + 1).ToString();
            }
            string temp = "MH" + tentk;
            string dayso = "000000";
            string MaPNH = temp + dayso.Substring(0, dayso.Length - id.Length) + id;
            return MaPNH;
        }
        public DataTable LayThongTinNV()
        {
            return muaHangDAO.LayThongTinNV();
        }
        public DataTable LayThongTinKho()
        {
            return muaHangDAO.LayThongTinKho();
        }
        public DataTable LayThongTinDK_ThanhToan()
        {
            return muaHangDAO.LayThongTinDK_ThanhToan();
        }
        public DataTable LayThongTinHT_ThanhToan()
        {
            return muaHangDAO.LayThongTinHT_ThanhToan();
        }
        public DataTable LayThongTinHangHoa()
        {
            return muaHangDAO.LayThongTinHangHoa();
        }
        public DataTable LayThongTinHoaDonAo()
        {
            return muaHangDAO.LayThongTinHoaDonAo();
        }
        public DataTable LayThongTinHangHoaTheoMaHH(string MaHH)
        {
            return muaHangDAO.LayThongTinHangHoaTheoMaHH(MaHH);
        }
        public bool LayPhieuNhapHangTheoMaPhieuNhapHang(string mapnh)
        {
            DataTable dt = muaHangDAO.LayPhieuNhapHangTheoMaPhieuNhapHang(mapnh);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public int ThemHangHoa(string mahh, string tensp,string makho, int soluong)
        {
            HangHoaDTO hangHoaDTO = new HangHoaDTO();
            DataTable dt = muaHangDAO.LayThongTinHangHoaTheoMau(mahh);
            if (dt != null && dt.Rows.Count > 0)
            {
                hangHoaDTO.MaHH = mahh;
                hangHoaDTO.TenHH = tensp;
                hangHoaDTO.MaDV = dt.Rows[0]["MaDV"].ToString();
                hangHoaDTO.MaNH = dt.Rows[0]["MaNH"].ToString();
                hangHoaDTO.MaLHH = dt.Rows[0]["MaLHH"].ToString();
                hangHoaDTO.MaKho = makho;
                hangHoaDTO.Anh = dt.Rows[0]["Anh"].ToString();
                hangHoaDTO.TonKhoToiThieu = -1000000;
                hangHoaDTO.TonKhoHienTai = soluong;
                hangHoaDTO.GiaMua = int.Parse(dt.Rows[0]["GiaMua"].ToString());
                hangHoaDTO.GiaBanSi = int.Parse(dt.Rows[0]["GiaBanSi"].ToString());
                hangHoaDTO.GiaBanLe = int.Parse(dt.Rows[0]["GiaBanLe"].ToString());
            }
            // gọi hàm thêm hàng hóa
            return muaHangDAO.ThemHangHoa(hangHoaDTO);

        }
        public int ThemPhieuNhapNhang(PhieuNhapHangDTO pnh)
        {
            return muaHangDAO.ThemPhieuNhapNhang(pnh);
        }

        public int ThemCT_PhieuNhapHang(CT_PhieuNhapHangDTO ctpnh)
        {
            return muaHangDAO.ThemCT_PhieuNhapHang(ctpnh);
        }
        public int CapNhatSoLuongHangHoa(string mhh, int soluong, string makho)
        {
            DataTable dt = muaHangDAO.LayThongTinHangHoaTheoMaHHVaMaKho(mhh, makho);
            if (dt.Rows.Count > 0)
            {
                if (muaHangDAO.CapNhatSoLuongTonKhoHienTaiCuaHangHoa(mhh, int.Parse(dt.Rows[0]["TonKhoHienTai"].ToString()) + soluong, makho) > 0)
                    return 1;

            }
            return 0;
        }
        public DataTable LayToanBoNhaCungCapTheoMaNCC(string mancc)
        {
            return muaHangDAO.LayThongTinNhaCungCapTheoMaNCC(mancc);
        }
        public int XoaPhieuNhapHang(string mpnh)
        {
            return muaHangDAO.XoaPhieuNhapHang(mpnh);
        }
        public int XoaCT_PhieuNhapHang(string mapnh, string khokhang)
        {
            DataTable dt = muaHangDAO.LayChiTietPhieuNhapHangTheoMaPNH(mapnh);

            int temp = muaHangDAO.XoaCT_PhieuNhapHang(mapnh);
            if(temp > 0)
            {
                if (dt.Rows.Count > 0 && dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        CapNhatSoLuongHangHoa(dt.Rows[i]["MaSanPham"].ToString(), -int.Parse(dt.Rows[i]["SoLuong"].ToString()), khokhang);
                    }
                }
            }
            return temp;
        }
        public DataTable LayThongTinPhieuNhapHangTheo_MaPNH(string mapnh1)
        {
            return muaHangDAO.LayThongTinPhieuNhapHangTheo_MaPNH(mapnh1);
        }
        public int XoaChiTietPhieuNhapHangAO()
        {
            return muaHangDAO.XoaChiTietPhieuNhapHangAO();
        }
        public int LayChiTietPhieuNhapHangTheoMaPNH(string MaPNH)
        {
            DataTable dt = muaHangDAO.LayChiTietPhieuNhapHangTheoMaPNH(MaPNH);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (muaHangDAO.TheoChiTietHoaDonAo_MH(dt.Rows[i]["MaSanPham"].ToString(), dt.Rows[i]["TenSanPham"].ToString(), dt.Rows[i]["DonVi"].ToString(),
                    int.Parse(dt.Rows[i]["SoLuong"].ToString()), float.Parse(dt.Rows[i]["DonGia"].ToString()), float.Parse(dt.Rows[i]["ThanhTien"].ToString()), dt.Rows[i]["GhiChu"].ToString()) < 1)
                {
                    return 0;
                }
            }

            return 1;
        }
        public int CapNhatPhieuNhapHang(PhieuNhapHangDTO pnh)
        {
            return muaHangDAO.CapNhatPhieuNhapHang(pnh);
        }

        public int KiemTraChiTietPhieuNhapHangDaTonTaiTheo_MaPNH_MaSP(string mapnh, string masp, ref int soluong, int vitri)
        {
            DataTable dt = muaHangDAO.KiemTraChiTietPhieuNhapHangDaTonTaiTheo_MaPNH_MaSP(mapnh, masp, vitri);
            if (dt != null && dt.Rows.Count > 0)
            {
                soluong = int.Parse(dt.Rows[0]["SoLuong"].ToString());
                return 1;
            }
            return 0;
        }
        public int CapNhatCT_PNH(CT_PhieuNhapHangDTO ctpnh)
        {
            return muaHangDAO.CapNhatCT_PNH(ctpnh);
        }
    }
}

