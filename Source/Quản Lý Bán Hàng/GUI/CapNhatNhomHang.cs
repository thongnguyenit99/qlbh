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
    public partial class CapNhatNhomHang : DevExpress.XtraEditors.XtraForm
    {
        CapNhatNhomHangBUS capNhatNhomHangBUS = new CapNhatNhomHangBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        string check;
        public CapNhatNhomHang(string vt)
        {
            InitializeComponent();
            check = vt;
            if (check == "-1")
            {
                this.Text = "Thêm Nhóm Hàng";
                txtmanhomhang.Text = capNhatNhomHangBUS.DeNghiMaDonViTinh();
            }
            else
            {
                DataTable dt = capNhatNhomHangBUS.LayThongTinNhomHangTheoMaNH(check);
                txtmanhomhang.Text = check;
                txtmanhomhang.ReadOnly = true;
                txtenhomhang.Text = dt.Rows[0]["Ten_NH"].ToString();
                txtghichu.Text = dt.Rows[0]["GhiChu"].ToString();
                if (dt.Rows[0]["ConQuanLy"].ToString() == "True")
                {
                    ckconquanly.Checked = true;
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (check == "-1")
            {
                if (txtmanhomhang.Text != "" && txtenhomhang.Text != "")
                {
                    // kiểm tra mã ton tai
                    if (!capNhatNhomHangBUS.KiemTraMaDonViTinhTonTai(txtmanhomhang.Text))
                    {
                        // thêm
                        if (capNhatNhomHangBUS.ThemNhomHangBTN(txtmanhomhang.Text, txtenhomhang.Text, txtghichu.Text, ckconquanly.Checked.ToString()) > 0)
                        {
                            try
                            {
                                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhóm Hàng", "Thêm", txtmanhomhang.Text);
                            }
                            catch
                            {

                            }
                            MessageBox.Show("Thêm nhóm hàng  thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            whenInsertSuccessed();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhóm hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhóm hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (txtmanhomhang.Text != "")
                {
                    // cap nhật
                    if (capNhatNhomHangBUS.CapNhatNhomHangBTN(txtmanhomhang.Text, txtenhomhang.Text, txtghichu.Text, ckconquanly.Checked.ToString()) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Nhóm Hàng", "Cập nhật", txtmanhomhang.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật nhóm hàng  thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        whenInsertSuccessed();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhóm hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}