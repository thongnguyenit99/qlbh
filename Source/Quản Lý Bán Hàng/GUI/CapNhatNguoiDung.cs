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
using static DevExpress.DataAccess.UI.XPObjectSource.PropertyCollectionEditor;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class CapNhatNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        CapNhatNguoiDungBUS capNhatNguoiDungBUS = new CapNhatNguoiDungBUS();
        NhatKyHeThongBUS nhatKyHeThongBUS = new NhatKyHeThongBUS();
        string username;
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        public CapNhatNguoiDung(string tentk)
        {
            InitializeComponent();
            username = tentk;
        }

        private void CapNhatNguoiDung_Load(object sender, EventArgs e)
        {
            //truyên vô combobox
            cbnhanvien.Properties.DataSource = capNhatNguoiDungBUS.LayThongTinTatCaNV();
            cbnhanvien.Properties.DisplayMember = "TenNV";
            cbnhanvien.Properties.ValueMember = "MaNV";
            cbvaitro.DataSource = capNhatNguoiDungBUS.LayThongTinVaiTro();
            cbvaitro.DisplayMember = "RoleName";
            cbvaitro.ValueMember = "id";
            DataTable dt = capNhatNguoiDungBUS.LayTTTaiKhoanNhanVien(username);
            DataTable dt1 = capNhatNguoiDungBUS.LayThongTinTatCaNV();
            DataTable dt2 = capNhatNguoiDungBUS.LayThongTinVaiTro();
            // sét giá trị mặc định
            int vtnv = 0;
            int vt = 0;
            for(int i = 0; i < dt1.Rows.Count;i++)
            {
                 if(dt1.Rows[i]["MaNV"].ToString() == dt.Rows[0]["MaNV"].ToString())
                {
                    vtnv = i;
                }
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt2.Rows[i]["Id"].ToString() == dt.Rows[0]["RoleID"].ToString())
                {
                    vt = i;
                }
            }
            cbnhanvien.EditValue = cbnhanvien.Properties.GetKeyValue(vtnv);
            cbvaitro.SelectedIndex = vt;
            // sét giá trị cho textbox
            txttaikhoan.Text = dt.Rows[0]["UserName"].ToString();
            txtpass.Text = dt.Rows[0]["Passwd"].ToString();
            txtxacnhan.Text = dt.Rows[0]["Passwd"].ToString();
            txtdiengiai.Text = dt.Rows[0]["Descripttion"].ToString();
            txttaikhoan.ReadOnly = true;
            
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int vt = int.Parse(cbvaitro.SelectedValue.ToString());
            DataTable dt = capNhatNguoiDungBUS.LayMaNVTuTenNV(cbnhanvien.SelectedText.ToString());
            string manv = dt.Rows[0]["MaNV"].ToString();
            if (txttaikhoan.Text != "")
            {
                if (txtpass.Text == txtxacnhan.Text)
                {
                    if (capNhatNguoiDungBUS.CapNhatNguoiDungBUSbtn(txttaikhoan.Text, manv, txtpass.Text, vt, txtdiengiai.Text, ckquanly.Checked) > 0)
                    {
                        try
                        {
                            nhatKyHeThongBUS.ThemNhatKyHeThong("Phân quyền", "Cập nhật người dùng", txttaikhoan.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        whenInsertSuccessed();
                        txttaikhoan.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu sai, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không được rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}