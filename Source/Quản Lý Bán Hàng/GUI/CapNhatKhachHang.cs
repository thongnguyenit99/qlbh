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
    public partial class CapNhatKhachHang : DevExpress.XtraEditors.XtraForm
    {
        CapNhatKhachHangBUS CapNhatKhachHangBUS = new CapNhatKhachHangBUS();
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        string check;
        DataTable dt;
        private void LoadData()
        {
            dt = CapNhatKhachHangBUS.LayThongTinKhuVuc();
            cbkhuvuc.Properties.DataSource = dt;
            cbkhuvuc.Properties.DisplayMember = "TenKV";
            cbkhuvuc.Properties.ValueMember = "MaKV";
            rddaily.Checked = true;
            txtmakh.Text = CapNhatKhachHangBUS.DeNghiMaKhacHang();
            txtgioihanno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtgioihanno.Properties.Mask.EditMask = "n2";
            txtgioihanno.Properties.Mask.UseMaskAsDisplayFormat = true;
        }
        private void XetGiaTriKhiCapNhat()
        {
            dt = CapNhatKhachHangBUS.LayThongTinKhachHangTheoMaKH(check);
            txtmakh.Text = check;
            txtmakh.ReadOnly = true;
            txttenkh.Text = dt.Rows[0]["TenKH"].ToString();
            txtdiachi.Text = dt.Rows[0]["DiaChi"].ToString();
            txtnguoilienhe.Text = dt.Rows[0]["NguoiLienHe"].ToString();
            txtmasothue.Text = dt.Rows[0]["MaSoThue"].ToString();
            txtdienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
            txtdidong.Text = dt.Rows[0]["DiDong"].ToString();
            txtfax.Text = dt.Rows[0]["Fax"].ToString();
            txtemail.Text = dt.Rows[0]["Email"].ToString();
            txtwebsite.Text = dt.Rows[0]["Website"].ToString();
            txtsotaikhoan.Text = dt.Rows[0]["SoTaiKhoan"].ToString();
            txttennganhang.Text = dt.Rows[0]["TenNganHang"].ToString();
            txtgioihanno.Text = dt.Rows[0]["GioiHanNo"].ToString();
            txtnohentai.Text = dt.Rows[0]["NoHienTai"].ToString();
            txtchietkhau.Text = dt.Rows[0]["ChietKhau"].ToString();
            txtnickskype.Text = dt.Rows[0]["NickSkype"].ToString();
            txtyahoo.Text = dt.Rows[0]["NickYahoo"].ToString();
            
            cbkhuvuc.EditValue = cbkhuvuc.Properties.GetKeyValue(CapNhatKhachHangBUS.ViTriKhoVuc(check));

            if (dt.Rows[0]["ConQuanLy"].ToString() == "True")
            {
                ckconquanly.Checked = true;
            }
            if (dt.Rows[0]["LoaiKH"].ToString() == "DL")
            {
                rddaily.Checked = true;
            }
            else if (dt.Rows[0]["LoaiKH"].ToString() == "KL")
            {
                rdkhachle.Checked = true;
            }
        }
        public CapNhatKhachHang(string vt)
        {
            InitializeComponent();
            check = vt;
            if(check == "-1")
            {
                this.Text = "Thêm Khách Hàng";
                LoadData();
                cbkhuvuc.EditValue = cbkhuvuc.Properties.GetKeyValue(0);
            }
            else
            {
                this.Text = "Cập nhật Khách Hàng";
                LoadData();
                XetGiaTriKhiCapNhat();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(check == "-1")
            {
                if (txtmakh.Text != "" && txttenkh.Text != "")
                {
                    // Kiểm tra MaKH đã tồn tại
                    if (CapNhatKhachHangBUS.KiemTraMaKhachHangTonTai(txtmakh.Text) == 0)
                    {
                        bool x = ckconquanly.Checked;
                        int temp = 0;
                        // nếu là đại lý
                        if (rddaily.Checked)
                        {
                            temp = CapNhatKhachHangBUS.ThemKhachHangBTN(txtmakh.Text, txttenkh.Text, cbkhuvuc.EditValue.ToString(), txtdiachi.Text, txtmasothue.Text,
                                                                            txtfax.Text, txtdienthoai.Text, txtdidong.Text, txtemail.Text, txtwebsite.Text, txtsotaikhoan.Text,
                                                                            txttennganhang.Text, txtgioihanno.Text, "0", txtchietkhau.Text, txtyahoo.Text, txtnguoilienhe.Text, txtnickskype.Text, "DL", ckconquanly.Checked.ToString());
                        }
                        else
                        {
                            temp = CapNhatKhachHangBUS.ThemKhachHangBTN(txtmakh.Text, txttenkh.Text, cbkhuvuc.EditValue.ToString(), txtdiachi.Text, txtmasothue.Text,
                                                    txtfax.Text, txtdienthoai.Text, txtdidong.Text, txtemail.Text, txtwebsite.Text, txtsotaikhoan.Text,
                                                    txttennganhang.Text, txtgioihanno.Text, "0", txtchietkhau.Text, txtyahoo.Text, txtnguoilienhe.Text, txtnickskype.Text, "KL", ckconquanly.Checked.ToString());
                        }
                        if (temp > 0)
                        {
                            try
                            {
                                NhatKyHeThongBUS.ThemNhatKyHeThong("Khách Hàng", "Thêm khách hàng", txtmakh.Text);
                            }
                            catch
                            {

                            }
                            MessageBox.Show("Thêm khách hàng thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            try
                            {
                                whenInsertSuccessed();
                            }
                            catch { }
                        }
                        else
                        {
                            MessageBox.Show("Thêm khách hàng  thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thêm thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                if (txttenkh.Text != "")
                {
                    bool x = ckconquanly.Checked;
                    int temp = 0;
                    // nếu là đại lý
                    if (rddaily.Checked)
                    {
                        temp = CapNhatKhachHangBUS.CapNhatKhachHangBTN(txtmakh.Text, txttenkh.Text, cbkhuvuc.EditValue.ToString(), txtdiachi.Text, txtmasothue.Text,
                                                                        txtfax.Text, txtdienthoai.Text, txtdidong.Text, txtemail.Text, txtwebsite.Text, txtsotaikhoan.Text,
                                                                        txttennganhang.Text, txtgioihanno.Text, "0", txtchietkhau.Text, txtyahoo.Text, txtnguoilienhe.Text, txtnickskype.Text, "DL", ckconquanly.Checked.ToString());
                    }
                    else
                    {
                        temp = CapNhatKhachHangBUS.CapNhatKhachHangBTN(txtmakh.Text, txttenkh.Text, cbkhuvuc.EditValue.ToString(), txtdiachi.Text, txtmasothue.Text,
                                                txtfax.Text, txtdienthoai.Text, txtdidong.Text, txtemail.Text, txtwebsite.Text, txtsotaikhoan.Text,
                                                txttennganhang.Text, txtgioihanno.Text, "0", txtchietkhau.Text, txtyahoo.Text, txtnguoilienhe.Text, txtnickskype.Text, "KL", ckconquanly.Checked.ToString());
                    }
                    if (temp > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Khách Hàng", "Cập Nhật Khách Hàng", txtmakh.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật khách hàng thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        whenInsertSuccessed();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khách hàng  thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thêm thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemkhuvuc_Click(object sender, EventArgs e)
        {
            CapNhatKhuVuc capNhatKhuVuc = new CapNhatKhuVuc(-1);
            capNhatKhuVuc.whenInsertSuccessed += LoadData;
            capNhatKhuVuc.ShowDialog();
        }
    }
}