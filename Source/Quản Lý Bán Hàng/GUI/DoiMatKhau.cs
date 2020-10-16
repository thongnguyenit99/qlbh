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
using Quan_Ly_Ban_Hang.BUS;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        string tkdn;
        DoiMatKhauBUS doiMatKhauBUS = new DoiMatKhauBUS();
        NhatKyHeThongBUS nhatKyHeThongBUS = new NhatKyHeThongBUS();
        public DoiMatKhau(string tk)
        {
            InitializeComponent();
            tkdn = tk;
            pictureEdit1.Image = Image.FromFile(@"Resources\key_1.png");
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            try
            {
                nhatKyHeThongBUS.ThemNhatKyHeThong("Hệ Thống", "Thay đổi mật khẩu", "Xem");
            }
            catch
            {

            }
        }

        private void btnexxit_Click(object sender, EventArgs e)
        {
            try
            {
                nhatKyHeThongBUS.ThemNhatKyHeThong("Thay đổi mật khẩu", "Thoát", "");
            }
            catch
            {

            }
            this.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            try
            {
                nhatKyHeThongBUS.ThemNhatKyHeThong("Thay đổi mật khẩu", "Thoát", "");
            }
            catch
            {

            }
            this.Close();

        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            if (doiMatKhauBUS.LayMatKhauTheoTaiKhoan(tkdn) == txtpass.Text)
            {
                if (txtnewpass.Text == txtnewpass1.Text)
                {
                    int temp = doiMatKhauBUS.CapNhatMatKhau(tkdn, txtnewpass.Text.ToString());
                    if (temp > 0)
                    {
                        try
                        {
                            nhatKyHeThongBUS.ThemNhatKyHeThong("Thay đổi mật khẩu", "Đổi Mật khẩu", tkdn);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không đúng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnewpass1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng mời nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpass.Text = "";
            }
        }
    }
}