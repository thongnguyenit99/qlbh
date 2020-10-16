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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing.Drawing2D;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class MuaHang : DevExpress.XtraEditors.XtraForm
    {
        MuaHangBUS muaHangBUS = new MuaHangBUS();
        DataTable dt;
        string tentkdn;
        int isUpdate = 0;
        public MuaHang(string tentk)
        {
            InitializeComponent();
            tentkdn = tentk;
            grvrootmuahang.Appearance.Row.Font = new Font("Times New Roman", 10F);
        }

        private void LoaddataTenNCC()
        {
            // ten ncc
            cbtennhacungcap.Properties.DataSource = muaHangBUS.LayThongTinNhaCungCapTheoTen();
            cbtennhacungcap.Properties.DisplayMember = "Nhà Phân Phối";
            cbtennhacungcap.Properties.ValueMember = "Mã";

            // ma ncc
            cbmanhacungcap.Properties.DataSource = muaHangBUS.LayThongTinNhaCungCapTheoMa();
            cbmanhacungcap.Properties.DisplayMember = "Mã";
            cbmanhacungcap.Properties.ValueMember = "Nhà Phân Phối";
        }
        private void LoadKhoHang()
        {
            // kho
            cbkhocongty.Properties.DataSource = muaHangBUS.LayThongTinKho();
            cbkhocongty.Properties.DisplayMember = "Tên";
            cbkhocongty.Properties.ValueMember = "Mã";
            cbkhocongty.EditValue = cbkhocongty.Properties.GetKeyValue(0);
        }
        private void loadata()
        {
            // nhanvien
            cbnhanvien.Properties.DataSource = muaHangBUS.LayThongTinNV();
            cbnhanvien.Properties.DisplayMember = "Tên";
            cbnhanvien.Properties.ValueMember = "Mã";
            cbnhanvien.EditValue = cbnhanvien.Properties.GetKeyValue(0);

            //ht thanh toán
            cbdktt.Properties.DataSource = muaHangBUS.LayThongTinDK_ThanhToan();
            cbdktt.Properties.DisplayMember = "Tên";
            cbdktt.Properties.ValueMember = "Mã";
            cbdktt.EditValue = cbdktt.Properties.GetKeyValue(0);
            //dk thanh toán
            cbhttt.Properties.DataSource = muaHangBUS.LayThongTinHT_ThanhToan();
            cbhttt.Properties.DisplayMember = "Tên";
            cbhttt.Properties.ValueMember = "Mã";
            cbhttt.EditValue = cbhttt.Properties.GetKeyValue(0);
            // mã PH
            txtmaphieunhaphang.Text = muaHangBUS.PhatSinhMaPhieu(tentkdn);
            // ngày mặc định
            cbngay.EditValue = DateTime.Today;
            txthanthanhtoan.EditValue = DateTime.Today;
        }
        private void LayThongTinHangHoaTruyenVoCombox()
        {
            grv_cbluoisanpham.DataSource = muaHangBUS.LayThongTinHangHoa();
            grv_cbluoisanpham.DisplayMember = "Mã Hàng";
            grv_cbluoisanpham.ValueMember = "Mã Hàng";
            grv_cbluoisanpham.NullText = "Gõ vào đây";
        }
        private void LoadTonBoDuLieu()
        {
            // add footer
            GridColumn column = grvrootmuahang.Columns["Thành Tiền"];
            column.SummaryItem.SummaryType = SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0}";

            column = grvrootmuahang.Columns["Số Lượng"];
            column.SummaryItem.SummaryType = SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0}";

            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            btntaomoi.Enabled = roleform.Them;
            btnin.Enabled = roleform.In_DL;
            btnluuvathem.Enabled = roleform.Sua;
            // load data
            loadata();
            LoaddataTenNCC();
            LoadKhoHang();
            muaHangBUS.XoaChiTietPhieuNhapHangAO();
            grvctmuahang.DataSource = muaHangBUS.LayThongTinHoaDonAo();
            //comboxedit grid control
            LayThongTinHangHoaTruyenVoCombox();
            // format ngay
            cbngay.Properties.NullText = DateTime.Today.ToString();
            cbngay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            cbngay.Properties.Mask.EditMask = "dd/MM/yyyy";
            cbngay.Properties.Mask.UseMaskAsDisplayFormat = true;

            txthanthanhtoan.Properties.NullText = DateTime.Today.ToString();
            txthanthanhtoan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            txthanthanhtoan.Properties.Mask.EditMask = "dd/MM/yyyy";
            txthanthanhtoan.Properties.Mask.UseMaskAsDisplayFormat = true;
        }
        private void MuaHang_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.distRoleForm[tag];
            btntaomoi.Enabled = roleform.Them;
            btnluuvathem.Enabled = roleform.Sua;
            btnin.Enabled = roleform.In_DL;
 
            LoadTonBoDuLieu();
        }
        int soluongpt_cn = -1;
        string khohang_cn = "";
        private void ThucThiKhiUpdate()
        {
            LoadTonBoDuLieu();
            txtmaphieunhaphang.Text = GlobalVar.MaPNH;
            string temp = GlobalVar.MaPNH;
            txtmaphieunhaphang.ReadOnly = true;
            cbmanhacungcap.EditValue = cbmanhacungcap.Properties.GetKeyValue(muaHangBUS.LayViTriNCCTheoTen(GlobalVar.TenNhaCungCap));
            dt = muaHangBUS.LayThongTinPhieuNhapHangTheo_MaPNH(temp);
            if (dt.Rows.Count > 0 && dt != null)
            {
                cbnhanvien.EditValue = dt.Rows[0]["MaNV"].ToString();
                cbngay.Text = dt.Rows[0]["NgayLap"].ToString();
                txtdiachi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtsohdvat.Text = dt.Rows[0]["SoVAT"].ToString();
                txtsophieuviettay.Text = dt.Rows[0]["SoPhieuVT"].ToString();
                cbkhocongty.EditValue = dt.Rows[0]["MaKho"].ToString();
                khohang_cn = dt.Rows[0]["MaKho"].ToString();
                txthanthanhtoan.Text = dt.Rows[0]["HanThanhToan"].ToString();
                cbhttt.EditValue = dt.Rows[0]["HT_ThanhToan"].ToString();
                cbdktt.EditValue = dt.Rows[0]["DK_ThanhToan"].ToString();
                txtchietkhau.Text = dt.Rows[0]["CK"].ToString();
                txtvat.Text = dt.Rows[0]["VAT"].ToString();
                txtghichu.Text = dt.Rows[0]["GhiChu"].ToString();
                if(muaHangBUS.LayChiTietPhieuNhapHangTheoMaPNH(temp) > 0)
                {
                    DataTable dt = muaHangBUS.LayThongTinHoaDonAo();
                    soluongpt_cn = dt.Rows.Count;
                    grvctmuahang.DataSource = dt;
                    isUpdate = 1;
                }
                else
                {
                    MessageBox.Show("Tải Dứ liệu để chỉnh sửa thất bại.Bạn vui lòng nạp lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tải Dứ liệu để chỉnh sửa thất bại.Bạn vui lòng nạp lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnthemnhacungcap_Click(object sender, EventArgs e)
        {
            CapNhatNhaCungCap capNhatNhaCungCap = new CapNhatNhaCungCap("-1");
            capNhatNhaCungCap.whenInsertSuccessed += LoaddataTenNCC;
            capNhatNhaCungCap.ShowDialog();
        }
        private void cbtennhacungcap_EditValueChanged(object sender, EventArgs e)
        {
            cbmanhacungcap.EditValue = cbmanhacungcap.Properties.GetKeyValue(muaHangBUS.LayViTriNCCTheoMa(cbtennhacungcap.EditValue.ToString()));
            dt = muaHangBUS.LayToanBoNhaCungCapTheoMaNCC(cbtennhacungcap.EditValue.ToString());
            if (dt.Rows.Count > 0)
            {
                txtdiachi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtdienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
                txtchietkhau.Text = dt.Rows[0]["ChietKhau"].ToString();
            }
        }
        private void cbmanhacungcap_EditValueChanged(object sender, EventArgs e)
        {
           cbtennhacungcap.EditValue = cbtennhacungcap.Properties.GetKeyValue(muaHangBUS.LayViTriNCCTheoTen(cbmanhacungcap.EditValue.ToString()));
            dt = muaHangBUS.LayToanBoNhaCungCapTheoMaNCC(cbmanhacungcap.EditValue.ToString());
            if (dt.Rows.Count > 0)
            {
                txtdiachi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtdienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
                txtchietkhau.Text = dt.Rows[0]["ChietKhau"].ToString();
            }
        }
        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CapNhatHangHoa capNhatHangHoa = new CapNhatHangHoa("-1");
            capNhatHangHoa.whenInsertSuccessed += LayThongTinHangHoaTruyenVoCombox;
            capNhatHangHoa.ShowDialog();
        }
        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CapNhatKhachHang capNhatKhachHang = new CapNhatKhachHang("-1");
            capNhatKhachHang.ShowDialog();
        }
        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CapNhatKhoHang capNhatKhoHang = new CapNhatKhoHang("-1");
            capNhatKhoHang.whenInsertSuccessed += LoadKhoHang;
            capNhatKhoHang.ShowDialog();
        }
        int soluong;
        float gia, thanhtien;
        private void TinhTien()
        {
            float tongtien = 0;
            for (int i = 0; i < grvrootmuahang.DataRowCount; i++)
            {
                var temp = grvrootmuahang.GetRowCellValue(i, "Thành Tiền");
                if (temp != null)
                {
                    try
                    {
                        tongtien = tongtien + float.Parse(grvrootmuahang.GetRowCellValue(i, "Thành Tiền").ToString());
                    }
                    catch { }
                }
            }
            string[] vat = txtvat.Text.ToString().Split(' ');
            string[] ck = txtchietkhau.Text.ToString().Split(' ');
            if (ck[0] != "" && vat[0] != "")
            {
                try
                {
                    txttienhoantra.Text = ((int)((float.Parse(ck[0]) / 100) * tongtien + 0.5)).ToString();
                    txttienthue.Text = ((int)((float.Parse(vat[0]) / 100) * tongtien + 0.5)).ToString();
                    tongtien = tongtien + (int)((float.Parse(vat[0]) / 100) * tongtien + 0.5) - (int)((float.Parse(ck[0]) / 100) * tongtien + 0.5);
                    txttongtien.Text = tongtien.ToString();
                    thanhtien = tongtien;
                }
                catch { }
            }

        }
        private void grvrootmuahang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "Mã Hàng")
            {
                var mh = grvrootmuahang.GetRowCellValue(e.RowHandle, e.Column);
                dt = muaHangBUS.LayThongTinHangHoaTheoMaHH(mh.ToString());
                if (dt.Rows.Count > 0)
                {
                    grvrootmuahang.SetRowCellValue(e.RowHandle, "Tên Hàng", dt.Rows[0]["TenHH"].ToString());
                    grvrootmuahang.SetRowCellValue(e.RowHandle, "Đơn Vị", dt.Rows[0]["TenDVT"].ToString());
                    grvrootmuahang.SetRowCellValue(e.RowHandle, "Đơn Giá", decimal.Parse(dt.Rows[0]["GiaMua"].ToString()));
                    grvrootmuahang.SetRowCellValue(e.RowHandle, "Số Lượng", 1);
                    grvrootmuahang.FocusedColumn = grvrootmuahang.Columns["Đơn Vị"];
                }
            }
            if(e.Column == gridSoLuong)
            {
                soluong = int.Parse(grvrootmuahang.GetFocusedRowCellValue(gridSoLuong).ToString());
                gia = float.Parse(grvrootmuahang.GetFocusedRowCellValue(gridDonGia).ToString());
                thanhtien = soluong * gia;
                grvrootmuahang.SetFocusedRowCellValue(gridThanhTien, thanhtien);
            }
            if (e.Column == gridDonGia)
            {
                try
                {
                    soluong = int.Parse(grvrootmuahang.GetFocusedRowCellValue(gridSoLuong).ToString());
                    gia = float.Parse(grvrootmuahang.GetFocusedRowCellValue(gridDonGia).ToString());
                    thanhtien = soluong * gia;
                    grvrootmuahang.SetFocusedRowCellValue(gridThanhTien, thanhtien);
                }catch
                {

                }
            }
            TinhTien();
        }
        private void grvrootmuahang_RowStyle(object sender, RowStyleEventArgs e)
        {
            e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
        private void grvrootmuahang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TinhTien();
        }
        private void grvrootmuahang_MouseDown(object sender, MouseEventArgs e)
        {
            TinhTien();
        }
        private void grvctmuahang_FocusedViewChanged(object sender, ViewFocusEventArgs e)
        {
            TinhTien();
        }
        private void txtchietkhau_Validated(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtchietkhau.Text, out value))
            {
                txtchietkhau.Text = txtchietkhau.Text + " %";
            }
            else
            {
                txtchietkhau.Text = "0 %";
            }
        }
        private void txtchietkhau_MouseDown(object sender, MouseEventArgs e)
        { 
            txtchietkhau.Text = "";
        }
        private void txtvat_Validated(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtvat.Text, out value))
            {
                txtvat.Text = txtvat.Text + " %";
            }
            else
            {
                txtvat.Text = "0 %";
            }
        }
        private void txtvat_MouseDown(object sender, MouseEventArgs e)
        {
            txtvat.Text = "";
        }
        private void txtchietkhau_EditValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }
        private void txtvat_EditValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }
        PhieuNhapHangDTO PNH_DTO = new PhieuNhapHangDTO();
        private bool SetGiaTriChoPhieuNhapHang()
        {
            try
            {
                string mancc = cbmanhacungcap.EditValue.ToString();
                if (txtmaphieunhaphang.Text != "")
                {
                    if (muaHangBUS.LayPhieuNhapHangTheoMaPhieuNhapHang(txtmaphieunhaphang.Text))
                    {
                        try
                        {
                            if (txttongtien.Text != "0" && grvrootmuahang.GetRowCellValue(0, "Mã Hàng").ToString() != "Gõ vào đây")
                            {
                                try
                                {
                                    for (int i = 0; i < grvrootmuahang.RowCount - 1; i++)
                                    {
                                        HangHoaPhu hhp = new HangHoaPhu();
                                        ctpnh.MaPhieuNhapHang = txtmaphieunhaphang.Text;
                                        ctpnh.MaSanPham = grvrootmuahang.GetRowCellValue(i, "Mã Hàng").ToString();
                                        hhp.mhh = grvrootmuahang.GetRowCellValue(i, "Mã Hàng").ToString();
                                        ctpnh.TenSanPham = grvrootmuahang.GetRowCellValue(i, "Tên Hàng").ToString();
                                        ctpnh.DonVi = grvrootmuahang.GetRowCellValue(i, "Đơn Vị").ToString();
                                        ctpnh.SoLuong = int.Parse(grvrootmuahang.GetRowCellValue(i, "Số Lượng").ToString());
                                        hhp.soluong = int.Parse(grvrootmuahang.GetRowCellValue(i, "Số Lượng").ToString());
                                        ctpnh.DonGia = float.Parse(grvrootmuahang.GetRowCellValue(i, "Đơn Giá").ToString());
                                        ctpnh.ThanhTien = float.Parse(grvrootmuahang.GetRowCellValue(i, "Thành Tiền").ToString());
                                        ctpnh.GhiChu = (grvrootmuahang.GetRowCellValue(i, "Ghi Chú").ToString());
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Phiếu rỗng không thể lưu.", "Cảnh báo Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return false;
                                }
                                PNH_DTO.MaPNH = txtmaphieunhaphang.Text;
                                PNH_DTO.MaNV = cbnhanvien.EditValue.ToString();
                                PNH_DTO.MaNCC = cbtennhacungcap.EditValue.ToString();
                                PNH_DTO.DiaChi = txtdiachi.Text;
                                PNH_DTO.GhiChu = txtghichu.Text;
                                PNH_DTO.MaKho = cbkhocongty.EditValue.ToString();
                                PNH_DTO.SoVAT = txtsohdvat.Text;
                                PNH_DTO.SoPhieuVT = txtsophieuviettay.Text;
                                PNH_DTO.DK_ThanhToan = cbdktt.EditValue.ToString();
                                PNH_DTO.HT_ThanhToan = cbhttt.EditValue.ToString();
                                PNH_DTO.HanThanhToan = txthanthanhtoan.EditValue.ToString();
                                PNH_DTO.NgayLap = cbngay.EditValue.ToString();
                                PNH_DTO.VAT = txtvat.Text;
                                PNH_DTO.CK = txtchietkhau.Text;
                                PNH_DTO.TongThanhTien = int.Parse(thanhtien.ToString());
                            }
                            else
                            {
                                MessageBox.Show("Phiếu rỗng không thể lưu.", "Cảnh báo Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }catch
                        {
                            MessageBox.Show("Phiếu rỗng không thể lưu.", "Cảnh báo Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Phiếu Nhập Hàng Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Mã Phiếu Nhập Hàng không được rỗng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmaphieunhaphang.Text = muaHangBUS.PhatSinhMaPhieu(tentkdn);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng chọn nhà cung cấp.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        CT_PhieuNhapHangDTO ctpnh = new CT_PhieuNhapHangDTO();
        public class HangHoaPhu
        {
            public string mhh;
            public int soluong;
        }
        private int ThemChiTietHangHoa()
        {
            var lstinst = new List<HangHoaPhu>();
            var lstupdate = new List<HangHoaPhu>();
            var lst_SoLUongCu = new List<int>();
            int soluong = 0;
            DataTable dt = muaHangBUS.LayThongTinHoaDonAo();
            if (isUpdate == 1)
            {
                if (muaHangBUS.XoaCT_PhieuNhapHang(PNH_DTO.MaPNH, khohang_cn) > 0)
                {

                }
            }
            for (int i = 0; i < grvrootmuahang.RowCount - 1; i++)
            {
                HangHoaPhu hhp = new HangHoaPhu();
                ctpnh.MaPhieuNhapHang = txtmaphieunhaphang.Text;
                ctpnh.MaSanPham = grvrootmuahang.GetRowCellValue(i, "Mã Hàng").ToString();
                hhp.mhh = grvrootmuahang.GetRowCellValue(i, "Mã Hàng").ToString();
                ctpnh.TenSanPham = grvrootmuahang.GetRowCellValue(i, "Tên Hàng").ToString();
                ctpnh.DonVi = grvrootmuahang.GetRowCellValue(i, "Đơn Vị").ToString();
                ctpnh.SoLuong = int.Parse(grvrootmuahang.GetRowCellValue(i, "Số Lượng").ToString());
                hhp.soluong = int.Parse(grvrootmuahang.GetRowCellValue(i, "Số Lượng").ToString());
                ctpnh.DonGia = float.Parse(grvrootmuahang.GetRowCellValue(i, "Đơn Giá").ToString());
                ctpnh.ThanhTien = float.Parse(grvrootmuahang.GetRowCellValue(i, "Thành Tiền").ToString());
                ctpnh.GhiChu = (grvrootmuahang.GetRowCellValue(i, "Ghi Chú").ToString());
                ctpnh.ViTri = i;
                // trước khi update thì ta xóa hết chi tiết
                // Thêm
                if (muaHangBUS.ThemCT_PhieuNhapHang(ctpnh) > 0)
                {
                    // Kiểm tra xem Với mã hàng này ở kho này đã tồn tại
                    if (muaHangBUS.KiemTrahangHoaNayDaTonTaioKhoNay(ctpnh.MaSanPham, PNH_DTO.MaKho) > 0)
                    {
                        if (muaHangBUS.CapNhatSoLuongHangHoa(ctpnh.MaSanPham, ctpnh.SoLuong, PNH_DTO.MaKho) > 0)
                        {
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        // thêm hang hóa mới
                        if (muaHangBUS.ThemHangHoa(ctpnh.MaSanPham, ctpnh.TenSanPham, PNH_DTO.MaKho, ctpnh.SoLuong) > 0) { }
                        else
                        {
                            return 0;
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }

            return 1;
        }
        private void btnluuvathem_Click(object sender, EventArgs e)
        {
            if (isUpdate == 0)
            {
                if (SetGiaTriChoPhieuNhapHang())
                {
                    if (muaHangBUS.ThemPhieuNhapNhang(PNH_DTO) > 0)
                    {
                        if (ThemChiTietHangHoa() > 0)
                        {
                            txtmaphieunhaphang.Text = muaHangBUS.PhatSinhMaPhieu(tentkdn);
                            LayThongTinHangHoaTruyenVoCombox();
                            muaHangBUS.XoaChiTietPhieuNhapHangAO();
                            grvctmuahang.DataSource = muaHangBUS.LayThongTinHoaDonAo();
                            MessageBox.Show("Thêm phiếu nhập hàng thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(GlobalVar.loisql, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Thêm chi tiết phiếu nhập hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            muaHangBUS.XoaPhieuNhapHang(txtmaphieunhaphang.Text);
                            muaHangBUS.XoaCT_PhieuNhapHang(txtmaphieunhaphang.Text, cbkhocongty.EditValue.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm chi tiết phiếu nhập hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết phiếu nhập hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (isUpdate == 1)
            {
                if (LayDuLieuDeCapNhatPhieuNhapHang())
                {
                    if (muaHangBUS.CapNhatPhieuNhapHang(PNH_DTO) > 0)
                    {
                        // cập nhật chi tiết phiếu nhập hàng
                        if (ThemChiTietHangHoa() > 0)
                        {
                            soluongpt_cn = grvrootmuahang.RowCount;
                            khohang_cn = PNH_DTO.MaKho;
                            LayThongTinHangHoaTruyenVoCombox();
                            MessageBox.Show("Cập nhật chi tiết phiếu nhập hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else 
                        {
                            MessageBox.Show("Cập nhật chi tiết phiếu nhập hàng mới thất bại_CTPNH", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu nhập hàng thất bại._PNH", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Cập Nhật thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public bool LayDuLieuDeCapNhatPhieuNhapHang()
        {
            try
            {
                string mancc = cbmanhacungcap.EditValue.ToString();
                try
                {
                    if (txttongtien.Text != "0" && grvrootmuahang.GetRowCellValue(0, "Mã Hàng").ToString() != "Gõ vào đây")
                    {
                        PNH_DTO.MaPNH = txtmaphieunhaphang.Text;
                        PNH_DTO.MaNV = cbnhanvien.EditValue.ToString();
                        PNH_DTO.MaNCC = cbtennhacungcap.EditValue.ToString();
                        PNH_DTO.DiaChi = txtdiachi.Text;
                        PNH_DTO.GhiChu = txtghichu.Text;
                        PNH_DTO.MaKho = cbkhocongty.EditValue.ToString();
                        PNH_DTO.SoVAT = txtsohdvat.Text;
                        PNH_DTO.SoPhieuVT = txtsophieuviettay.Text;
                        PNH_DTO.DK_ThanhToan = cbdktt.EditValue.ToString();
                        PNH_DTO.HT_ThanhToan = cbhttt.EditValue.ToString();
                        PNH_DTO.HanThanhToan = txthanthanhtoan.EditValue.ToString();
                        PNH_DTO.NgayLap = cbngay.EditValue.ToString();
                        PNH_DTO.VAT = txtvat.Text;
                        PNH_DTO.CK = txtchietkhau.Text;
                        PNH_DTO.TongThanhTien = int.Parse(thanhtien.ToString());
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Phiếu rỗng không thể lưu.", "Cảnh báo Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Phiếu rỗng không thể lưu.", "Cảnh báo Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng chọn nhà cung cấp.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private void btntaomoi_Click(object sender, EventArgs e)
        {
            isUpdate = 0;
            muaHangBUS.XoaChiTietPhieuNhapHangAO();
            grvctmuahang.DataSource = muaHangBUS.LayThongTinHoaDonAo();
            txtmaphieunhaphang.ReadOnly = false;
            txtmaphieunhaphang.Text = muaHangBUS.PhatSinhMaPhieu(tentkdn);
            txtsophieuviettay.Text = "";
            txtsohdvat.Text = "";
            try
            {
                dt = muaHangBUS.LayToanBoNhaCungCapTheoMaNCC(cbtennhacungcap.EditValue.ToString());
                txtchietkhau.Text = dt.Rows[0]["ChietKhau"].ToString();
            }
            catch
            {

            }
            txtvat.Text = "0 %";
            txttienhoantra.Text = "0";
            txttienthue.Text = "0";
            txttongtien.Text = "0";
            LayThongTinHangHoaTruyenVoCombox();
        }

        private void repositoryItemGridLookUpEdit1View_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
          
        }

        private void Dong()
        {
            this.Close();
        }
        private void menutheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TheoHangHoa_PNH theoHangHoa_PNH = new TheoHangHoa_PNH();
            theoHangHoa_PNH.DongThanhCong += Dong;
            theoHangHoa_PNH.TaoMoiThanhCong += virtualcreate;
            theoHangHoa_PNH.SuaChuaThanhCong += ThucThiKhiUpdate;
            theoHangHoa_PNH.ShowDialog();
        }
        private void menutheochungtu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TheoChungTu_PNH theoChungTu_PNH = new TheoChungTu_PNH();
            theoChungTu_PNH.SuaChuaThanhCong += ThucThiKhiUpdate;
            theoChungTu_PNH.TaoMoiThanhCong += virtualcreate;
            theoChungTu_PNH.DongThanhCong += Dong;
            theoChungTu_PNH.ShowDialog();
        }

        private void virtualcreate()
        {
           
        }

        private void repositoryItemGridLookUpEdit1View_RowStyle_1(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                int tonkho = int.Parse(view.GetRowCellDisplayText(e.RowHandle, view.Columns["Tồn Kho"]).ToString());
                if (tonkho <= 0)
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void btnnaplai_Click(object sender, EventArgs e)
        {
            LayThongTinHangHoaTruyenVoCombox();
        }

        private void grvrootmuahang_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Mã Hàng")
            {
                // Your code here. 
            }
        }

        private void grvrootmuahang_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "Mã Hàng")
            {
                PopupBaseEdit edit = view.ActiveEditor as PopupBaseEdit;
                if (edit == null) return;
                view.GridControl.BeginInvoke(new MethodInvoker(() => { edit.ShowPopup(); }));
            }
        }

        private void gridView6_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                int tonkho = int.Parse(view.GetRowCellDisplayText(e.RowHandle, view.Columns["Tồn Kho"]).ToString());
                if (tonkho <= 0)
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void grv_cbluoisanpham_Popup(object sender, EventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            GridView view = editor.Properties.View;
            if (view.OptionsView.ShowAutoFilterRow && view.Columns.Count > 0)
            {
                view.FocusedRowHandle = GridControl.AutoFilterRowHandle;
                view.FocusedColumn = view.Columns["Mã Hàng"];
            }
        }
    }
}