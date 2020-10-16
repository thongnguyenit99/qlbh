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

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class ThongTin : DevExpress.XtraEditors.XtraForm
    {
        public ThongTin()
        {
            InitializeComponent();
            pictureEdit1.Image = Image.FromFile(@"Resources\duy.jpg");
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit2.Image = Image.FromFile(@"Resources\thong.jpg");
            pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }
    }
}