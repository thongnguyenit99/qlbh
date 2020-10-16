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

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class NhatKyHeThong : DevExpress.XtraEditors.XtraForm
    {
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        private void LoadData()
        {
            grvctnhatky.DataSource = NhatKyHeThongBUS.LayThongTinNhatKy();
        }
        public NhatKyHeThong()
        {
            InitializeComponent();
            LoadData();
            columdatetime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            columdatetime.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            columdatetime.Properties.Mask.UseMaskAsDisplayFormat = true;
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhật Ký Hệ Thống", "Xem", "");
            }
            catch
            {

            }
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvrootnhatky.GetRowCellValue(grvrootnhatky.FocusedRowHandle, "MaND").ToString() != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        if(NhatKyHeThongBUS.XoaThongTinNhatKy(grvrootnhatky.GetRowCellValue(grvrootnhatky.FocusedRowHandle, "MaND").ToString()) > 0)
                        {
                            try
                            {
                                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhật Ký Hệ Thống", "Xóa", grvrootnhatky.GetRowCellValue(grvrootnhatky.FocusedRowHandle, "MaND").ToString());
                            }
                            catch
                            {

                            }
                            LoadData();
                        }
                    }
                }
            }
            catch
            {

            }
        }
        int j = 0;
        private void btnluu_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                grvrootnhatky.ExportToHtml(fbd.SelectedPath + "\\nhakyhethong" + j + ".html");
                i++;
            }
        }

        private void btndoc_Click(object sender, EventArgs e)
        {

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Nhật Ký Hệ Thống", "Thoát", "");
            }
            catch
            {

            }
            this.Close();
        }
        int i = 0;
        private void btnxuat_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                try
                {
                    NhatKyHeThongBUS.ThemNhatKyHeThong("Nhật Ký Hệ Thống", "Xuất file excel", "nhakyhethong" + i + ".xlsx");
                    grvrootnhatky.ExportToXlsx(fbd.SelectedPath + "\\nhakyhethong" + i + ".xlsx");
                    i++;
                }
                catch
                {

                }
              
            }
        }
    }
}