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
    public partial class CapNhatDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        NhatKyHeThongBUS nhatKyHeThongBUS = new NhatKyHeThongBUS();
        CapNhatDonViTinhBUS CapNhatDonViTinhBUS = new CapNhatDonViTinhBUS();
        string check;

        public CapNhatDonViTinh(string vt)
        {
            InitializeComponent();
            check = vt;
            if(check == "-1")
            {
                this.Text = "Thêm Đơn Vị Tính";
                txtmaxdvt.Text = CapNhatDonViTinhBUS.DeNghiMaDonViTinh();
            }
            else 
            {
                DataTable dt = CapNhatDonViTinhBUS.LayThongTinDonViTinhTheoMa(check);
                txtmaxdvt.Text = check;
                txtmaxdvt.ReadOnly = true;
                txttendvt.Text = dt.Rows[0]["TenDVT"].ToString();
                txtghichu.Text = dt.Rows[0]["GhiChu"].ToString();
                if(dt.Rows[0]["ConQuanLy"].ToString() == "True")
                {
                    ckconquanly.Checked = true;
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(check == "-1")
            {
                if(txtmaxdvt.Text != "" && txttendvt.Text != "")
                {
                    // kiểm tra mã ton tai
                    if(!CapNhatDonViTinhBUS.KiemTraMaDonViTinhTonTai(txtmaxdvt.Text))
                    {
                        // thêm
                        if(CapNhatDonViTinhBUS.ThemDonViTinhBTN(txtmaxdvt.Text, txttendvt.Text, txtghichu.Text, ckconquanly.Checked.ToString()) > 0)
                        {
                            try
                            {
                                nhatKyHeThongBUS.ThemNhatKyHeThong("Đơn vị tính", "Thêm", txtmaxdvt.Text);
                            }
                            catch
                            {

                            }
                            MessageBox.Show("Thêm đơn vị tính  thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            whenInsertSuccessed();
                        }
                        else
                        {
                            MessageBox.Show("Thêm đơn vị tính thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã đơn vị tính đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                if (txttendvt.Text != "")
                {
                    // cap nhật
                    if (CapNhatDonViTinhBUS.CapNhatDonViTinhBTN(txtmaxdvt.Text, txttendvt.Text, txtghichu.Text, ckconquanly.Checked.ToString()) > 0)
                    {
                        try
                        {
                            nhatKyHeThongBUS.ThemNhatKyHeThong("Đơn vị tính", "Cập nhật", txtmaxdvt.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật đơn vị tính  thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        whenInsertSuccessed();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật đơn vị tính thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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