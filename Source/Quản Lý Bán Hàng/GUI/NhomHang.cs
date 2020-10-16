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
    public partial class NhomHang : DevExpress.XtraEditors.XtraForm
    {
        NhomHangBUS nhomHangBUS = new NhomHangBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public NhomHang()
        {
            InitializeComponent();
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhóm Hàng", "Xem", "");
            }
            catch
            {

            }
        }
        private void Loadata()
        {
            grvnhomhang.DataSource = nhomHangBUS.LayThongTinNhomHang();
        }
        private void NhomHang_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            uc_DanhMuc1.EnnableFunction(roleform);

            Loadata();
            uc_DanhMuc1.Controls["ucbtnnaplai"].Click += NapLaiDL;
            uc_DanhMuc1.Controls["ucbtnthem"].Click += ThemNhomHang;
            uc_DanhMuc1.Controls["ucbtnsua"].Click += SuaThongTinNhomHang;
            uc_DanhMuc1.Controls["ucbtnxoa"].Click += XoaNhomHang;
            uc_DanhMuc1.Controls["ucbtndong"].Click += DongBieuMau;
            uc_DanhMuc1.Controls["ucbtnxuat"].Click += XuatFile;

        }
        int i = 0;
        private void XuatFile(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                try
                {
                    grvnhomhang_root.ExportToXlsx(fbd.SelectedPath + "\\nhomhang" + i + ".xlsx");
                    i++;
                    NhatKyHeThongBUS.ThemNhatKyHeThong("Nhóm Hàng", "Xuất file xlsx", "nhomhang" + i + ".xlsx");
                }
                catch
                {

                }
            }
        }
        private void NapLaiDL(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhóm Hàng", "Nạp lại dữ liệu", "");
            }
            catch
            {

            }
            Loadata();
        }
        private void ThemNhomHang(object sender, EventArgs e)
        {
            CapNhatNhomHang capNhatNhomHang = new CapNhatNhomHang("-1");
            capNhatNhomHang.whenInsertSuccessed += Loadata;
            capNhatNhomHang.ShowDialog();
        }
        private void SuaThongTinNhomHang(object sender, EventArgs e)
        {
            CapNhatNhomHang capNhatNhomHang = new CapNhatNhomHang(grvnhomhang_root.GetRowCellValue(grvnhomhang_root.FocusedRowHandle, "Mã").ToString());
            capNhatNhomHang.whenInsertSuccessed += Loadata;
            capNhatNhomHang.ShowDialog();
        }
        private void DongBieuMau(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhóm Hàng", "Thoát", "");
            }
            catch
            {

            }
            this.Close();
        }
        private void XoaNhomHang(object sender, EventArgs e)
        {
            if (grvnhomhang_root.GetRowCellValue(grvnhomhang_root.FocusedRowHandle, "Mã").ToString() != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (nhomHangBUS.XoaNhomHang(grvnhomhang_root.GetRowCellValue(grvnhomhang_root.FocusedRowHandle, "Mã").ToString()) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Nhóm Hàng", "Xóa", grvnhomhang_root.GetRowCellValue(grvnhomhang_root.FocusedRowHandle, "Mã").ToString());
                        }
                        catch
                        {

                        }
                        Loadata();
                    }
                    else
                    {
                        MessageBox.Show(GlobalVar.loisql, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}