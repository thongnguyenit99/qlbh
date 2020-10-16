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
    public partial class TyGia : DevExpress.XtraEditors.XtraForm
    {
        TyGiaBUS tyGiaBUS = new TyGiaBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public TyGia()
        {
            InitializeComponent();
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Tỷ Giá", "Xem", "");
            }
            catch
            {

            }
        }


        private void LoadDaTa()
        {
            grvcttygia.DataSource = tyGiaBUS.LayThongTinBangTyGia();
        }
        private void TyGia_Load(object sender, EventArgs e)
        {
            LoadDaTa();
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            uc_DanhMuc1.EnnableFunction(roleform);
            uc_DanhMuc1.Controls["ucbtnnaplai"].Click += NapLaiDL;
            uc_DanhMuc1.Controls["ucbtnthem"].Click += ThemTyGia;
            uc_DanhMuc1.Controls["ucbtnsua"].Click += SuaThongTinTyGia;
            uc_DanhMuc1.Controls["ucbtnxoa"].Click += XoaTyGia;
            uc_DanhMuc1.Controls["ucbtndong"].Click += DongBieuMau;
            uc_DanhMuc1.Controls["ucbtnxuat"].Click += XuatFile;
        }

        private void NapLaiDL(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Tỷ Giá", "Nạp Lại", "");
            }
            catch
            {

            }
            LoadDaTa();
        }
        private void ThemTyGia(object sender, EventArgs e)
        {
            CapNhatTyGia capNhatTyGia = new CapNhatTyGia("-1");
            capNhatTyGia.whenInsertSuccessed += LoadDaTa;
            capNhatTyGia.ShowDialog();
        }
        private void SuaThongTinTyGia(object sender, EventArgs e)
        {
            if (grvtygia.GetRowCellValue(grvtygia.FocusedRowHandle, "Mã").ToString() != null)
            {
                CapNhatTyGia capNhatTyGia = new CapNhatTyGia(grvtygia.GetRowCellValue(grvtygia.FocusedRowHandle, "Mã").ToString());
                capNhatTyGia.whenInsertSuccessed += LoadDaTa;
                capNhatTyGia.ShowDialog();
            }
        }
        private void XoaTyGia(object sender, EventArgs e)
        {
            if (grvtygia.GetRowCellValue(grvtygia.FocusedRowHandle, "Mã").ToString() != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (tyGiaBUS.XoaTyGia(grvtygia.GetRowCellValue(grvtygia.FocusedRowHandle, "Mã").ToString()) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Tỷ Giá", "Xóa", grvtygia.GetRowCellValue(grvtygia.FocusedRowHandle, "Mã").ToString());
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
                NhatKyHeThongBUS.ThemNhatKyHeThong("Tỷ Giá", "Thoát", "");
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
                    grvtygia.ExportToXlsx(fbd.SelectedPath + "\\tygia" + i + ".xlsx");
                    i++;
                    NhatKyHeThongBUS.ThemNhatKyHeThong("Tỷ Giá", "Xuât file xlsx", "tygia" + i + ".xlsx");
                }
                catch
                {

                }
            }
        }
    }
}