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
    public partial class CapNhatKhoHang : DevExpress.XtraEditors.XtraForm
    {
        CapNhatKhoHangBUS capNhatKhoHangBUS = new CapNhatKhoHangBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        string check;
        DataTable dt = new DataTable();
        private  void LoadData()
        {
            // load combobox nhanvien
            cbnguoiquanly.Properties.DataSource = capNhatKhoHangBUS.LayThongTinNhanVien();
            cbnguoiquanly.Properties.DisplayMember = "Tên Nhân Viên";
            cbnguoiquanly.Properties.ValueMember = "Mã";
        }
        private void SetValueTextBox()
        {
            dt = capNhatKhoHangBUS.LayThongTinKhoHangTheoMaKH(check);
            txtmakho.Text = dt.Rows[0]["MaKH"].ToString();
            txtmakho.ReadOnly = true;
            txtenkho.Text = dt.Rows[0]["TenKH"].ToString();
            txtkihieu.Text = dt.Rows[0]["KyHieu"].ToString();
            txtnguoilienhe.Text = dt.Rows[0]["NguoiLienHe"].ToString();
            txtdiachi.Text = dt.Rows[0]["DiaChi"].ToString();
            txtdienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
            txtdiengiai.Text = dt.Rows[0]["DienGiai"].ToString();
            txtfax.Text = dt.Rows[0]["fax"].ToString();
            txtemail.Text = dt.Rows[0]["Email"].ToString();
            if(dt.Rows[0]["ConQuanLy"].ToString() == "True")
            {
                ckconquanly.Checked = true;
            }
            if(capNhatKhoHangBUS.LayViTriNhanVienQuanLy(check) >= 0)
            {
                cbnguoiquanly.EditValue = cbnguoiquanly.Properties.GetKeyValue(capNhatKhoHangBUS.LayViTriNhanVienQuanLy(check));
            }

        }
        public CapNhatKhoHang(string vt)
        {
            InitializeComponent();
            LoadData();
            check = vt;
            if(check == "-1")
            {
                ckconquanly.Checked = true;
                cbnguoiquanly.EditValue = cbnguoiquanly.Properties.GetKeyValue(0);
                txtmakho.Text = capNhatKhoHangBUS.DeXuatMaKH();
                this.Text = "Thêm Kho Hàng";
            }
            else 
            {
                SetValueTextBox();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private KhoHangDTO GanGiaTri()
        {
            try
            {
                KhoHangDTO khoHangDTO = new KhoHangDTO()
                {
                    MaKH = txtmakho.Text.ToString(),
                    TenKH = txtenkho.Text.ToString(),
                    ConQuanLy = ckconquanly.Checked,
                    NguoiQuanLy = cbnguoiquanly.EditValue.ToString(),
                    KyHieu = txtkihieu.Text.ToString(),
                    NguoiLienHe = txtnguoilienhe.Text.ToString(),
                    DiaChi = txtdiachi.Text.ToString(),
                    DienThoai = txtdienthoai.Text.ToString(),
                    Fax = txtfax.Text.ToString(),
                    Email = txtemail.Text.ToString(),
                    DienGiai = txtdiengiai.Text.ToString()
                };
                return khoHangDTO;
            }
            catch
            {
                KhoHangDTO khoHangDTO = new KhoHangDTO()
                {
                    MaKH = txtmakho.Text.ToString(),
                    TenKH = txtenkho.Text.ToString(),
                    ConQuanLy = ckconquanly.Checked,
                    NguoiQuanLy = "",
                    KyHieu = txtkihieu.Text.ToString(),
                    NguoiLienHe = txtnguoilienhe.Text.ToString(),
                    DiaChi = txtdiachi.Text.ToString(),
                    DienThoai = txtdienthoai.Text.ToString(),
                    Fax = txtfax.Text.ToString(),
                    Email = txtemail.Text.ToString(),
                    DienGiai = txtdiengiai.Text.ToString()
                };
                return khoHangDTO;
            }

        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            KhoHangDTO kho = GanGiaTri();
            if (check == "-1")
            {
                if(txtmakho.Text != "" && txtenkho.Text != "")
                {
                    //Kiểm tra mã kho hàng đã tồn tại
                    if(!capNhatKhoHangBUS.KiemTraMaKhoHangDaTonTai(txtmakho.Text))
                    {
                        if(capNhatKhoHangBUS.ThemKhoHangBTN(kho) > 0)
                        {
                            try
                            {
                                NhatKyHeThongBUS.ThemNhatKyHeThong("Kho Hàng", "Thêm", txtmakho.Text);
                            }
                            catch
                            {

                            }
                            MessageBox.Show("Thêm kho hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            whenInsertSuccessed();
                        }
                        else
                        {
                            MessageBox.Show("Thêm kho hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Kho Hàng Đã Tồn Tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else 
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                if (txtenkho.Text != "")
                {
                    if (capNhatKhoHangBUS.CapNhatKhoHangBTN(kho) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Kho Hàng", "Cập nhật", txtmakho.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật kho hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        whenInsertSuccessed();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật kho hàng thất bại kho hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}