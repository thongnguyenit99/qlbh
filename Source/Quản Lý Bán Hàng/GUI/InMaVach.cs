using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Quan_Ly_Ban_Hang.DTO;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class InMaVach : DevExpress.XtraEditors.XtraForm
    {
        public InMaVach()
        {
            InitializeComponent();
        }

        private void InMaVach_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            btnxuat.Enabled = GlobalVar.distRoleForm[tag].Xuat;
            btnin.Enabled = GlobalVar.distRoleForm[tag].Xuat;
        }
    }
}