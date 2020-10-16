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
    public partial class NhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        NhaCungCapBUS NhaCungCapBUS = new NhaCungCapBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public NhaCungCap()
        {
            InitializeComponent();
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhà Cung Cấp", "Xem", "");
            }
            catch
            {

            }
        }
        private void LoadData()
        {
            // gridview
            grvctnhacungcap.DataSource = NhaCungCapBUS.LayThongTinNhaCungCap();
        }
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            uc_DanhMuc1.EnnableFunction(roleform);
            LoadData();
            uc_DanhMuc1.Controls["ucbtnnaplai"].Click += NapLaiDL;
            uc_DanhMuc1.Controls["ucbtnthem"].Click += ThemNCC;
            uc_DanhMuc1.Controls["ucbtnsua"].Click += SuaNCC;
            uc_DanhMuc1.Controls["ucbtnxoa"].Click += XoaNhaCungCap;
            uc_DanhMuc1.Controls["ucbtndong"].Click += DongBieuMau;
            uc_DanhMuc1.Controls["ucbtnxuat"].Click += XuatFile;
        }
        private void NapLaiDL(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhà Cung Cấp", "Nạp Lại Dữ Liệu", "");
            }
            catch
            {

            }
            LoadData();
        }
        private void ThemNCC(object sender, EventArgs e)
        {
            try
            {
                CapNhatNhaCungCap capNhatNhaCungCap = new CapNhatNhaCungCap("-1");
                capNhatNhaCungCap.whenInsertSuccessed += LoadData;
                capNhatNhaCungCap.ShowDialog();
            }
            catch { }
        }
        private void SuaNCC(object sender, EventArgs e)
        {
            int temp = 0;
            try
            {
                grvnhacungcap.GetRowCellValue(grvnhacungcap.FocusedRowHandle, "MaNCC").ToString();
            }
            catch
            {
                temp = 1;
            }
            if (temp == 0)
            {
                CapNhatNhaCungCap capNhatNhaCungCap = new CapNhatNhaCungCap(grvnhacungcap.GetRowCellValue(grvnhacungcap.FocusedRowHandle, "MaNCC").ToString());
                capNhatNhaCungCap.whenInsertSuccessed += LoadData;
                capNhatNhaCungCap.ShowDialog();
            }
        }
        private void XoaNhaCungCap(object sender, EventArgs e)
        {
            if (grvnhacungcap.GetRowCellValue(grvnhacungcap.FocusedRowHandle, "MaNCC") != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (NhaCungCapBUS.XoaNhaCungCap(grvnhacungcap.GetRowCellValue(grvnhacungcap.FocusedRowHandle, "MaNCC").ToString()) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Nhà Cung Cấp", "Xóa", grvnhacungcap.GetRowCellValue(grvnhacungcap.FocusedRowHandle, "MaNCC").ToString());
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
                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhà Cung Cấp", "Thoát", "");
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
                try
                {
                    grvnhacungcap.ExportToXlsx(fbd.SelectedPath + "\\nhacungcap" + i + ".xlsx");
                    NhatKyHeThongBUS.ThemNhatKyHeThong("Nhà Cung Cấp", "Xuất file xlsx", "nhacungcap" + i + ".xlsx");
                    i++;
                }
                catch
                {

                }
            }
        }
    }
}