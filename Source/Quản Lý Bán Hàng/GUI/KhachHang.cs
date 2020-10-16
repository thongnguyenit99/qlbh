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
using Quan_Ly_Ban_Hang.DTO;
using Quan_Ly_Ban_Hang.BUS;
using Quan_Ly_Ban_Hang.GUI;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class KhachHang : DevExpress.XtraEditors.XtraForm
    {
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public KhachHang()
        {
            InitializeComponent();
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Khách Hàng", "Xem", "");
            }
            catch
            {

            }
        }
        private void LoadData()
        {
            gridView1.GroupPanelText = "Kéo cột vào đây";
            gridControl1.DataSource = khachHangBUS.LayThongTinKhachHang();
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            uc_DanhMuc1.EnnableFunction(roleform);
            // uc
            uc_DanhMuc1.Controls["ucbtnthem"].Click += ThemKhachHang;
            uc_DanhMuc1.Controls["ucbtnsua"].Click += SuaKhachHang;
            uc_DanhMuc1.Controls["ucbtnnaplai"].Click += TaiLaiTrang;
            uc_DanhMuc1.Controls["ucbtnxoa"].Click += XoaKhachHang;
            uc_DanhMuc1.Controls["ucbtndong"].Click += DongBieuMau;
            uc_DanhMuc1.Controls["ucbtnxuat"].Click += XuatDuLieu;
            LoadData();
        }
        int i = 0;
        private void XuatDuLieu(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                try
                {
                    NhatKyHeThongBUS.ThemNhatKyHeThong("Khách Hàng", "Xuất file xlsx", "KhuVuc" + i + ".xlsx");
                    gridView1.ExportToXlsx(fbd.SelectedPath + "\\KhuVuc" + i + ".xlsx");
                    i++;
                }
                catch
                {

                }
            }
        }

        private void DongBieuMau(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XoaKhachHang(object sender, EventArgs e)
        {
            string temp = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa khách hàng co mã là " + temp + " này không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if(khachHangBUS.XoaKhachHang(temp) > 0)
                {
                    try
                    {
                        NhatKyHeThongBUS.ThemNhatKyHeThong("Khách Hàng", "Xóa", temp);
                    }
                    catch
                    {

                    }
                    MessageBox.Show("Xóa khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else 
                {
                    MessageBox.Show("Xóa khách hàng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(GlobalVar.loisql, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 
        private void SuaKhachHang(object sender, EventArgs e)
        {
            try
            {
                CapNhatKhachHang capNhatKhachHang = new CapNhatKhachHang(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString());
                capNhatKhachHang.whenInsertSuccessed += LoadData;
                capNhatKhachHang.ShowDialog();
            }
            catch { }
        }

        private void TaiLaiTrang(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Khách Hàng", "Tải Lại", "");
            }
            catch
            {

            }
            LoadData();
        }

        private void ThemKhachHang(object sender, EventArgs e)
        {
            CapNhatKhachHang capNhatKhachHang = new CapNhatKhachHang("-1");
            capNhatKhachHang.whenInsertSuccessed += LoadData;
            capNhatKhachHang.ShowDialog();
        }
    }
}