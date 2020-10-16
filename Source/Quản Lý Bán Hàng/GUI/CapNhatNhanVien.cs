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
using Quản_Lý_Bán_Hàng.GUI;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class CapNhatNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        CapNhatNhanVienBUS capNhatNhanVienBUS = new CapNhatNhanVienBUS();
        string check;
        DataTable dt;
        private void LoadData()
        {
            cbbophan.Properties.DataSource = capNhatNhanVienBUS.LayThongTinBoPhanCB();
            cbbophan.Properties.DisplayMember = "Tên";
            cbbophan.Properties.ValueMember = "Mã";

            cbquanly.Properties.DataSource = capNhatNhanVienBUS.LayThongTinNhanVienCB();
            cbquanly.Properties.DisplayMember = "Tên";
            cbquanly.Properties.ValueMember = "Mã";
        }
        public CapNhatNhanVien(string vt)
        {
            InitializeComponent();
            check = vt;
            LoadData();
            if(check == "-1")
            {
                this.Text = "Thêm nhân viên";
                txtma.Text = capNhatNhanVienBUS.DeXuatMaNV();
                cbbophan.EditValue = cbbophan.Properties.GetKeyValue(0);
                cbquanly.EditValue = cbquanly.Properties.GetKeyValue(0);
            }
            else
            {
                dt = capNhatNhanVienBUS.LayThongTinNhanVienTheoMaNV(check);
                txtma.Text = dt.Rows[0]["MaNV"].ToString();
                txtma.ReadOnly = true;
                txtten.Text = dt.Rows[0]["TenNV"].ToString();
                txtdiachi.Text  = dt.Rows[0]["DiaChi"].ToString();
                txtdienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
                txtdidong.Text = dt.Rows[0]["DiDong"].ToString();
                txtemail.Text = dt.Rows[0]["Email"].ToString();
                if(dt.Rows[0]["ConQuanLy"].ToString() == "True")
                {
                    ckconquanly.Checked = true;
                }
                // set vi cb
                if (capNhatNhanVienBUS.LayViTriBoPhan(check) > -1)
                {
                    cbbophan.EditValue = cbbophan.Properties.GetKeyValue(capNhatNhanVienBUS.LayViTriBoPhan(check));
                }
                if (capNhatNhanVienBUS.LayViTriNhanVien(check) > -1)
                {
                    cbquanly.EditValue = cbquanly.Properties.GetKeyValue(capNhatNhanVienBUS.LayViTriNhanVien(check));
                }
            }
        }
        private NhanVienDTO SetGiaTri()
        {
            NhanVienDTO nv = new NhanVienDTO()
            {
                MaNV = txtma.Text, TenNV = txtten.Text, DiaChi = txtdiachi.Text, DienThoai = txtdienthoai.Text, DiDong = txtdidong.Text, Email = txtemail.Text,
                BoPhan = cbbophan.EditValue.ToString(), QuanLy = cbquanly.EditValue.ToString(), ConQuanLy = ckconquanly.Checked.ToString()
            };
            return nv;
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            NhanVienDTO tempdto = SetGiaTri();
            if (check == "-1")
            {
                if (txtten.Text != "" && txtma.Text != "")
                {
                    // Kiểm tra MaKH đã tồn tại
                    if (capNhatNhanVienBUS.KiemTraMaNVTonTai(txtma.Text) == 0)
                    {
                        int temp = 0;
                        temp = capNhatNhanVienBUS.ThemNhanVienBTN(tempdto);
                        if (temp > 0)
                        {
                            try
                            {
                                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhân Viên", "Thêm", txtma.Text);
                            }
                            catch
                            {

                            }
                            MessageBox.Show("Thêm nhân viên thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            whenInsertSuccessed();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên  thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thêm thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (txtten.Text != "")
                {
                    bool x = ckconquanly.Checked;
                    int temp = 0;
                    temp = capNhatNhanVienBUS.CapNhatNhanVienBTN(tempdto);
                    if (temp > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Nhân Viên", "Cập nhật", txtma.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật nhân viên thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        whenInsertSuccessed();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhân viên thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thêm thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnthembp_Click(object sender, EventArgs e)
        {
            CapNhatBoPhan capNhatBoPhan = new  CapNhatBoPhan("-1");
            capNhatBoPhan.whenInsertSuccessed += LoadData;
            capNhatBoPhan.ShowDialog();
        }

        private void btnthemnv_Click(object sender, EventArgs e)
        {
            CapNhatNhanVien capNhatNhanVien = new CapNhatNhanVien("-1");
            capNhatNhanVien.whenInsertSuccessed += LoadData;
            capNhatNhanVien.ShowDialog();
        }
    }
}