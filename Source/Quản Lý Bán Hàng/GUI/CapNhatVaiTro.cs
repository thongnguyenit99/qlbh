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
using Quan_Ly_Ban_Hang.Properties;
using DevExpress.XtraReports.Configuration;
using DevExpress.XtraEditors.Repository;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class CapNhatVaiTro : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InsertDone();
        public event InsertDone whenInsertSuccessed = null;
        CapNhaVaiTroBUS capNhaVaiTroBUS = new CapNhaVaiTroBUS();
        NhatKyHeThongBUS nhatKyHeThongBUS = new NhatKyHeThongBUS();
        DataTable dt = new DataTable();
        int vt = 0;
        int pl = 0;
        int id1;
        public CapNhatVaiTro(int check, int id)
        {
            InitializeComponent();
            vt = id;
            pl = check;
            if( check == - 1)// thêm
            {
                labelControl1.Text = "Thêm Vai Trò";
                txtma.Text = capNhaVaiTroBUS.DeCuMaVT(ref id1);
                gridControl1.DataSource = capNhaVaiTroBUS.LayBangPhanQuyenAdmin();
                cktrogiup.Enabled = false;
                ckhethong.Checked = true;
                ckchucnang.Checked = true;
                ckdanhmuc.Checked = true;
            }
            else // cap nhat
            {
                if(id == 1)
                {
                    gridView1.OptionsBehavior.ReadOnly = true;
                    txtma.ReadOnly = true;
                    txtten.ReadOnly = true;
                    txtdiengiai.ReadOnly = true;
                    ckconquanly.Enabled = false;
                }
                // thanh checkbox để chọn
                dt = capNhaVaiTroBUS.LayMenuBarID(vt);
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    if (int.Parse(dt.Rows[i]["MeNuBarId"].ToString()) == 1)
                    {
                        if(dt.Rows[i]["TrangThai"].ToString() == "True")
                            ckhethong.Checked = true;
                    }
                    if (int.Parse(dt.Rows[i]["MeNuBarId"].ToString()) == 2)
                    {

                        if (dt.Rows[i]["TrangThai"].ToString() == "True")
                            ckdanhmuc.Checked = true;
                    }
                    if (int.Parse(dt.Rows[i]["MeNuBarId"].ToString()) == 3)
                    {
                        if (dt.Rows[i]["TrangThai"].ToString() == "True")
                            ckchucnang.Checked = true;
                    }
                }
                dt = capNhaVaiTroBUS.LayThongTinVaiTro(id);
                txtma.Text = dt.Rows[0]["MaVT"].ToString();
                txtten.Text = dt.Rows[0]["RoleName"].ToString();
                txtdiengiai.Text = dt.Rows[0]["DescriptionName"].ToString();
                txtma.ReadOnly = true;
                gridControl1.DataSource = capNhaVaiTroBUS.LayBangPhanQuyen(id);
                cktrogiup.Enabled = false;
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (vt != 1)
            {
                if (pl == -1)// thêm
                {
                    if (txtma.Text != "" && txtten.Text != "")
                    {
                        if (capNhaVaiTroBUS.KiemTraVaiTroTonTai(txtten.Text))
                        {
                            MessageBox.Show("Tên vai trò đã tồn tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // them vai trò
                            if (capNhaVaiTroBUS.ThemVaiTro(txtma.Text, txtten.Text, txtdiengiai.Text, ckconquanly.Checked) > 0)
                            {
                                try
                                {
                                    nhatKyHeThongBUS.ThemNhatKyHeThong("Phân quyền", "Thêm vai trò", txtma.Text);
                                }
                                catch
                                {

                                }
                                // thêm vao rolemenubar
                                if (ckhethong.Checked)
                                {
                                    capNhaVaiTroBUS.ThemQuyenMotChucNangTrenThanhMeNu(id1 + 1, 1, 1);
                                }
                                else
                                {
                                    capNhaVaiTroBUS.ThemQuyenMotChucNangTrenThanhMeNu(id1 + 1, 1, 0);
                                }
                                if (ckdanhmuc.Checked)
                                {
                                    capNhaVaiTroBUS.ThemQuyenMotChucNangTrenThanhMeNu(id1 + 1, 2, 1);
                                }
                                else
                                {
                                    capNhaVaiTroBUS.ThemQuyenMotChucNangTrenThanhMeNu(id1 + 1, 1, 0);
                                }
                                if (ckchucnang.Checked)
                                {
                                    capNhaVaiTroBUS.ThemQuyenMotChucNangTrenThanhMeNu(id1 + 1, 3, 1);
                                }
                                else
                                {
                                    capNhaVaiTroBUS.ThemQuyenMotChucNangTrenThanhMeNu(id1 + 1, 1, 0);
                                }
                                capNhaVaiTroBUS.ThemQuyenMotChucNangTrenThanhMeNu(id1 + 1, 4, 1);
                                // Thêm bảng phân quyền
                                for (int i = 0; i < gridView1.RowCount; i++)
                                {
                                    capNhaVaiTroBUS.ThemBangPhanQuyen(id1 + 1, i + 1, bool.Parse(gridView1.GetRowCellValue(i, "TruyCap").ToString()), bool.Parse(gridView1.GetRowCellValue(i, "Them").ToString()),
                                         bool.Parse(gridView1.GetRowCellValue(i, "Sua").ToString()), bool.Parse(gridView1.GetRowCellValue(i, "Xoa").ToString()), bool.Parse(gridView1.GetRowCellValue(i, "In_DL").ToString()),
                                          bool.Parse(gridView1.GetRowCellValue(i, "Nhap").ToString()), bool.Parse(gridView1.GetRowCellValue(i, "Xuat").ToString()));
                                }
                                whenInsertSuccessed();
                                txtma.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Thêm vai trò thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu không được rỗng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else// update
                {
                    if (txtten.Text != "")
                    {
                        // update vai trò
                        if (capNhaVaiTroBUS.CapNhatVaiTro(txtma.Text, txtten.Text, txtdiengiai.Text, ckconquanly.Checked) > 0)
                        {

                            if (ckhethong.Checked)
                            {
                                capNhaVaiTroBUS.UpadateRoleMeNuBar(vt, 1, 1);
                            }
                            else
                            {
                                capNhaVaiTroBUS.UpadateRoleMeNuBar(vt, 1, 0);
                            }
                            if (ckdanhmuc.Checked)
                            {
                                capNhaVaiTroBUS.UpadateRoleMeNuBar(vt, 2, 1);
                            }
                            else
                            {
                                capNhaVaiTroBUS.UpadateRoleMeNuBar(vt, 2, 0);
                            }
                            if (ckchucnang.Checked)
                            {
                                capNhaVaiTroBUS.UpadateRoleMeNuBar(vt, 3, 1);
                            }
                            else
                            {
                                capNhaVaiTroBUS.UpadateRoleMeNuBar(vt, 3, 0);
                            }
                            // cập nhật quyền
                            for (int i = 0; i < gridView1.RowCount; i++)
                            {
                                capNhaVaiTroBUS.CapNhatBangPhanQuyen(vt, i + 1, bool.Parse(gridView1.GetRowCellValue(i, "TruyCap").ToString()), bool.Parse(gridView1.GetRowCellValue(i, "Them").ToString()),
                                     bool.Parse(gridView1.GetRowCellValue(i, "Sua").ToString()), bool.Parse(gridView1.GetRowCellValue(i, "Xoa").ToString()), bool.Parse(gridView1.GetRowCellValue(i, "In_DL").ToString()),
                                      bool.Parse(gridView1.GetRowCellValue(i, "Nhap").ToString()), bool.Parse(gridView1.GetRowCellValue(i, "Xuat").ToString()));
                            }
                            txtten.Text = "";
                            try
                            {
                                nhatKyHeThongBUS.ThemNhatKyHeThong("Phân quyền", "Cập nhật vai trò", txtma.Text);
                            }
                            catch
                            {

                            }
                            whenInsertSuccessed();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ten vai trò không được rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Không thể sửa đổi quyền admin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (vt == 1)
                MessageBox.Show("Bạn Không thể sửa đổi quyền admin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void SetCheckBox(int start, int end, bool check)
        {
            for (int i = start; i <= end; i++)
            {
                gridView1.SetRowCellValue(i, "TruyCap", check);
                gridView1.SetRowCellValue(i, "Them", check);
                gridView1.SetRowCellValue(i, "Sua", check);
                gridView1.SetRowCellValue(i, "Xoa", check);
                gridView1.SetRowCellValue(i, "In_DL", check);
                gridView1.SetRowCellValue(i, "Nhap", check);
                gridView1.SetRowCellValue(i, "Xuat", check);
            }
        }

        private void ckhethong_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckBox(0, 7, ckhethong.Checked);

        }
        private void ckdanhmuc_CheckedChanged(object sender, EventArgs e)
        {
             SetCheckBox(8, 19, ckdanhmuc.Checked);
        }

        private void ckchucnang_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckBox(20, 30, ckchucnang.Checked);
        }
        private void ThongBaoAdmin()
        {
            if (vt == 1)
            {
                MessageBox.Show("Bạn Không thể sửa đổi quyền admin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ckhethong_Click(object sender, EventArgs e)
        {
            ThongBaoAdmin();
        }

        private void ckdanhmuc_Click(object sender, EventArgs e)
        {
            ThongBaoAdmin();
        }

        private void ckchucnang_Click(object sender, EventArgs e)
        {
            ThongBaoAdmin();
        }
    }
}