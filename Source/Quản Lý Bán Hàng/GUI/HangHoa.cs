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
    public partial class HangHoa : DevExpress.XtraEditors.XtraForm
    {
        HangHoaBUS hangHoaBUS = new HangHoaBUS();
        NhatKyHeThongBUS NhatKyHeThongBUS = new NhatKyHeThongBUS();
        public HangHoa()
        {
            InitializeComponent();
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Hàng Hóa", "Xem", "");
            }
            catch
            {

            }

        }
        private void LoadData()
        {
            grvcthanghoa.DataSource = hangHoaBUS.LayThongHangHoa();
            //cbnhomhang.Properties.DataSource = hangHoaBUS.LayThongTinNhomHang();
            //cbnhomhang.Properties.DisplayMember = "Tên Nhóm Hàng";
            //cbnhomhang.Properties.ValueMember = "Mã";
        }
        private void HangHoa_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            uc_DanhMuc1.EnnableFunction(roleform);
            LoadData();
            uc_DanhMuc1.Controls["ucbtnnaplai"].Click += NapLaiDL;
            uc_DanhMuc1.Controls["ucbtnthem"].Click += ThemHangHoa;
            uc_DanhMuc1.Controls["ucbtnsua"].Click += SuaThongTinHangHoa;
            uc_DanhMuc1.Controls["ucbtnxoa"].Click += XoaHangHoa;
            uc_DanhMuc1.Controls["ucbtndong"].Click += DongBieuMau;
            uc_DanhMuc1.Controls["ucbtnxuat"].Click += XuatFile;
        }

        private void NapLaiDL(object sender, EventArgs e)
        {
            try
            {
                NhatKyHeThongBUS.ThemNhatKyHeThong("Hàng Hóa", "Nạp Lại", "");
            }
            catch
            {

            }
            LoadData();
        }
        private void ThemHangHoa(object sender, EventArgs e)
        {
            CapNhatHangHoa capNhatHangHoa = new CapNhatHangHoa("-1");
            capNhatHangHoa.whenInsertSuccessed += LoadData;
            capNhatHangHoa.ShowDialog();
        }
        private void SuaThongTinHangHoa(object sender, EventArgs e)
        {
            if (grvhanghoa.GetRowCellValue(grvhanghoa.FocusedRowHandle, "Mã Hàng").ToString() != null)
            {
                CapNhatHangHoa capNhatHangHoa = new CapNhatHangHoa(grvhanghoa.GetRowCellValue(grvhanghoa.FocusedRowHandle, "Mã Hàng").ToString());
                capNhatHangHoa.whenInsertSuccessed += LoadData;
                capNhatHangHoa.ShowDialog();
            }
        }
        private void XoaHangHoa(object sender, EventArgs e)
        {
            if (grvhanghoa.GetRowCellValue(grvhanghoa.FocusedRowHandle, "Mã Hàng") != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (hangHoaBUS.XoaHangHoa(grvhanghoa.GetRowCellValue(grvhanghoa.FocusedRowHandle, "Mã Hàng").ToString()) > 0)
                    {
                        try
                        {
                            NhatKyHeThongBUS.ThemNhatKyHeThong("Hàng Hóa", "Xóa", grvhanghoa.GetRowCellValue(grvhanghoa.FocusedRowHandle, "Mã Hàng").ToString());
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
                NhatKyHeThongBUS.ThemNhatKyHeThong("Hàng Hóa", "Thoát", "");
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
                    grvhanghoa.ExportToXlsx(fbd.SelectedPath + "\\hanghoa" + i + ".xlsx");
                    i++;
                    NhatKyHeThongBUS.ThemNhatKyHeThong("Hàng Hóa", "Xuất file xlsx", "hanghoa" + i + ".xlsx");
                }
                catch
                {

                }
            }

        }

    }
}