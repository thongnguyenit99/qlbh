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
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using System.Drawing.Drawing2D;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class UC_PhieuBanHang : DevExpress.XtraEditors.XtraUserControl
    {

        public delegate void Dong();
        public event Dong DongThanhCong = null;
        string tentkdn;
        public int isUpdate = 0;
        MuaHangBUS muaHangBUS = new MuaHangBUS();
        PhieuBanHangBUS PhieuBanHangBUS = new PhieuBanHangBUS();
        DataTable dt;
        public void LoaddataTenKhachHang()
        {
            // ten kh
            cbtenkhachhang.Properties.DataSource = PhieuBanHangBUS.LayThongTinKhachHang_Ten();
            cbtenkhachhang.Properties.DisplayMember = "Khách Hàng";
            cbtenkhachhang.Properties.ValueMember = "Mã";
            // cbtennhacungcap.EditValue = cbtennhacungcap.Properties.GetKeyValue(0);
            // ma kh
            cbmakhachang.Properties.DataSource = PhieuBanHangBUS.LayThongTinKhachHang_Ma();
            cbmakhachang.Properties.DisplayMember = "Mã";
            cbmakhachang.Properties.ValueMember = "Mã";
        }
        public void LoadKhoHang()
        {
            // kho
            cbkhocongty.Properties.DataSource = muaHangBUS.LayThongTinKho();
            cbkhocongty.Properties.DisplayMember = "Tên";
            cbkhocongty.Properties.ValueMember = "Mã";
            cbkhocongty.EditValue = cbkhocongty.Properties.GetKeyValue(0);
        }
        public void LayThongTinHangHoa()
        {
            GridLookUpEdit1_MaHang.DataSource = muaHangBUS.LayThongTinHangHoa();
            GridLookUpEdit1_MaHang.DisplayMember = "Mã Hàng";
            GridLookUpEdit1_MaHang.ValueMember = "Mã Hàng";
            GridLookUpEdit1_MaHang.NullText = "Gõ vào đây";
        }
        private void loadata()
        {
            // nhanvien
            cbnhanvienbh.Properties.DataSource = muaHangBUS.LayThongTinNV();
            cbnhanvienbh.Properties.DisplayMember = "Tên";
            cbnhanvienbh.Properties.ValueMember = "Mã";
            cbnhanvienbh.EditValue = cbnhanvienbh.Properties.GetKeyValue(0);

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
            txtmaphieubh.Text = PhieuBanHangBUS.PhatSinhMaPhieuBH(tentkdn);
            // ngày mặc định
            cbngaylap.EditValue = DateTime.Today;
            cbhtt.EditValue = DateTime.Today;
            //comboxedit grid control
            GridLookUpEdit1_GiaBan.DataSource = PhieuBanHangBUS.LayThongTinGiaBan();
            GridLookUpEdit1_GiaBan.DisplayMember = "Id";
            GridLookUpEdit1_GiaBan.ValueMember = "Id";
            GridLookUpEdit1_GiaBan.NullText = "Chọn";

            LayThongTinHangHoa();
            // format ngày
            cbngaylap.Properties.NullText = DateTime.Today.ToString();
            cbngaylap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            cbngaylap.Properties.Mask.EditMask = "dd/MM/yyyy";
            cbngaylap.Properties.Mask.UseMaskAsDisplayFormat = true;

            cbhtt.Properties.NullText = DateTime.Today.ToString();
            cbhtt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            cbhtt.Properties.Mask.EditMask = "dd/MM/yyyy";
            cbhtt.Properties.Mask.UseMaskAsDisplayFormat = true;

            combongaygiao.Text = DateTime.Now.ToString();
            combongaygiao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            combongaygiao.Properties.Mask.EditMask = "dd/MM/yyyy";
            combongaygiao.Properties.Mask.UseMaskAsDisplayFormat = true;

        }
        string khohang_cn ="";
        public void ThucThiKhiCapNhat()
        {
            try
            {
                grvbanhang.DataSource = PhieuBanHangBUS.LayThongTinCT_PhieuMuaHangAo();
                DataTable dt1 = PhieuBanHangBUS.LayThongTinPhieuBanHangTheoMa(GlobalVar.MaPBH);
                if (dt1.Rows.Count > 0 && dt1 != null)
                {
                    txtmaphieubh.Text = dt1.Rows[0]["MaPBH"].ToString();
                    txtmaphieubh.ReadOnly = true;
                    cbmakhachang.EditValue = dt1.Rows[0]["MaKH"].ToString();
                    cbngaylap.Text = dt1.Rows[0]["NgayLap"].ToString();
                    combongaygiao.Text = dt1.Rows[0]["NgayGiao"].ToString();
                    cbhtt.Text = dt1.Rows[0]["HanThanhToan"].ToString();
                    cbdktt.Text = dt1.Rows[0]["DK_ThanhToan"].ToString();
                    cbhttt.Text = dt1.Rows[0]["HT_ThanhToan"].ToString();
                    cbkhocongty.Text = dt1.Rows[0]["MaKho"].ToString();
                    khohang_cn = dt1.Rows[0]["MaKho"].ToString();
                    cbnhanvienbh.Text = dt1.Rows[0]["MaNV"].ToString();
                    txtghichu.Text = dt1.Rows[0]["GhiChu"].ToString();
                    txtsophieuviettay.Text = dt1.Rows[0]["SoPhieuVT"].ToString();
                    txtsohdvat.Text = dt1.Rows[0]["SoVAT"].ToString();
                    txtchietkhau.Text = dt1.Rows[0]["CK"].ToString();
                    txtvat.Text = dt1.Rows[0]["VAT"].ToString();
                    txtthanhtien.Text = dt1.Rows[0]["TongThanhTien"].ToString();
                    PhieuBanHangBUS.GanGiaTriChoChiTietPhieuMuaHangAo(txtmaphieubh.Text);
                    grvbanhang.DataSource = PhieuBanHangBUS.LayThongTinChiTietAOKhongXoa();
                }
                TinhTien();
                isUpdate = 1;
            }
            catch
            {
                isUpdate = 0;
                MessageBox.Show("Tại dữ liệu để cập nhật thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public UC_PhieuBanHang(string tentk, int tag)
        {
            InitializeComponent();
            // add footer
            grvbanhang.DataSource = PhieuBanHangBUS.LayThongTinCT_PhieuMuaHangAo();
            grvrootbanhang.Columns["Loại Giá"].ToolTip = "1. Giá mua, 2. Giá bán sỉ, 3. Giá bán lẻ, 4. Giá khác";

            GridColumn column = grvrootbanhang.Columns["Thành Tiền"];
            column.SummaryItem.SummaryType = SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0}";

            column = grvrootbanhang.Columns["Số Lượng"];
            column.SummaryItem.SummaryType = SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0}";

            column = grvrootbanhang.Columns["Chiết Khấu"];
            column.SummaryItem.SummaryType = SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0}";

            column = grvrootbanhang.Columns["Thanh Toán"];
            column.SummaryItem.SummaryType = SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0}";
            tentkdn = tentk;
            int tag1 = 22;
            var roleform = GlobalVar.distRoleForm[tag1];
            btntaomoi.Enabled = roleform.Them;
            btnin.Enabled = roleform.In_DL;
            btnluuvathem.Enabled = roleform.Sua;
            // load data
            LoaddataTenKhachHang();
            loadata();
            LoadKhoHang();
            LayThongTinHangHoa();
            grvrootbanhang.Appearance.Row.Font = new Font("Times New Roman", 10F);
        }

        private void cbtenkhachhang_EditValueChanged(object sender, EventArgs e)
        {
            cbmakhachang.EditValue = cbmakhachang.Properties.GetKeyValue(int.Parse(cbtenkhachhang.Properties.GetIndexByKeyValue(cbtenkhachhang.EditValue.ToString()).ToString()));
            dt = PhieuBanHangBUS.LayToanBoThongTinKhachHangTheoMaKH(cbtenkhachhang.EditValue.ToString());
            if (dt.Rows.Count > 0)
            {
                txtdiachi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtdienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
                txtchietkhau.Text = dt.Rows[0]["ChietKhau"].ToString();
            }
        }

        private void cbmakhachang_EditValueChanged(object sender, EventArgs e)
        {
            cbtenkhachhang.EditValue = cbtenkhachhang.Properties.GetKeyValue(int.Parse(cbmakhachang.Properties.GetIndexByKeyValue(cbmakhachang.EditValue.ToString()).ToString()));
            dt = PhieuBanHangBUS.LayToanBoThongTinKhachHangTheoMaKH(cbmakhachang.EditValue.ToString());
            if (dt.Rows.Count > 0)
            {
                txtdiachi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtdienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
                txtchietkhau.Text = dt.Rows[0]["ChietKhau"].ToString();
            }
        }

        private void btnthemkhachhang_Click(object sender, EventArgs e)
        {
            CapNhatKhachHang capNhatKhachHang = new CapNhatKhachHang("-1");
            capNhatKhachHang.whenInsertSuccessed += LoaddataTenKhachHang;
            capNhatKhachHang.ShowDialog();
        }

        string mh;
        int tam = 0;
        private void grvrootmuahang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Mã Hàng")
            {
                mh = grvrootbanhang.GetRowCellValue(e.RowHandle, e.Column).ToString();
                dt = muaHangBUS.LayThongTinHangHoaTheoMaHH(mh.ToString());
                if (dt.Rows.Count > 0)
                {
                    grvrootbanhang.SetRowCellValue(e.RowHandle, "Tên Hàng", dt.Rows[0]["TenHH"].ToString());
                    grvrootbanhang.SetRowCellValue(e.RowHandle, "Đơn Vị", dt.Rows[0]["TenDVT"].ToString());
                    grvrootbanhang.SetRowCellValue(e.RowHandle, "Số Lượng", 1);
                    grvrootbanhang.SetRowCellValue(e.RowHandle, "Đơn Giá", 0);
                    grvrootbanhang.FocusedColumn = grvrootbanhang.Columns["Đơn Vị"];
                }
                try
                {
                    grvrootbanhang.SetRowCellValue(e.RowHandle, "Loại Giá", 3);
                }
                catch
                {

                }
            }
            if (e.Column.FieldName == "Loại Giá")
            {
                dt = muaHangBUS.LayThongTinHangHoaTheoMaHH(mh.ToString());
                if (dt.Rows.Count > 0)
                {
                    var luachon = grvrootbanhang.GetRowCellValue(e.RowHandle, e.Column);
                    if (int.Parse(luachon.ToString()) == 1)
                        grvrootbanhang.SetRowCellValue(e.RowHandle, "Đơn Giá", decimal.Parse(dt.Rows[0]["GiaMua"].ToString()));
                    if (int.Parse(luachon.ToString()) == 2)
                        grvrootbanhang.SetRowCellValue(e.RowHandle, "Đơn Giá", decimal.Parse(dt.Rows[0]["GiaBanSi"].ToString()));
                    if (int.Parse(luachon.ToString()) == 3)
                        grvrootbanhang.SetRowCellValue(e.RowHandle, "Đơn Giá", decimal.Parse(dt.Rows[0]["GiaBanLe"].ToString()));
                    if (int.Parse(luachon.ToString()) == 4)
                    {
                        grvrootbanhang.SetRowCellValue(e.RowHandle, "Đơn Giá", 0);
                    }
                }
                grvrootbanhang.SetFocusedRowCellValue(gridColumn7, ThanhTien());
                try
                {
                    float ck = float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn8).ToString());
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn9, Convert.ToDecimal((ck / 100) * ThanhTien()));
                }
                catch
                {
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn8, "0");
                }
                try
                {
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn10, float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn7).ToString()) - float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn9).ToString()));
                }
                catch
                {

                }

            }
            if (e.Column.FieldName == "Số Lượng")
            {
                grvrootbanhang.SetFocusedRowCellValue(gridColumn7, ThanhTien());
                try
                {
                    float ck = float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn8).ToString());
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn9, Convert.ToDecimal((ck / 100) * ThanhTien()));
                }
                catch
                {
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn8, "0");
                }
                try
                {
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn10, float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn7).ToString()) - float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn9).ToString()));
                }
                catch
                {

                }
            }
            if (e.Column.FieldName == "Đơn Giá")
            {
                grvrootbanhang.SetFocusedRowCellValue(gridColumn7, ThanhTien());
                try
                {
                    float ck = float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn8).ToString());
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn9, Convert.ToDecimal((ck / 100) * ThanhTien()));
                }
                catch
                {
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn8, "0");
                }
                try
                {
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn10, float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn7).ToString()) - float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn9).ToString()));
                }
                catch
                {

                }
            }
            if (e.Column.FieldName == "CK")
            {
                try
                {
                    float ck = float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn8).ToString());
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn9, Convert.ToDecimal((ck / 100) * ThanhTien()));
                }
                catch
                {
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn8, "1");
                }
                try
                {
                    grvrootbanhang.SetFocusedRowCellValue(gridColumn10, float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn7).ToString()) - float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn9).ToString()));
                }
                catch
                {

                }
            }
        }
        private float ThanhTien()
        {
            try
            {
                int soluong = int.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn5).ToString());
                float gia = float.Parse(grvrootbanhang.GetFocusedRowCellValue(gridColumn6).ToString());
                return soluong * gia;
            }
            catch
            {
            }
            return 0;
        }
        private void txtchietkhau_MouseDown(object sender, MouseEventArgs e)
        {
            txtchietkhau.Text = "";
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

        private void txtchietkhau_EditValueChanged(object sender, EventArgs e)
        {
            TinhTien();
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

        float thanhtien;
        private void TinhTien()
        {
            try
            {
                var summaryValue = grvrootbanhang.Columns["Thanh Toán"].SummaryItem.SummaryValue;
                int tongtien = int.Parse(summaryValue.ToString());
                string[] vat = txtvat.Text.ToString().Split(' ');
                string[] ck = txtchietkhau.Text.ToString().Split(' ');
                if (ck[0] != "" && vat[0] != "")
                {
                    try
                    {
                        txttienhoantra.Text = ((int)((float.Parse(ck[0]) / 100) * tongtien + 0.5)).ToString();
                        txttienthue.Text = ((int)((float.Parse(vat[0]) / 100) * tongtien + 0.5)).ToString();
                        tongtien = tongtien + (int)((float.Parse(vat[0]) / 100) * tongtien + 0.5) - (int)((float.Parse(ck[0]) / 100) * tongtien + 0.5);
                        thanhtien = tongtien;
                        txtthanhtien.EditValue = tongtien;
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            isUpdate = 0;
            txtmaphieubh.ReadOnly = false;
            txtmaphieubh.Text = PhieuBanHangBUS.PhatSinhMaPhieuBH(GlobalVar.tendn);
            grvbanhang.DataSource = PhieuBanHangBUS.LayThongTinCT_PhieuMuaHangAo();
            txtsophieuviettay.Text = "";
            txtsohdvat.Text = "";
            try
            {
                dt = PhieuBanHangBUS.LayToanBoThongTinKhachHangTheoMaKH(cbmakhachang.EditValue.ToString());
                txtchietkhau.Text = dt.Rows[0]["ChietKhau"].ToString();
            }
            catch { }
            txtvat.Text = "0 %";
            txttienhoantra.Text = "0";
            txttienthue.Text = "0";
            txtthanhtien.Text = "0";
            LayThongTinHangHoa();
        }

        private void txtvat_EditValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void grvrootbanhang_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
        PhieuBanHangDTO pbh = new PhieuBanHangDTO();
        private bool SetGiaTriChoPhieuBanHang()
        {
            if (isUpdate == 0)
            {
                try
                {
                    string mancc = cbmakhachang.EditValue.ToString();
                    if (txtmaphieubh.Text != "")
                    {
                        if (PhieuBanHangBUS.KiemTraXemMaPBHDaTonTai(txtmaphieubh.Text))
                        {
                            try
                            {
                                for (int i = 0; i < grvrootbanhang.RowCount - 1; i++)
                                {
                                    SanPhamPhu sp = new SanPhamPhu();
                                    sp.soluong = int.Parse(grvrootbanhang.GetRowCellValue(i, "Số Lượng").ToString());
                                    ctpbh.DonVi = grvrootbanhang.GetRowCellValue(i, "Đơn Vị").ToString();
                                    ctpbh.DonGia = float.Parse(grvrootbanhang.GetRowCellValue(i, "Đơn Giá").ToString());
                                    ctpbh.ChietKhau = float.Parse(grvrootbanhang.GetRowCellValue(i, "Chiết Khấu").ToString());
                                    ctpbh.ThanhToan = float.Parse(grvrootbanhang.GetRowCellValue(i, "Thanh Toán").ToString());
                                    ctpbh.LoaiGia = int.Parse(grvrootbanhang.GetRowCellValue(i, "Loại Giá").ToString());
                                    ctpbh.CK = float.Parse(grvrootbanhang.GetRowCellValue(i, "CK").ToString());
                                    ctpbh.ThanhTien = float.Parse(grvrootbanhang.GetRowCellValue(i, "Thành Tiền").ToString());
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Phiếu rỗng không thể lưu.", "Cảnh báo Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                            if (grvrootbanhang.RowCount > 1)
                            {
                                pbh.MaPBH = txtmaphieubh.Text;
                                pbh.MaNV = cbnhanvienbh.EditValue.ToString();
                                pbh.MaKH = cbmakhachang.EditValue.ToString();
                                pbh.DiaChi = txtdiachi.Text;
                                pbh.GhiChu = txtghichu.Text;
                                pbh.MaKho = cbkhocongty.EditValue.ToString();
                                pbh.SoVAT = txtsohdvat.Text;
                                pbh.SoPhieuVT = txtsophieuviettay.Text;
                                pbh.DK_ThanhToan = cbdktt.EditValue.ToString();
                                pbh.HT_ThanhToan = cbhttt.EditValue.ToString();
                                pbh.HanThanhToan = cbhtt.EditValue.ToString();
                                try
                                {
                                    pbh.NgayGiao = combongaygiao.EditValue.ToString();
                                }
                                catch
                                {
                                    pbh.NgayGiao = DateTime.Now.ToString();
                                }
                                pbh.NgayLap = cbngaylap.EditValue.ToString();
                                pbh.VAT = txtvat.Text;
                                pbh.CK = txtchietkhau.Text;
                                pbh.TongThanhTien = int.Parse(txtthanhtien.Text.ToString());
                            }
                            else
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
                        txtmaphieubh.Text = muaHangBUS.PhatSinhMaPhieu(tentkdn);
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Vui Lòng chọn Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (isUpdate == 1)
            {
                try
                {
                    if (grvrootbanhang.RowCount > 1)
                    {
                        pbh.MaPBH = txtmaphieubh.Text;
                        pbh.MaNV = cbnhanvienbh.EditValue.ToString();
                        pbh.MaKH = cbmakhachang.EditValue.ToString();
                        pbh.DiaChi = txtdiachi.Text;
                        pbh.GhiChu = txtghichu.Text;
                        pbh.MaKho = cbkhocongty.EditValue.ToString();
                        pbh.SoVAT = txtsohdvat.Text;
                        pbh.SoPhieuVT = txtsophieuviettay.Text;
                        pbh.DK_ThanhToan = cbdktt.EditValue.ToString();
                        pbh.HT_ThanhToan = cbhttt.EditValue.ToString();
                        pbh.HanThanhToan = cbhtt.EditValue.ToString();
                        try
                        {
                            pbh.NgayGiao = combongaygiao.EditValue.ToString();
                        }
                        catch
                        {
                            pbh.NgayGiao = DateTime.Now.ToString();
                        }
                        pbh.NgayLap = cbngaylap.EditValue.ToString();
                        pbh.VAT = txtvat.Text;
                        pbh.CK = txtchietkhau.Text;
                        pbh.TongThanhTien = int.Parse(thanhtien.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Phiếu rỗng không thể lưu.", "Cảnh báo Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Phiếu rỗng không thể lưu.", "Cảnh báo Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        CT_PhieuBanHangDTO ctpbh = new CT_PhieuBanHangDTO();
        public class SanPhamPhu
        {
            public string ma;
            public int soluong;
        }

        string masploi;
        private int ThemChiTietPhieuBanHangHoa()
        {
            if(isUpdate == 1)
            {
                PhieuBanHangBUS.XoaCT_PhieuBanHangTheoMa(pbh.MaPBH, khohang_cn);
            }
            for (int i = 0; i < grvrootbanhang.RowCount - 1; i++)
            {

                ctpbh.ViTri = i;
                ctpbh.MaPhieuBanHang = txtmaphieubh.Text;
                ctpbh.MaSanPham = grvrootbanhang.GetRowCellValue(i, "Mã Hàng").ToString();
                //  sp.ma = grvrootbanhang.GetRowCellValue(i, "Mã Hàng").ToString();
                ctpbh.TenSanPham = grvrootbanhang.GetRowCellValue(i, "Tên Hàng").ToString();
                ctpbh.SoLuong = int.Parse(grvrootbanhang.GetRowCellValue(i, "Số Lượng").ToString());
                //sp.soluong = int.Parse(grvrootbanhang.GetRowCellValue(i, "Số Lượng").ToString());
                ctpbh.DonVi = grvrootbanhang.GetRowCellValue(i, "Đơn Vị").ToString();
                ctpbh.DonGia = float.Parse(grvrootbanhang.GetRowCellValue(i, "Đơn Giá").ToString());
                ctpbh.ChietKhau = float.Parse(grvrootbanhang.GetRowCellValue(i, "Chiết Khấu").ToString());
                ctpbh.ThanhToan = float.Parse(grvrootbanhang.GetRowCellValue(i, "Thanh Toán").ToString());
                ctpbh.LoaiGia = int.Parse(grvrootbanhang.GetRowCellValue(i, "Loại Giá").ToString());
                ctpbh.CK = float.Parse(grvrootbanhang.GetRowCellValue(i, "CK").ToString());
                ctpbh.ThanhTien = float.Parse(grvrootbanhang.GetRowCellValue(i, "Thành Tiền").ToString());
                MuaHangBUS muaHangBUS = new MuaHangBUS();
                if(isUpdate == 1)
                {
                    PhieuBanHangBUS.TaoHangHoaMoiChoKho(ctpbh.MaSanPham, 0, pbh.MaKho, ctpbh.TenSanPham);
                }
                if (PhieuBanHangBUS.ThemCT_PhieuBanHang(ctpbh) > 0)
                {
                    // cập nhật lại số lượng
                    PhieuBanHangBUS.CapNhatSoLuongHangHoa(ctpbh.MaSanPham, ctpbh.SoLuong, pbh.MaKho);
                }
                else
                {
                    return 0;
                }
            }
            return 1;
        }
        class SanPhamCu
        {
            public string masp;
            public int soluong;
            public int thutu;
        }
        public int KiemTraDanhSachBanCoVuotTonKhoToiThieu()
        {
            for (int i = 0; i < grvrootbanhang.RowCount - 1; i++)
            {
                SanPhamPhu sp = new SanPhamPhu();
                try
                {
                    int temp = PhieuBanHangBUS.KiemTraHangHoaBanCoVuotTonKhoToiThieu(grvrootbanhang.GetRowCellValue(i, "Mã Hàng").ToString(), int.Parse(grvrootbanhang.GetRowCellValue(i, "Số Lượng").ToString()), cbkhocongty.EditValue.ToString(), grvrootbanhang.GetRowCellValue(i, "Tên Hàng").ToString());
                    if(temp == 0)
                    {
                        masploi = grvrootbanhang.GetRowCellValue(i, "Mã Hàng").ToString();
                        return 0;
                    }
                    CT_PhieuBanHangDTO ctpbh = new CT_PhieuBanHangDTO();
                    ctpbh.ViTri = i;
                    ctpbh.MaPhieuBanHang = txtmaphieubh.Text;
                    ctpbh.MaSanPham = grvrootbanhang.GetRowCellValue(i, "Mã Hàng").ToString();
                    //  sp.ma = grvrootbanhang.GetRowCellValue(i, "Mã Hàng").ToString();
                    ctpbh.TenSanPham = grvrootbanhang.GetRowCellValue(i, "Tên Hàng").ToString();
                    ctpbh.SoLuong = int.Parse(grvrootbanhang.GetRowCellValue(i, "Số Lượng").ToString());
                    //sp.soluong = int.Parse(grvrootbanhang.GetRowCellValue(i, "Số Lượng").ToString());
                    ctpbh.DonVi = grvrootbanhang.GetRowCellValue(i, "Đơn Vị").ToString();
                    ctpbh.DonGia = float.Parse(grvrootbanhang.GetRowCellValue(i, "Đơn Giá").ToString());
                    ctpbh.ChietKhau = float.Parse(grvrootbanhang.GetRowCellValue(i, "Chiết Khấu").ToString());
                    ctpbh.ThanhToan = float.Parse(grvrootbanhang.GetRowCellValue(i, "Thanh Toán").ToString());
                    ctpbh.LoaiGia = int.Parse(grvrootbanhang.GetRowCellValue(i, "Loại Giá").ToString());
                    ctpbh.CK = float.Parse(grvrootbanhang.GetRowCellValue(i, "CK").ToString());
                    ctpbh.ThanhTien = float.Parse(grvrootbanhang.GetRowCellValue(i, "Thành Tiền").ToString());
                }
                catch{ return -1; }
           }
            return 1;
        }
        private void btnluuvathem_Click(object sender, EventArgs e)
        {
            if (KiemTraDanhSachBanCoVuotTonKhoToiThieu() > 0)
            {
                if (isUpdate == 0)
                {
                    if (SetGiaTriChoPhieuBanHang())
                    {
                        if (PhieuBanHangBUS.ThemPhieuBanHang(pbh) > 0)
                        {
                            int temp = ThemChiTietPhieuBanHangHoa();
                            if (temp == 1)
                            {
                                txtmaphieubh.Text = PhieuBanHangBUS.PhatSinhMaPhieuBH(tentkdn);
                                LayThongTinHangHoa();
                                txttienhoantra.EditValue = "0";
                                txttienthue.EditValue = "0";
                                txtthanhtien.EditValue = "0";
                                txtvat.Text = "0 %";
                                grvbanhang.DataSource = PhieuBanHangBUS.LayThongTinCT_PhieuMuaHangAo();
                                MessageBox.Show("Thêm phiếu bán hàng thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm chi tiết phiếu bán hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thêm phiếu bán hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    isUpdate = 0;
                }
                if (isUpdate == 1)
                {
                    // set giá trị cho phiêu bán hàng
                    if (SetGiaTriChoPhieuBanHang())
                    {
                        if (PhieuBanHangBUS.CapNhatPhieuBanHang(pbh) > 0)
                        {
                            int temp = ThemChiTietPhieuBanHangHoa();
                            if (temp == 1)
                            {
                                txtmaphieubh.Text = PhieuBanHangBUS.PhatSinhMaPhieuBH(tentkdn);
                                LayThongTinHangHoa();
                                grvbanhang.DataSource = PhieuBanHangBUS.LayThongTinCT_PhieuMuaHangAo();
                                khohang_cn = pbh.MaKho;
                                MessageBox.Show("Cập nhật phiếu bán hàng thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật chi tiết phiếu bán hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật phiếu bán hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu bán hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    isUpdate = 1;
                }
            }
            else if(KiemTraDanhSachBanCoVuotTonKhoToiThieu() == 0)
            {
                MessageBox.Show("Mã " + masploi + " Bán Vượt Tồn Kho Tối Thiểu Của Hàng Hóa Đó.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(KiemTraDanhSachBanCoVuotTonKhoToiThieu() == -1)
            {
                MessageBox.Show("Dữ liệu đầu vào không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            DongThanhCong();
        }

        private void gridlookupmahang_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
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

        private void btnin_Click(object sender, EventArgs e)
        {
        }

        private void grvbanhang_MouseClick(object sender, MouseEventArgs e)
        {
            TinhTien();
        }

        private void grvrootbanhang_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            TinhTien();
        }

        private void btnnaplai_Click(object sender, EventArgs e)
        {
            LayThongTinHangHoa();
        }

        private void grvrootbanhang_ShownEditor(object sender, EventArgs e)
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
    }
}
