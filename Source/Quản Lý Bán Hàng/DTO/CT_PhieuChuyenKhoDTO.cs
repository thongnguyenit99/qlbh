using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DTO
{
    public class CT_PhieuChuyenKhoDTO
    {
        public string MaPhieuChuyenKho { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonVi { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
    }
}
