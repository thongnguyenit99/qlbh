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
    public partial class NhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public NhanVien()
        {
            InitializeComponent();
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhân Viên", "Xem", "");
            }
            catch
            {

            }
        }
        private void LoadDaTa()
        {
            grvctnhanvien.DataSource = nhanVienBUS.LayThongTinNhanVien();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            uc_DanhMuc1.EnnableFunction(roleform);
            uc_DanhMuc1.Controls["ucbtnnaplai"].Click += NapLaiDL;
            uc_DanhMuc1.Controls["ucbtnthem"].Click += ThemNhanVien;
            uc_DanhMuc1.Controls["ucbtnsua"].Click += SuaNhanVien;
            uc_DanhMuc1.Controls["ucbtnxoa"].Click += XoaNhanVien;
            uc_DanhMuc1.Controls["ucbtndong"].Click += DongBieuMau;
            uc_DanhMuc1.Controls["ucbtnxuat"].Click += XuatFile;
            LoadDaTa();
        }

        private void NapLaiDL(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhân Viên", "Nạp lại ", "");
            }
            catch
            {

            }
            LoadDaTa();  
        }
        private void ThemNhanVien(object sender, EventArgs e)
        {
            CapNhatNhanVien capNhatNhanVien = new CapNhatNhanVien("-1");
            capNhatNhanVien.whenInsertSuccessed += LoadDaTa;
            capNhatNhanVien.ShowDialog();
        }
        private void SuaNhanVien(object sender, EventArgs e)
        {
            if (grvnhanvien.GetRowCellValue(grvnhanvien.FocusedRowHandle, "Mã").ToString() != null)
            {
                CapNhatNhanVien capNhatNhanVien = new CapNhatNhanVien(grvnhanvien.GetRowCellValue(grvnhanvien.FocusedRowHandle, "Mã").ToString());
                capNhatNhanVien.whenInsertSuccessed += LoadDaTa;
                capNhatNhanVien.ShowDialog();
            }
        }
        private void XoaNhanVien(object sender, EventArgs e)
        {
            if (grvnhanvien.GetRowCellValue(grvnhanvien.FocusedRowHandle, "Mã").ToString() != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (nhanVienBUS.XoaNhanVien(grvnhanvien.GetRowCellValue(grvnhanvien.FocusedRowHandle, "Mã").ToString()) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Nhân Viên", "Xóa", grvnhanvien.GetRowCellValue(grvnhanvien.FocusedRowHandle, "Mã").ToString());
                        }
                        catch
                        {

                        }
                        LoadDaTa();
                    }
                    else
                    {
                        MessageBox.Show(GlobalVar.loisql, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void DongBieuMau(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhân Viên", "Thoát", "");
            }
            catch
            {

            }
            this.Close();
        }
        int i = 0;
        private void XuatFile(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                grvnhanvien.ExportToXlsx(fbd.SelectedPath + "\\nhanvien" + i + ".xlsx");
                i++;
                try
                {
                    NhatKyHeThongBUS.ThemNhatKyHeThong("Nhân Viên", "Xuất file xlsx", "nhanvien" + i + ".xlsx");
                }
                catch
                {

                }
            }
        }

        private void uc_DanhMuc1_Load(object sender, EventArgs e)
        {

        }
    }
}