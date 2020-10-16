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
    public partial class KhoHang : DevExpress.XtraEditors.XtraForm
    {
        KhoHangBUS khoHangBUS = new KhoHangBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        private void LoadData()
        {
            grvctkhohang.DataSource = khoHangBUS.LayThongTinKhoHang();
        }
        public KhoHang()
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Kho Hàng", "Xem", "");
            }
            catch
            {

            }
            InitializeComponent();
            uc_DanhMuc1.Controls["ucbtnnaplai"].Click += NapLaiDL;
            uc_DanhMuc1.Controls["ucbtnthem"].Click += ThemKhoHang;
            uc_DanhMuc1.Controls["ucbtnsua"].Click += SuaThongTinKhoHang;
            uc_DanhMuc1.Controls["ucbtnxoa"].Click += XoaKhoHang;
            uc_DanhMuc1.Controls["ucbtndong"].Click += DongBieuMau;
            uc_DanhMuc1.Controls["ucbtnxuat"].Click += XuatFile;
            grvctkhohang.DataSource = khoHangBUS.LayThongTinKhoHang();
        }

        private void NapLaiDL(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ThemKhoHang(object sender, EventArgs e)
        {
            CapNhatKhoHang capNhatKhoHang = new CapNhatKhoHang("-1");
            capNhatKhoHang.whenInsertSuccessed += LoadData;
            capNhatKhoHang.ShowDialog();
        }
        private void SuaThongTinKhoHang(object sender, EventArgs e)
        {
            if (grvkhohang.GetRowCellValue(grvkhohang.FocusedRowHandle, "Mã").ToString() != null)
            {
                CapNhatKhoHang capNhatKhoHang = new CapNhatKhoHang(grvkhohang.GetRowCellValue(grvkhohang.FocusedRowHandle, "Mã").ToString());
                capNhatKhoHang.whenInsertSuccessed += LoadData;
                capNhatKhoHang.ShowDialog();
            }
        }
        private void XoaKhoHang(object sender, EventArgs e)
        {
            if(grvkhohang.GetRowCellValue(grvkhohang.FocusedRowHandle, "Mã").ToString() != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (khoHangBUS.XoaThongTinKhoHang(grvkhohang.GetRowCellValue(grvkhohang.FocusedRowHandle, "Mã").ToString()) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Kho Hàng", "Xóa", grvkhohang.GetRowCellValue(grvkhohang.FocusedRowHandle, "Mã").ToString());
                        }
                        catch
                        {

                        }
                        LoadData();
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
                NhatKyHeThongBUS.ThemNhatKyHeThong("Kho Hàng", "Đóng", "");
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
                grvkhohang.ExportToXlsx(fbd.SelectedPath + "\\khohang" + i + ".xlsx");
                try
                {
                    NhatKyHeThongBUS.ThemNhatKyHeThong("Kho Hàng", "Xuât file xlsx", "khohang" + i + ".xlsx");
                }
                catch
                {

                }
                i++;
            }
        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            uc_DanhMuc1.EnnableFunction(roleform);
        }
    }
}