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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class TonKho : DevExpress.XtraEditors.XtraForm
    {
        TonKhoBUS tonKhoBUS = new TonKhoBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public TonKho()
        {
            InitializeComponent();
            grvroottonkho.GroupPanelText = "Hãy kéo thả các cột vào đây";
            grvcttonkho.DataSource = tonKhoBUS.LayThongTinTonKho();
            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "SoLuong";
            item.ShowInGroupColumnFooter = grvroottonkho.Columns["SoLuong"];
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0}";
            grvroottonkho.GroupSummary.Add(item);
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Tồn Kho", "Xem", "");
            }
            catch
            {

            }
        }

        private void TonKho_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            btnxem.Enabled = GlobalVar.distRoleForm[tag].TruyCap;
            btnxuat.Enabled = GlobalVar.distRoleForm[tag].Xuat;
            btnin.Enabled = GlobalVar.distRoleForm[tag].In_DL;
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            Loadata();
        }

        private void Loadata()
        {
            grvcttonkho.DataSource = tonKhoBUS.LayThongTinTonKho();
        }
        int i = 0;
        private void btnxuat_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                grvroottonkho.ExportToXlsx(fbd.SelectedPath + "\\tonkho" + i + ".xlsx");
                i++;
                try
                {
                    NhatKyHeThongBUS.ThemNhatKyHeThong("Tồn Kho", "Xuất", "tonkho" + i + ".xlsx");
                }
                catch
                {

                }
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Tồn Kho", "Thoát", "");
            }
            catch
            {

            }
        }
    }
}