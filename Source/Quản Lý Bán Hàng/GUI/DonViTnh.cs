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
    public partial class DonViTnh : DevExpress.XtraEditors.XtraForm
    {
        DonViTinhBUS donViTinhBUS = new DonViTinhBUS();
        NhatKyHeThongBUS nhatKyHeThongBUS = new NhatKyHeThongBUS();

        public DonViTnh()
        {
            try
            {
                nhatKyHeThongBUS.ThemNhatKyHeThong("Đơn vị tính", "Xem", "");
            }
            catch
            {

            }
            InitializeComponent();
        }
        private void LoatData()
        {
            // grid control
            grvctdonvitinh.DataSource = donViTinhBUS.LayDuLieuBangDonVi();
        }
        private void DonViTnh_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            uc_DanhMuc1.EnnableFunction(roleform);
            LoatData();
            // event
            uc_DanhMuc1.Controls["ucbtnnaplai"].Click += NapLaiDL;
            uc_DanhMuc1.Controls["ucbtnthem"].Click += ThemDonViTinh;
            uc_DanhMuc1.Controls["ucbtnsua"].Click += SuaDonViTinh;
            uc_DanhMuc1.Controls["ucbtnxoa"].Click += XoaDonViTinh;
            uc_DanhMuc1.Controls["ucbtndong"].Click += DongBieuMau;
            uc_DanhMuc1.Controls["ucbtnxuat"].Click += XuatFile;
        }

        private void NapLaiDL(object sender, EventArgs e)
        {
            try
            {
                nhatKyHeThongBUS.ThemNhatKyHeThong("Đơn vị tính", "Nạp lại", "");
            }
            catch
            {

            }
            LoatData();
        }

        private void XoaDonViTinh(object sender, EventArgs e)
        {
            if (grvdonvitinh.GetRowCellValue(grvdonvitinh.FocusedRowHandle, "Mã").ToString() != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (donViTinhBUS.XoaNhaCungCap(grvdonvitinh.GetRowCellValue(grvdonvitinh.FocusedRowHandle, "Mã").ToString()) > 0)
                    {
                        try
                        {
                            nhatKyHeThongBUS.ThemNhatKyHeThong("Đơn vị tính", "Xóa", grvdonvitinh.GetRowCellValue(grvdonvitinh.FocusedRowHandle, "Mã").ToString());
                        }
                        catch
                        {

                        }
                        LoatData();
                    }
                    else
                    {
                        MessageBox.Show(GlobalVar.loisql, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ThemDonViTinh(object sender, EventArgs e)
        {
            CapNhatDonViTinh capNhatDonViTinh = new CapNhatDonViTinh("-1");
            capNhatDonViTinh.whenInsertSuccessed += LoatData;
            capNhatDonViTinh.ShowDialog();
        }
        private void SuaDonViTinh(object sender, EventArgs e)
        {
            if (grvdonvitinh.GetRowCellValue(grvdonvitinh.FocusedRowHandle, "Mã").ToString() != null)
            {
                CapNhatDonViTinh capNhatDonViTinh = new CapNhatDonViTinh(grvdonvitinh.GetRowCellValue(grvdonvitinh.FocusedRowHandle, "Mã").ToString());
                capNhatDonViTinh.whenInsertSuccessed += LoatData;
                capNhatDonViTinh.ShowDialog();
            }
        }
        private void DongBieuMau(object sender, EventArgs e)
        {
            try
            {
                nhatKyHeThongBUS.ThemNhatKyHeThong("Đơn vị tính", "Xem", "");
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
                    nhatKyHeThongBUS.ThemNhatKyHeThong("Đơn vị tính", "Xuất file xlsx", "donvitinh" + i + ".xlsx");
                    grvdonvitinh.ExportToXlsx(fbd.SelectedPath + "\\donvitinh" + i + ".xlsx");
                    i++;
                }
                catch
                {

                }
            }
        }
    }
}