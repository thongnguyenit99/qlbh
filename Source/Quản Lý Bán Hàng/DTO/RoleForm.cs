using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang.DTO
{
    public class RoleForm
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int FormId { get; set; }
        public bool TruyCap { get; set; }
        public bool Them { get; set; }
        public bool Sua { get; set; }
        public bool Xoa { get; set; }
        public bool In_DL { get; set; }
        public bool Nhap { get; set; }
        public bool Xuat { get; set; }
    }
}
