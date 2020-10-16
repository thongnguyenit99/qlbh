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
using DevExpress.XtraEditors.Controls;
using Quan_Ly_Ban_Hang.BUS;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class CapNhatHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        CapNhatHangHoaBUS capNhatHangHoaBUS = new CapNhatHangHoaBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        HangHoaDTO hangHoaDTO;
        string check,path;
        DataTable dt;
        private void SetGiaTriChoBieuMau()
        {
            dt = capNhatHangHoaBUS.LayThongTinHangHoaTheoMaHH(check);
            txtmahang.Text = dt.Rows[0]["MaHH"].ToString();
            txtmahang.ReadOnly = true;
            txttenhanghoa.Text = dt.Rows[0]["TenHH"].ToString();
            txtmavach.Text = dt.Rows[0]["MaVachNSX"].ToString();
            txtxuatxu.Text = dt.Rows[0]["XuatXu"].ToString();
            txttonkhotoithieu.Text = dt.Rows[0]["TonKhoToiThieu"].ToString();
            txttonkhohtai.Text = dt.Rows[0]["TonKhoHienTai"].ToString();
            if (dt.Rows[0]["Anh"].ToString() != "")
            {
                pichanghoa.Image = Image.FromFile(dt.Rows[0]["Anh"].ToString());
                pichanghoa.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            }
            txtgiamua.Text = dt.Rows[0]["GiaMua"].ToString();
            txtgiabanle.Text = dt.Rows[0]["GiaBanLe"].ToString();
            txtgiaban.Text = dt.Rows[0]["GiaBanSi"].ToString();
            if(dt.Rows[0]["ConQuanLy"].ToString() == "True")
            {
                ckconquanly.Checked = true;
            }
            // set gia trị cho combobox
        }
        private void TextChiLaSo()
        {
            //txttonkhotoithieu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //txttonkhotoithieu.Properties.Mask.EditMask = "n2";
            //txttonkhotoithieu.Properties.Mask.UseMaskAsDisplayFormat = true;

            //txttonkhohtai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //txttonkhohtai.Properties.Mask.EditMask = "n2";
            //txttonkhohtai.Properties.Mask.UseMaskAsDisplayFormat = true;

            txtgiaban.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtgiaban.Properties.Mask.EditMask = "n2";
            txtgiaban.Properties.Mask.UseMaskAsDisplayFormat = true;

            txtgiamua.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtgiamua.Properties.Mask.EditMask = "n2";
            txtgiamua.Properties.Mask.UseMaskAsDisplayFormat = true;

            txtgiabanle.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtgiabanle.Properties.Mask.EditMask = "n2";
            txtgiabanle.Properties.Mask.UseMaskAsDisplayFormat = true;
        }
        private void LoadData()
        {
            TextChiLaSo();
            pichanghoa.Properties.NullText = "Ảnh";
            cbloaihanghoa.Properties.DataSource = capNhatHangHoaBUS.LayThongTinLoaiHangHoa();
            cbloaihanghoa.Properties.DisplayMember = "Tên";
            cbloaihanghoa.Properties.ValueMember = "Mã";

            cbkho.Properties.DataSource = capNhatHangHoaBUS.LayThongTinKhoHang();
            cbkho.Properties.DisplayMember = "Kho Hàng";
            cbkho.Properties.ValueMember = "Mã";

            cbphanloai.Properties.DataSource = capNhatHangHoaBUS.LayThongTinNhomHang();
            cbphanloai.Properties.DisplayMember = "Nhóm Hàng";
            cbphanloai.Properties.ValueMember = "Mã";

            cbdonvi.Properties.DataSource = capNhatHangHoaBUS.LayThongTinDonVi();
            cbdonvi.Properties.DisplayMember = "Đơn Vị";
            cbdonvi.Properties.ValueMember = "Mã";

            cbnhacungcap.Properties.DataSource = capNhatHangHoaBUS.LayThongTinNhaCungCap();
            cbnhacungcap.Properties.DisplayMember = "Nhà Phân Phối";
            cbnhacungcap.Properties.ValueMember = "Mã";

            if (check == "-1")
            {
                this.Text = "Thêm hàng hóa, dịch vụ";
                ckconquanly.Checked = true;
                txtmahang.Text = capNhatHangHoaBUS.DeXuatMaHangHoa();
                cbloaihanghoa.EditValue = cbloaihanghoa.Properties.GetKeyValue(0);
                cbkho.EditValue = cbkho.Properties.GetKeyValue(0);
                cbphanloai.EditValue = cbphanloai.Properties.GetKeyValue(0);
                cbdonvi.EditValue = cbdonvi.Properties.GetKeyValue(0);
                cbnhacungcap.EditValue = cbnhacungcap.Properties.GetKeyValue(0);
            }
            else
            {
                SetGiaTriChoBieuMau();
                // set vi tri
                if (capNhatHangHoaBUS.LayViTriCuaLoaiHangHoa(check) > -1)
                {
                    cbloaihanghoa.EditValue = cbloaihanghoa.Properties.GetKeyValue(capNhatHangHoaBUS.LayViTriCuaLoaiHangHoa(check));
                }
                if (capNhatHangHoaBUS.LayViTriCuaKhoHang(check) > -1)
                {
                    cbkho.EditValue = cbkho.Properties.GetKeyValue(capNhatHangHoaBUS.LayViTriCuaKhoHang(check));
                }
                if (capNhatHangHoaBUS.LayViTriCuaNhomHang(check) > -1)
                {
                    cbphanloai.EditValue = cbphanloai.Properties.GetKeyValue(capNhatHangHoaBUS.LayViTriCuaNhomHang(check));
                }
                if (capNhatHangHoaBUS.LayViTriCuaDonVi(check) > -1)
                {
                    cbdonvi.EditValue = cbdonvi.Properties.GetKeyValue(capNhatHangHoaBUS.LayViTriCuaDonVi(check));
                }
                if (capNhatHangHoaBUS.LayViTriNhaCungCap(check) > -1)
                {
                    cbnhacungcap.EditValue = cbnhacungcap.Properties.GetKeyValue(capNhatHangHoaBUS.LayViTriNhaCungCap(check));
                }
            }
        }
        public CapNhatHangHoa(string vt)
        {
            InitializeComponent();
            check = vt;
            LoadData();
        }

        private void pichanghoa_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            if (dlg.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dlg.FileName))
            {
                path = dlg.FileName;
                pichanghoa.Image = Image.FromFile(dlg.FileName);
                pichanghoa.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            }
        }
        private HangHoaDTO SetGiaTri()
        {
            float f;
            int n;
            float.TryParse(txtgiaban.Text, out f);
            if(f == 0)
            {
                txtgiaban.Text = "0.0";
            }
            float.TryParse(txtgiamua.Text, out f);
            if (f == 0)
            {
                txtgiamua.Text = "0.0";
            }
            float.TryParse(txtgiabanle.Text, out f);
            if (f == 0)
            {
                txtgiabanle.Text = "0.0";
            }
            int.TryParse(txttonkhotoithieu.Text, out n);
            if (n == 0)
            {
                txttonkhotoithieu.Text = "0";
            }
            int.TryParse(txttonkhohtai.Text, out n);
            if (n == 0)
            {
                txttonkhohtai.Text = "0";
            }
            string cb_lnh, cb_kho, nhacungcap, cb_pl, cb_dv;
            try
            {
                cb_pl = cbphanloai.EditValue.ToString();
            }
            catch
            {
                cb_pl = "";
            }
            try
            {
                cb_dv = cbdonvi.EditValue.ToString();
            }
            catch
            {
                cb_dv = "";
            }
            try {
                 cb_lnh = cbloaihanghoa.EditValue.ToString();
            }
            catch {
                cb_lnh = "";
            }
            try
            {
                cb_kho = cbkho.EditValue.ToString();
            }
            catch
            {
                cb_kho = "";
            }
            try
            {
                nhacungcap = cbnhacungcap.EditValue.ToString();
            }
            catch
            {
                nhacungcap = "";
            }

            try
            {
                HangHoaDTO hh = new HangHoaDTO()
                {
                    MaHH = txtmahang.Text,
                    TenHH = txttenhanghoa.Text,
                    MaDV = cb_dv,
                    MaNH = cb_pl,
                    MaLHH = cb_lnh,
                    MaKho = cb_kho,
                    MaVachNSX = txtmavach.Text,
                    XuatXu = txtxuatxu.Text,
                    TonKhoToiThieu = int.Parse(txttonkhotoithieu.Text.ToString()),
                    TonKhoHienTai = int.Parse(txttonkhohtai.Text.ToString()),
                    Anh = path,
                    MaNCC = nhacungcap,
                    GiaMua = float.Parse(txtgiamua.Text.ToString()),
                    GiaBanLe = float.Parse(txtgiaban.Text.ToString()),
                    GiaBanSi = float.Parse(txtgiabanle.Text.ToString()),
                    ConQuanLy = ckconquanly.Checked.ToString()
                };
                return hh;
            }
            catch 
            {
                HangHoaDTO hh = new HangHoaDTO()
                {
                    MaHH = txtmahang.Text,
                    TenHH = txttenhanghoa.Text,
                    MaDV = cbdonvi.EditValue.ToString(),
                    MaNH = cbphanloai.EditValue.ToString(),
                    MaLHH = cbloaihanghoa.EditValue.ToString(),
                    MaKho = cbkho.EditValue.ToString(),
                    MaVachNSX = txtmavach.Text,
                    XuatXu = txtxuatxu.Text,
                    TonKhoToiThieu = int.Parse(txttonkhotoithieu.Text.ToString()),
                    TonKhoHienTai = int.Parse(txttonkhohtai.Text.ToString()),
                    Anh = path,
                    MaNCC = "",
                    GiaMua = float.Parse(txtgiamua.Text.ToString()),
                    GiaBanLe = float.Parse(txtgiaban.Text.ToString()),
                    GiaBanSi = float.Parse(txtgiabanle.Text.ToString()),
                    ConQuanLy = ckconquanly.Checked.ToString()
                };
                return hh;
            }
          
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (check == "-1")
            {
                if (txtmahang.Text != "" && txttenhanghoa.Text != "" && cbloaihanghoa.EditValue.ToString() != null &&
                    cbkho.EditValue.ToString() != null && cbdonvi.EditValue.ToString() != null && cbphanloai.EditValue.ToString() != null)
                {
                    // Kiểm tra MaKH đã tồn tại
                    if (capNhatHangHoaBUS.KiemTrMaHangHoaDaTonTai(txtmahang.Text) == 0)
                    {
                        int temp = 0;
                        hangHoaDTO = SetGiaTri();
                       temp = capNhatHangHoaBUS.ThemHangHoaBTN(hangHoaDTO);
                        if (temp > 0)
                        {
                            try
                            {
                                NhatKyHeThongBUS.ThemNhatKyHeThong("Hàng Hóa", "Thêm", txtmahang.Text);
                            }
                            catch
                            {

                            }
                            MessageBox.Show("Thêm hàng hóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            whenInsertSuccessed();
                        }
                        else
                        {
                            MessageBox.Show("Thêm hàng hóa thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã hàng hóa đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thêm thông tin những ô có dấu * màu đỏ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (txttenhanghoa.Text != "" && cbloaihanghoa.EditValue.ToString() != null &&
                    cbkho.EditValue.ToString() != null && cbdonvi.EditValue.ToString() != null && cbphanloai.EditValue.ToString() != null)
                {
                    int temp = 0;
                    hangHoaDTO = SetGiaTri();
                    temp = capNhatHangHoaBUS.CapNhatHangHoaBTN(hangHoaDTO);
                    hangHoaDTO = SetGiaTri();
                    if (temp > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Hàng Hóa", "Cập nhật", txtmahang.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật hàng hóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        whenInsertSuccessed();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật hàng hóa thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thêm thông tin những ô có dấu * màu đỏ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnkhohangshow_Click(object sender, EventArgs e)
        {
            CapNhatKhoHang capNhatKhoHang = new CapNhatKhoHang("-1");
            capNhatKhoHang.whenInsertSuccessed += LoadData;
            capNhatKhoHang.ShowDialog();
        }

        private void btnphanloaishow_Click(object sender, EventArgs e)
        {
            CapNhatNhomHang capNhatNhomHang = new CapNhatNhomHang("-1");
            capNhatNhomHang.whenInsertSuccessed += LoadData;
            capNhatNhomHang.ShowDialog();
        }

        private void btndonvishow_Click(object sender, EventArgs e)
        {
            CapNhatDonViTinh capNhatDonViTinh = new CapNhatDonViTinh("-1");
            capNhatDonViTinh.whenInsertSuccessed += LoadData;
            capNhatDonViTinh.ShowDialog();
        }

        private void btnnhacungcapshow_Click(object sender, EventArgs e)
        {
            CapNhatNhaCungCap capNhatNhaCungCap = new CapNhatNhaCungCap("-1");
            capNhatNhaCungCap.whenInsertSuccessed += LoadData;
            capNhatNhaCungCap.ShowDialog();
        }

        private void btnlichsugiaodich_Click(object sender, EventArgs e)
        {

        }
    }
}