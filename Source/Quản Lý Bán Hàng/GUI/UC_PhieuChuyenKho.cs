using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Quan_Ly_Ban_Hang.DTO;
using Quan_Ly_Ban_Hang.BUS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using DevExpress.XtraGrid;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class UC_PhieuChuyenKho : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void CloseForm();
        public event CloseForm DongThanhCong = null;
        int isupdate = 0;
        UC_PhieuChuyenKhoBUS UC_PhieuChuyenKhoBUS = new UC_PhieuChuyenKhoBUS();
        public void LoadKhoHang()
        {
            DataTable dt = UC_PhieuChuyenKhoBUS.LayThongTinKhoHang();
            cbkhoxuathang.Properties.DataSource = dt;
            cbkhoxuathang.Properties.ValueMember = "MaKH";
            cbkhoxuathang.Properties.DisplayMember = "TenKH";
            cbkhoxuathang.EditValue = cbkhoxuathang.Properties.GetKeyValue(0);

            cbkhonhanhang.Properties.DataSource = dt;
            cbkhonhanhang.Properties.ValueMember = "MaKH";
            cbkhonhanhang.Properties.DisplayMember = "TenKH";

        }
        public void LoadNhanVien()
        {
            DataTable dt = UC_PhieuChuyenKhoBUS.LayThongTinNhanVien();
            cbnguoinhan.Properties.DataSource = dt;
            cbnguoinhan.Properties.DisplayMember = "TenNV";
            cbnguoinhan.Properties.ValueMember = "MaNV";
            cbnguoinhan.EditValue = cbnguoinhan.Properties.GetKeyValue(0);

            cbnguoichuyen.Properties.DataSource = dt;
            cbnguoichuyen.Properties.DisplayMember = "TenNV";
            cbnguoichuyen.Properties.ValueMember = "MaNV";
            cbnguoichuyen.EditValue = cbnguoinhan.Properties.GetKeyValue(0);
        }
        public void LoadDanhSachSanPham()
        {
            grvluoidanhsachsanpham.DataSource = UC_PhieuChuyenKhoBUS.LayDanhSachHangHoa();
            grvluoidanhsachsanpham.DisplayMember = "MaSP";
            grvluoidanhsachsanpham.ValueMember = "MaSP";
            grvluoidanhsachsanpham.NullText = "Gõ vào đây";
        }
        public UC_PhieuChuyenKho()
        {
            InitializeComponent();
            var roleform = GlobalVar.distRoleForm[24];
            btntaomoi.Enabled = roleform.Them;
            btnin.Enabled = roleform.In_DL;
            btnluuthem.Enabled = roleform.Sua;

            txtngay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            txtngay.Properties.Mask.EditMask = "dd/MM/yyyy";
            txtngay.Properties.Mask.UseMaskAsDisplayFormat = true;

            txtngay.Text = DateTime.Today.ToString();

            LoadKhoHang();
            LoadNhanVien();
            LoadDanhSachSanPham();
            txtmaphieuchuyen.Text = UC_PhieuChuyenKhoBUS.PhatSinhMaPhieuChuyenKho();
            grvctchuyenkho.DataSource = UC_PhieuChuyenKhoBUS.LayCT_phhieuChuyenKho_Ao();

            // sum
            GridColumn column = grvchuyenkho.Columns["SoLuong"];
            column.SummaryItem.SummaryType = SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0}";

            column = grvchuyenkho.Columns["ThanhTien"];
            column.SummaryItem.SummaryType = SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0}";
        }

        string mh;
        int soluong;
        private void grvchuyenkho_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Caption == "Mã Hàng")
            {
                mh = grvchuyenkho.GetRowCellValue(e.RowHandle, e.Column).ToString();
                DataTable dt = UC_PhieuChuyenKhoBUS.LayThongTinHangHoaTheoMaHH(mh);
                if (dt.Rows.Count > 0)
                {
                    grvchuyenkho.SetRowCellValue(e.RowHandle, "TenHang", dt.Rows[0]["TenHH"].ToString());
                    grvchuyenkho.SetRowCellValue(e.RowHandle, "DonVi", dt.Rows[0]["TenDVT"].ToString());
                    try
                    {
                        grvchuyenkho.SetRowCellValue(e.RowHandle, "DonGia", dt.Rows[0]["GiaMua"].ToString());
                    }
                    catch { }
                    grvchuyenkho.SetRowCellValue(e.RowHandle, "SoLuong", 1);
                    grvchuyenkho.FocusedColumn = grvchuyenkho.Columns["DonVi"];
                }
            }
            if (e.Column.Caption == "Số Lượng")
            {
                grvchuyenkho.SetRowCellValue(e.RowHandle, "ThanhTien", ThanhTien());
            }
            if(e.Column.Caption == "Đơn Giá")
            {
                grvchuyenkho.SetRowCellValue(e.RowHandle, "ThanhTien", ThanhTien());
            }
        }
        private double ThanhTien()
        {
            try
            {
                int soluong = int.Parse(grvchuyenkho.GetFocusedRowCellValue(gridColumn4).ToString());
                double gia = double.Parse(grvchuyenkho.GetFocusedRowCellValue(gridColumn5).ToString());
                return soluong * gia;
            }
            catch
            {
            }
            return 0;
        }
        private void grvluoidanhsachsanpham_Popup(object sender, EventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            GridView view = editor.Properties.View;
            if (view.OptionsView.ShowAutoFilterRow && view.Columns.Count > 0)
            {
                view.FocusedRowHandle = GridControl.AutoFilterRowHandle;
                view.FocusedColumn = view.Columns["Mã Hàng"];
            }
        }
        private void grvchuyenkho_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.Caption == "Mã Hàng")
            {
                PopupBaseEdit edit = view.ActiveEditor as PopupBaseEdit;
                if (edit == null) return;
                view.GridControl.BeginInvoke(new MethodInvoker(() => { edit.ShowPopup(); }));
            }
        }

        private void btnthemnhanvien_Click(object sender, EventArgs e)
        {
            CapNhatNhanVien capNhatNhanVien = new CapNhatNhanVien("-1");
            capNhatNhanVien.whenInsertSuccessed += LoadNhanVien;
            capNhatNhanVien.ShowDialog();
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            UC_PhieuChuyenKhoBUS.XoaChiTietPhieuChuyenKhoAo();
            grvctchuyenkho.DataSource = UC_PhieuChuyenKhoBUS.LayCT_phhieuChuyenKho_Ao();
            txtmaphieuchuyen.Text = UC_PhieuChuyenKhoBUS.PhatSinhMaPhieuChuyenKho();
        }
        private int KiemTrdDuLieuHopLe()
        {
            // -2: Kho Trùng, -1: kho nhận chưa có, 0 dữ liệu chi tiết sai
            try
            {
                if (cbkhoxuathang.EditValue.ToString() == cbkhonhanhang.EditValue.ToString())
                {
                    return -2;
                }
            }
            catch
            {
                return -1;
            }
            if (grvchuyenkho.RowCount > 1)
            {
                for (int i = 0; i < grvchuyenkho.RowCount - 1; i++)
                {
                    try
                    {
                        int soluong = int.Parse(grvchuyenkho.GetRowCellValue(i, "SoLuong").ToString());
                        string donvi = grvchuyenkho.GetRowCellValue(i, "DonVi").ToString();
                        float DonGia = float.Parse(grvchuyenkho.GetRowCellValue(i, "DonGia").ToString());
                        float thanhtien = float.Parse(grvchuyenkho.GetRowCellValue(i, "ThanhTien").ToString());
                        string mahang = grvchuyenkho.GetRowCellValue(i, "MaHang").ToString();
                        string tenhang = grvchuyenkho.GetRowCellValue(i, "TenHang").ToString();
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }
            else
                return 0;
            return 1;
        }
        PhieuChuyenKhoDTO pck = new PhieuChuyenKhoDTO();
        private void LayDuLieuPhieuChuyenKho()
        {
            pck.MaCK = txtmaphieuchuyen.Text;
            pck.MaPVT = txtmaphieuchuyentay.Text;
            pck.KhoXuatHang = cbkhoxuathang.EditValue.ToString();
            pck.KhoNhanHang = cbkhonhanhang.EditValue.ToString();
            pck.NguoiChuyen = cbnguoichuyen.EditValue.ToString();
            pck.NguoiNhan = cbnguoinhan.EditValue.ToString();
            pck.GhiChu = txtghichu.Text;
            pck.NgayChuyen = txtngay.EditValue.ToString();
            var soluong = grvchuyenkho.Columns["SoLuong"].SummaryItem.SummaryValue;
            var thanhtien = grvchuyenkho.Columns["ThanhTien"].SummaryItem.SummaryValue;
            try
            {
                pck.SL_HangChuyen = int.Parse(soluong.ToString());
                pck.TongTien = int.Parse(thanhtien.ToString());
            }
            catch { }

        }
        public int ThemPhieuChuyenKho()
        {
            LayDuLieuPhieuChuyenKho();
            if (UC_PhieuChuyenKhoBUS.ThemPhieuChuyenKho(pck) < 1)
                return 0;
            return 1;
        }
        CT_PhieuChuyenKhoDTO ct_pck = new CT_PhieuChuyenKhoDTO();
        public int ThemChiTietPhieuChuyenKho()
        {
            for(int i = 0; i < grvchuyenkho.RowCount - 1;i++)
            {
                ct_pck.SoLuong = int.Parse(grvchuyenkho.GetRowCellValue(i, "SoLuong").ToString());
                ct_pck.DonVi = grvchuyenkho.GetRowCellValue(i, "DonVi").ToString();
                ct_pck.DonGia = float.Parse(grvchuyenkho.GetRowCellValue(i, "DonGia").ToString());
                ct_pck.ThanhTien = float.Parse(grvchuyenkho.GetRowCellValue(i, "ThanhTien").ToString());
                ct_pck.MaSanPham = grvchuyenkho.GetRowCellValue(i, "MaHang").ToString();
                ct_pck.TenSanPham = grvchuyenkho.GetRowCellValue(i, "TenHang").ToString();
                ct_pck.MaPhieuChuyenKho = pck.MaCK;
                // Kiểm tra xem Hàng Hóa này ở kho chuyển đã tồn tại
                PhieuBanHangBUS phieuBanHangBUS = new PhieuBanHangBUS();
                // nếu chưa có thì tạo mới
                phieuBanHangBUS.TaoHangHoaMoiChoKho(ct_pck.MaSanPham, ct_pck.SoLuong, pck.KhoXuatHang, ct_pck.TenSanPham);
                // Kiểm tra xem Hàng Hóa này ở kho nhận đã có có chưa
                // nếu chưa có thì tạo mới
                phieuBanHangBUS.TaoHangHoaMoiChoKho(ct_pck.MaSanPham, ct_pck.SoLuong, pck.KhoNhanHang, ct_pck.TenSanPham);

                if (UC_PhieuChuyenKhoBUS.ThemCT_PhieuChuyenKho(ct_pck) < 1)
                {
                    return 0;
                }
                else// chuyển kho thành công thì cập nhật số lượng
                {
                    // cập nhật hàng hóa ở kho chuyển
                    phieuBanHangBUS.CapNhatSoLuongHangHoa(ct_pck.MaSanPham, ct_pck.SoLuong, pck.KhoXuatHang);
                    // cập nhật số lượng ở kho nhận
                    phieuBanHangBUS.CapNhatSoLuongHangHoa(ct_pck.MaSanPham, -ct_pck.SoLuong, pck.KhoNhanHang);
                }
            }
            return 1;
        }
        private void btnluuthem_Click(object sender, EventArgs e)
        {
            if (KiemTrdDuLieuHopLe() == 1)
            {
                if (isupdate == 0)
                {
                    if (ThemPhieuChuyenKho() > 0)
                    {
                        if (ThemChiTietPhieuChuyenKho() > 0)
                        {
                            MessageBox.Show("Thêm Phiếu chuyển kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UC_PhieuChuyenKhoBUS.XoaChiTietPhieuChuyenKhoAo();
                            grvctchuyenkho.DataSource = UC_PhieuChuyenKhoBUS.LayCT_phhieuChuyenKho_Ao();
                            txtmaphieuchuyen.Text = UC_PhieuChuyenKhoBUS.PhatSinhMaPhieuChuyenKho();
                            LoadDanhSachSanPham();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Phiếu chuyển kho Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(GlobalVar.loisql);
                            UC_PhieuChuyenKhoBUS.XoaDulieuPhieuChuyenKhoVaCapNhatLaiSoLuong(pck.MaCK, pck.KhoXuatHang, pck.KhoNhanHang);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu chuyển kho thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(GlobalVar.loisql);
                    }
                }
            }
            else if (KiemTrdDuLieuHopLe() == -2)
            {
                MessageBox.Show("Kho xuất Và kho nhận không được trùng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (KiemTrdDuLieuHopLe() == -1)
            {
                MessageBox.Show("Chưa có kho nhận", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (KiemTrdDuLieuHopLe() == 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnnaplai_Click(object sender, EventArgs e)
        {
            LoadKhoHang();
            LoadNhanVien();
            LoadDanhSachSanPham();

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            try
            {
                DongThanhCong();
            }
            catch { }
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                int tonkho = int.Parse(view.GetRowCellDisplayText(e.RowHandle, view.Columns["SoLuongTon"]).ToString());
                if (tonkho <= 0)
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            grvchuyenkho.PrintDialog();
        }
    }
}
