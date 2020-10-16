using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class Uc_DanhMuc : DevExpress.XtraEditors.XtraUserControl
    {
        public Uc_DanhMuc()
        {
            InitializeComponent();
        }
        public void EnnableFunction(RoleForm roleForm)
        {
            ucbtnthem.Enabled = roleForm.Them;
            ucbtnsua.Enabled = roleForm.Sua;
            ucbtnxoa.Enabled = roleForm.Xoa;
            ucbtnin.Enabled = roleForm.In_DL;
            ucbtnnhap.Enabled = roleForm.Nhap;
            ucbtnxuat.Enabled = roleForm.Xuat;
        }
    }
}
