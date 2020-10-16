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
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class CapNhatNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        string check;
        CapNhatNhaCungCapBUS capNhatNhaCungCapBUS = new CapNhatNhaCungCapBUS();
        private void LoadData()
        {
            cbkhuvuc.Properties.DataSource = capNhatNhaCungCapBUS.LayThongTinKhuVuc();
            cbkhuvuc.Properties.DisplayMember = "Tên Khu Vực";
            cbkhuvuc.Properties.ValueMember = "Mã Khu Vực";
            txtmancc.Text = capNhatNhaCungCapBUS.DeXuatMaNhaCungCap();
        }
        public CapNhatNhaCungCap(string vt)
        {
            InitializeComponent();
            check = vt;
            txtgioihanno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtgioihanno.Properties.Mask.EditMask = "n2";
            txtgioihanno.Properties.Mask.UseMaskAsDisplayFormat = true;
            LoadData();
            if (vt == "-1")
            {
                cbkhuvuc.EditValue = cbkhuvuc.Properties.GetKeyValue(0);
                this.Text = "Thêm nhà cung cấp";
                ckconquanly.Checked = true;
            }
            else
            {
                txtmancc.Text = vt;
                txtmancc.ReadOnly = true;
                try
                {
                    cbkhuvuc.EditValue = capNhatNhaCungCapBUS.LayViTriCuaKhuVuc(vt);
                }
                catch { }
                DataTable dt = capNhatNhaCungCapBUS.LayThongTinNhaCungCapTheoMaNCC(vt);
                if(dt.Rows.Count > 0 && dt != null)
                { 
                    txttenncc.Text = dt.Rows[0]["TenNCC"].ToString();
                    txtdiachi.Text = dt.Rows[0]["DiaChi"].ToString();
                    txtfax.Text = dt.Rows[0]["Fax"].ToString();
                    txtdienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
                    txtdidong.Text = dt.Rows[0]["DiDong"].ToString();
                    txtmasothue.Text = dt.Rows[0]["MaSoThue"].ToString();
                    txtemail.Text = dt.Rows[0]["Email"].ToString();
                    txtwebsite.Text = dt.Rows[0]["Website"].ToString();
                    txtsotaikhoan.Text = dt.Rows[0]["SoTaiKhoan"].ToString();
                    txttennganhang.Text = dt.Rows[0]["TenNganHang"].ToString();
                    txtgioihanno.Text = dt.Rows[0]["GioiHanNo"].ToString();
                    txtnohentai.Text = dt.Rows[0]["NoHienTai"].ToString();
                    txtchucvu.Text = dt.Rows[0]["ChucVu"].ToString();
                    txtchietkhau.Text = dt.Rows[0]["ChietKhau"].ToString();
                    if (dt.Rows[0]["ConQuanLy"].ToString() == "False")
                    {
                        ckconquanly.Checked = false;
                    }
                }
            }
        }
        private NhaCungCapDTO GanGiaTri()
        {
            NhaCungCapDTO temp = new NhaCungCapDTO()
            {
                MaNCC = txtmancc.Text, TenNCC = txttenncc.Text, MaKV = cbkhuvuc.EditValue.ToString(), NguoiLienHe = txtnguoilienhe.Text, DiaChi = txtdiachi.Text, MaSoThue = txtmasothue.Text,
                DienThoai = txtdienthoai.Text, DiDong = txtdidong.Text, Fax = txtfax.Text, mail = txtemail.Text, Website = txtwebsite.Text, SoTaiKhoan = txtsotaikhoan.Text,
                TenNganHang = txttennganhang.Text, GioiHanNo = txtgioihanno.Text, ChietKhau = txtchietkhau.Text, ChucVu = txtchucvu.Text, ConQuanLy = ckconquanly.Checked
            };
            return temp;
        }
        NhaCungCapDTO NhaCungCapDTO = new NhaCungCapDTO();
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (check == "-1")
            {
                if (txtmancc.Text != "" && txttenncc.Text != "")
                {
                    // kiểm tra mã nhà cung cấp
                    if (!capNhatNhaCungCapBUS.KiemTraMaNhaCungCap(txtmancc.Text))
                    {
                        NhaCungCapDTO = GanGiaTri();
                        if (capNhatNhaCungCapBUS.ThemNhaCungCap(NhaCungCapDTO) > 0)
                        {
                            try
                            {
                                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhà Cung Cấp", "Thêm", txtmancc.Text);
                            }
                            catch
                            {

                            }
                            MessageBox.Show("Thêm nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            whenInsertSuccessed();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhà cung cấp thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhà cũng cấp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (txttenncc.Text != "")
                {

                    NhaCungCapDTO = GanGiaTri();
                    if (capNhatNhaCungCapBUS.CapNhatNhaCungCapBTN(NhaCungCapDTO) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Nhà Cung Cấp", "Cập nhật", txtmancc.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        whenInsertSuccessed();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật nhà cung cấp thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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