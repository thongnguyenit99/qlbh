using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DTO
{
    public class KhoHangDTO
    {
        public string MaKH { get; set; }
	    public string TenKH { get; set; }
	    public string NguoiQuanLy { get; set; }
        public string KyHieu { get; set; }
        public string NguoiLienHe { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string DienGiai { get; set; }
        public bool ConQuanLy { get; set; }
    }
}
