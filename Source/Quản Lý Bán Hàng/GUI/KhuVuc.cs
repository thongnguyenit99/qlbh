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
using System.IO;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class KhuVuc : DevExpress.XtraEditors.XtraForm
    {
        KhuVucBUS KhuVucBUS = new KhuVucBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public KhuVuc()
        {
            InitializeComponent();
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Khu Vực", "Xem", "");
            }
            catch
            {

            }
        }
        private void LoadData()
        {
            grvctkhuvuc.DataSource = KhuVucBUS.LayThongTinKhuVuc();
        }
        private void KhuVuc_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            uc_DanhMuc1.EnnableFunction(roleform);
            LoadData();
            // uccontrol
            uc_DanhMuc1.Controls["ucbtnthem"].Click += ThemKhuVuc;
            uc_DanhMuc1.Controls["ucbtnnaplai"].Click += NapLai;
            uc_DanhMuc1.Controls["ucbtnsua"].Click += SuaKhuVuc;
            uc_DanhMuc1.Controls["ucbtnxoa"].Click += XoaKhuVuc;
            uc_DanhMuc1.Controls["ucbtnxuat"].Click += XuatDuLieu;
            uc_DanhMuc1.Controls["ucbtndong"].Click += ThoatBieuMau;
        }

        private void ThoatBieuMau(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Khu Vực", "Thoát", "");
            }
            catch
            {

            }
            this.Close();
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
                    grvctkhuvuc.ExportToXlsx(fbd.SelectedPath + "\\KhuVuc" + i + ".xlsx");
                    i++;
                    NhatKyHeThongBUS.ThemNhatKyHeThong("Khu Vực", "Xuất Dữ liệu file xlsx", "KhuVuc" + i + ".xlsx");
                }
                catch
                {

                }
             
            }
        }

        private void XoaKhuVuc(object sender, EventArgs e)
        {
            try {
                string makv = grvkhuvuc.GetRowCellValue(grvkhuvuc.FocusedRowHandle, "MaKV").ToString();
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa khu vực có MaKV = " + makv + " ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (KhuVucBUS.XoaMotKhuVuc(makv) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Khu Vực", "Xóa", makv);
                        }
                        catch
                        {

                        }
                        MessageBox.Show("Xoa khu vực có id = " + makv + " thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else 
                    {
                        MessageBox.Show("Xoa khu vực có id = " + makv + " thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(GlobalVar.loisql, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadData();
                    }
                }
            }
            catch { }
        }

        private void SuaKhuVuc(object sender, EventArgs e)
        {
            string id = grvkhuvuc.GetRowCellValue(grvkhuvuc.FocusedRowHandle, "Id").ToString();
            CapNhatKhuVuc capNhatKhuVuc = new CapNhatKhuVuc(int.Parse(id));
            capNhatKhuVuc.whenInsertSuccessed += LoadData;
            capNhatKhuVuc.ShowDialog();
        }

        private void NapLai(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Khu Vực", "Nạp Lại", "");
            }
            catch
            {

            }
            LoadData();
        }

        private void ThemKhuVuc(object sender, EventArgs e)
        {
            CapNhatKhuVuc capNhatKhuVuc = new CapNhatKhuVuc(-1);
            capNhatKhuVuc.whenInsertSuccessed += LoadData;
            capNhatKhuVuc.ShowDialog();
        }

        private void uc_DanhMuc1_Load(object sender, EventArgs e)
        {

        }

        private void grvctkhuvuc_Click(object sender, EventArgs e)
        {

        }
    }
}