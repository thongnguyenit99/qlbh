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
    public partial class CapNhatBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        CapNhatBoPhanBUS CapNhatBoPhanBUS = new CapNhatBoPhanBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        string check;
        public CapNhatBoPhan(string vt)
        {
            InitializeComponent();
            check = vt;
            if (check == "-1")
            {
                this.Text = "Thêm Bộ Phận";
                txtmabp.Text = CapNhatBoPhanBUS.DeNghiMaBoPhan();
            }
            else
            {
                DataTable dt = CapNhatBoPhanBUS.LayThongTinDonViTinhTheoMa(check);
                txtmabp.Text = check;
                txtmabp.ReadOnly = true;
                txttenbp.Text = dt.Rows[0]["TenBP"].ToString();
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
                if (txtmabp.Text != "" && txttenbp.Text != "")
                {
                    // kiểm tra mã ton tai
                    if (!CapNhatBoPhanBUS.KiemTraMaBoPhanTonTai(txtmabp.Text))
                    {
                        // thêm
                        if (CapNhatBoPhanBUS.ThemDonViTinhBTN(txtmabp.Text, txttenbp.Text, txtghichu.Text, ckconquanly.Checked.ToString()) > 0)
                        {
                            try
                            {
                                NhatKyHeThongBUS.ThemNhatKyHeThong("Bộ Phận", "Thêm", txtmabp.Text);
                            }
                            catch
                            {

                            }
                            MessageBox.Show("Thêm bộ phận thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            whenInsertSuccessed();
                        }
                        else
                        {
                            MessageBox.Show("Thêm bộ phận thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (txttenbp.Text != "")
                {
                    // cap nhật
                    if (CapNhatBoPhanBUS.CapNhatDonViTinhBTN(txtmabp.Text, txttenbp.Text, txtghichu.Text, ckconquanly.Checked.ToString()) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Bộ Phận", "Cập nhật", txtmabp.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật bộ phận  thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        whenInsertSuccessed();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật bộ phận thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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