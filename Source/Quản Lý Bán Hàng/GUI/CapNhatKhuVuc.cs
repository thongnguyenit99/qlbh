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
    public partial class CapNhatKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        CapNhatKhuVucBUS capNhatKhuVucBUS = new CapNhatKhuVucBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        DataTable dt = new DataTable();
        int vt;
        public CapNhatKhuVuc(int check)
        {
            vt = check;
            InitializeComponent();
            if (check == -1)
            {
                this.Text = "Thêm Khu Vực";
                txtma.Text = capNhatKhuVucBUS.DeCuMaKV();
                ckconquanly.Checked = true;
            }
            else
            {
                this.Text = "Cập Nhật Khu Vực";
                // lấy thông tin khu vực cần cập nhật
                dt = capNhatKhuVucBUS.LayThongTinMotKhuVucTheoID(check);
                if (dt.Rows.Count > 0)
                {
                    txtma.Text = dt.Rows[0]["MaKV"].ToString();
                    txtma.ReadOnly = true;
                    txtten.Text = dt.Rows[0]["TenKV"].ToString();
                    txtghichu.Text = dt.Rows[0]["GhiChu"].ToString();
                    if (dt.Rows[0]["ConQuanLy"].ToString().ToString() == "True")
                    {
                        ckconquanly.Checked = true;
                    }
                }
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                if (txtma.Text != "" && txtten.Text != "")
                {
                    // Kiểm tra mã Khu vực đã tồn tại
                    if (capNhatKhuVucBUS.KiemTraMaKhuVucDaTonTai(txtma.Text) == 0)
                    {
                        // Thêm khu vực
                        if (capNhatKhuVucBUS.ThemKhuVuc(txtma.Text, txtten.Text, txtghichu.Text, ckconquanly.Checked.ToString()) > 0)
                        {
                            try
                            {
                                NhatKyHeThongBUS.ThemNhatKyHeThong("Khu Vực", "Thêm", txtma.Text);
                            }
                            catch
                            {

                            }
                            MessageBox.Show("Thêm khu vực thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtma.Text = "";
                            whenInsertSuccessed();
                        }
                        else
                        {
                            MessageBox.Show("Thêm khu vực thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã khu vực này đã tồn tại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else //update
            {
                if (txtten.Text != "")
                {
                    // cap nhật khu vực
                    if (capNhatKhuVucBUS.CapNhatKhuVucBTN(txtma.Text, txtten.Text, txtghichu.Text, ckconquanly.Checked.ToString()) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Khu Vực", "Cập nhật", txtma.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật khu vực thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        whenInsertSuccessed();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khu vực thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}