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

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class ThemNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        ThemNguoiDungBUS themNguoiDungBUS = new ThemNguoiDungBUS();
        NhatKyHeThongBUS nhatKyHeThongBUS = new NhatKyHeThongBUS();
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        public ThemNguoiDung()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            cbnhanvien.DataSource = themNguoiDungBUS.GetInFoNhanVien();
            cbnhanvien.DisplayMember = "TenNV";
            cbnhanvien.ValueMember = "MaNV";
            cbvaitro.DataSource = themNguoiDungBUS.GetInForVaiTro();
            cbvaitro.DisplayMember = "RoleName";
            cbvaitro.ValueMember = "ID";
        }
        private void ThemNguoiDung_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txttk.Text != "")
            {
                if (themNguoiDungBUS.CheckUserName(txttk.Text))
                {
                    if (txtpass.Text == txtxacnhan.Text)
                    {
                        if (themNguoiDungBUS.ThemNguoiDungBTN(txttk.Text.ToString(), txtpass.Text.ToString(), cbnhanvien.SelectedValue.ToString(), int.Parse(cbvaitro.SelectedValue.ToString()), ckconquanly.Checked) > 0)
                        {
                            try
                            {
                                nhatKyHeThongBUS.ThemNhatKyHeThong("Phân quyền", "Thêm người dùng", txttk.Text);
                            }
                            catch
                            {

                            }
                            MessageBox.Show("Thêm người dùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            whenInsertSuccessed();
                        }
                        else
                        {
                            MessageBox.Show("Thêm người dùng thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu xác nhận không hợp lê.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên người dùng đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài Khoản không được rỗng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthemvt_Click(object sender, EventArgs e)
        {
            CapNhatVaiTro capNhatVaiTro = new CapNhatVaiTro(-1, -1);
            capNhatVaiTro.whenInsertSuccessed += loaddata;
            capNhatVaiTro.ShowDialog();
        }
    }
}