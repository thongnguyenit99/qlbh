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
    public partial class CapNhatTyGia : DevExpress.XtraEditors.XtraForm
    {
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        string check;
        DataTable dt;
        CapNhatTyGiaBUS capNhatTyGiaBUS = new CapNhatTyGiaBUS();
        public CapNhatTyGia(string vt)
        {
            InitializeComponent();
            txtqdtygia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            txtqdtygia.Properties.Mask.EditMask = "n2";
            txtqdtygia.Properties.Mask.UseMaskAsDisplayFormat = true;
            check = vt;
            if (vt == "-1")// thêm
            {
                this.Text = "Thêm Tỷ Giá";
            }
            else 
            {
                dt = capNhatTyGiaBUS.LayThongTinBangTyGiaTheoMa(vt);
                txtma.Text = dt.Rows[0]["MaTG"].ToString();
                txtma.ReadOnly = true;
                txtten.Text = dt.Rows[0]["TenTG"].ToString();
                txtqdtygia.Text = dt.Rows[0]["TyGiaQD"].ToString();
                if (dt.Rows[0]["Conquanly"].ToString() == "True")
                {
                    ckconquanly.Checked = true;
                }
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
                if (txtten.Text != "" && txtma.Text != "")
                {
                    // Kiểm tra MaKH đã tồn tại
                    if (capNhatTyGiaBUS.KiemTraMaTGTonTai(txtma.Text) == 0)
                    {
                        int temp = 0;
                        try
                        {
                            temp = capNhatTyGiaBUS.ThemTyGiaBTN(txtma.Text, txtten.Text, float.Parse(txtqdtygia.Text), ckconquanly.Checked.ToString());
                            if (temp > 0)
                            {
                                try
                                {
                                    NhatKyHeThongBUS.ThemNhatKyHeThong("Tỷ Giá", "Thêm", txtma.Text);
                                }
                                catch
                                {

                                }
                                MessageBox.Show("Thêm tỷ giá thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                whenInsertSuccessed();
                            }
                            else
                            {
                                MessageBox.Show("Thêm tỷ giá  thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Thêm tỷ giá  thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("Mã tỷ giá đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    temp = capNhatTyGiaBUS.CapNhatTyGiaBTN(txtma.Text, txtten.Text, float.Parse(txtqdtygia.Text), ckconquanly.Checked.ToString());
                    if (temp > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Tỷ Giá", "Cập nhật", txtma.Text);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Cập nhật tỷ giá thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        whenInsertSuccessed();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật tỷ giá thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thêm thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}