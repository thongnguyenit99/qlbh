using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DTO
{
    public class CT_PhieuNhapHangDTO
    {
        public string MaPhieuNhapHang { get; set; }
        public int ViTri { get; set; }
	    public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public string DonVi { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public string GhiChu { get; set; }
    }
}
