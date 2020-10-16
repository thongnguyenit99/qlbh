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
    public partial class BoPhan : DevExpress.XtraEditors.XtraForm
    {
        BoPhanBUS boPhanBUS = new BoPhanBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        private void LoadData()
        {
            grvctbophan.DataSource = boPhanBUS.LayThongTinBoPhan();
        }
        public BoPhan()
        {
            InitializeComponent();

            LoadData();
            uc_DanhMuc1.Controls["ucbtnnaplai"].Click += NapLaiDL;
            uc_DanhMuc1.Controls["ucbtnthem"].Click += ThemBoPhan;
            uc_DanhMuc1.Controls["ucbtnsua"].Click += SuaThongTinBoPhan;
            uc_DanhMuc1.Controls["ucbtnxoa"].Click += XoaBoPhan;
            uc_DanhMuc1.Controls["ucbtndong"].Click += DongBieuMau;
            uc_DanhMuc1.Controls["ucbtnxuat"].Click += XuatFile;
        }

        private void BoPhan_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            uc_DanhMuc1.EnnableFunction(roleform);
        }
        private void NapLaiDL(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Bộ Phận", "Nạp lại", "");
            }
            catch
            {

            }
            LoadData();
        }
        private void ThemBoPhan(object sender, EventArgs e)
        {
            CapNhatBoPhan capNhatBoPhan = new CapNhatBoPhan("-1");
            capNhatBoPhan.whenInsertSuccessed += LoadData;
            capNhatBoPhan.ShowDialog();

        }
        private void SuaThongTinBoPhan(object sender, EventArgs e)
        {
            if(grvbophan.GetRowCellValue(grvbophan.FocusedRowHandle, "Mã").ToString() != null)
            {
                CapNhatBoPhan capNhatBoPhan = new CapNhatBoPhan(grvbophan.GetRowCellValue(grvbophan.FocusedRowHandle, "Mã").ToString());
                capNhatBoPhan.whenInsertSuccessed += LoadData;
                capNhatBoPhan.ShowDialog();
            }
        }
        private void XoaBoPhan(object sender, EventArgs e)
        {
            if (grvbophan.GetRowCellValue(grvbophan.FocusedRowHandle, "Mã") != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (boPhanBUS.XoaBoPhan(grvbophan.GetRowCellValue(grvbophan.FocusedRowHandle, "Mã").ToString()) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Bộ Phận", "Xóa", grvbophan.GetRowCellValue(grvbophan.FocusedRowHandle, "Mã").ToString());
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
                NhatKyHeThongBUS.ThemNhatKyHeThong("Bộ Phận", "Đóng", "");
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
                grvbophan.ExportToXlsx(fbd.SelectedPath + "\\bophan" + i + ".xlsx");
                i++;
            }
        }
    }
}