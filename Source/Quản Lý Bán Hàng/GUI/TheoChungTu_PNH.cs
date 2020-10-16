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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using Quan_Ly_Ban_Hang.DTO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Export.Xl;
using DevExpress.XtraGrid;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class TheoChungTu_PNH : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SuaChua();
        public event SuaChua SuaChuaThanhCong = null;

        public delegate void TaoMoi();
        public event SuaChua TaoMoiThanhCong = null;

        public delegate void Dong(string temp);
        public event SuaChua DongThanhCong = null;

        DataTable dt;
        List<TheoChungTu_PNH_DTO> lst;
        List<TheoChungTuCT_PNH_DTO> lst_pnhct;

        TheoChungTu_PNH_BUS TheoChungTu_PNH_BUS = new TheoChungTu_PNH_BUS();

        int[] songaycuathang = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public TheoChungTu_PNH()
        {
            InitializeComponent();
        }

        List<string> lstluachon = new List<string>();
        private void TaoBangLuaChon()
        {
            lstluachon.Add("Tùy chọn");
            lstluachon.Add("Hôm nay");
            lstluachon.Add("Tuần này");
            lstluachon.Add("Tháng này");
            lstluachon.Add("Quý này");
            lstluachon.Add("Tháng 1");
            lstluachon.Add("Tháng 2");
            lstluachon.Add("Tháng 3");
            lstluachon.Add("Tháng 4");
            lstluachon.Add("Tháng 5");
            lstluachon.Add("Tháng 6");
            lstluachon.Add("Tháng 7");
            lstluachon.Add("Tháng 8");
            lstluachon.Add("Tháng 9");
            lstluachon.Add("Tháng 10");
            lstluachon.Add("Tháng 11");
            lstluachon.Add("Tháng 12");
            lstluachon.Add("Quý 1");
            lstluachon.Add("Quý 2");
            lstluachon.Add("Quý 3");
            lstluachon.Add("Quý 4");
        }
        public class NCC
        {
            public string Ten { get; set; }
            public string Ma { get; set; }
        }
        private void NapDuLieuChoNhaCungCap()
        {
            BindingList<NCC> ds = new BindingList<NCC>();
            dt = TheoChungTu_PNH_BUS.LayThongTinNhaCungCap();
            if(dt.Rows.Count > 0)
            {
                NCC ncc1 = new NCC();
                ncc1.Ten = "Tất cả";
                ncc1.Ma = "All";
                ds.Add(ncc1);
                for (int i = 0; i < dt.Rows.Count;i++)
                {
                    NCC ncc = new NCC();
                    ncc.Ten = dt.Rows[i]["Ten"].ToString();
                    ncc.Ma = dt.Rows[i]["Ma"].ToString();
                    ds.Add(ncc);
                }
                cbxemtatca.Properties.DataSource = ds;
                cbxemtatca.Properties.DisplayMember = "Ten";
                cbxemtatca.Properties.ValueMember = "Ma";
                cbxemtatca.EditValue = cbxemtatca.Properties.GetKeyValue(0);

            }
        }
        private void KiemTraNamNhuan(int year)
        {

            if (year % 400 == 0)
                songaycuathang[2] = 29;
            if (year % 4 == 0 && year % 100 != 0)
                songaycuathang[2] = 29;
        }
        private void TheoChungTu_PNH_Load(object sender, EventArgs e)
        {
            txttungay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            txttungay.Properties.Mask.EditMask = "dd/MM/yyyy";
            txttungay.Properties.Mask.UseMaskAsDisplayFormat = true;
            txtdenngay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            txtdenngay.Properties.Mask.EditMask = "dd/MM/yyyy";
            txtdenngay.Properties.Mask.UseMaskAsDisplayFormat = true;

            TaoBangLuaChon();
            for (int i = 0; i < lstluachon.Count; i++)
            {
                cbluachon.Properties.Items.Add(lstluachon[i].ToString());
            }
            NapDuLieuChoNhaCungCap();
            cbluachon.SelectedIndex = 0;
            try
            {
                lst = TheoChungTu_PNH_BUS.LayThongTinPhieuNhapHangTheoChungTu(txttungay.EditValue.ToString(), txtdenngay.EditValue.ToString());
                lst_pnhct = TheoChungTu_PNH_BUS.LayThongTinCTPhieuPhapHangTheoChungTu();
                grvtct_pnh.DataSource = lst;
            }
            catch { }
            grvroottct.GroupPanelText = "Kéo cột và thả vào đây để phân loại dữ liệu";

            GridColumn column = grvroottct.Columns["ThanhToan"];
            column.SummaryItem.SummaryType = SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0}";

            grvdetail.ViewCaption = "Chi Tiết Phiếu Nhập Hàng";
            grvdetail.OptionsView.ShowViewCaption = true;
            Font dFont = grvdetail.Appearance.ViewCaption.Font;
            grvdetail.Appearance.ViewCaption.Font = new Font(dFont.FontFamily, 10);

            GridColumn columndt = grvdetail.Columns["ThanhTien"];
            columndt.SummaryItem.SummaryType = SummaryItemType.Sum;
            columndt.SummaryItem.DisplayFormat = "{0}";

            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "ThanhToan";
            item.ShowInGroupColumnFooter = grvroottct.Columns["ThanhToan"];
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0}";
            grvroottct.GroupSummary.Add(item);

        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            if(cbxemtatca.EditValue.ToString() == "All")
            {
               lst = TheoChungTu_PNH_BUS.LayThongTinPhieuNhapHangTheoChungTu(txttungay.EditValue.ToString(), txtdenngay.EditValue.ToString());
                grvtct_pnh.DataSource = lst;
            }
            else
            {
                lst = TheoChungTu_PNH_BUS.LayThongTinPhieuNhapHangTheoChungTu_MNCC(txttungay.EditValue.ToString(), txtdenngay.EditValue.ToString(), cbxemtatca.EditValue.ToString());
                grvtct_pnh.DataSource = lst;
            }
        }
        private void SetNgayTheoQuy(int quy)
        {
            if (quy == 1)
            {
                txttungay.Text = "01/" + "01" + "/" + DateTime.Today.Year.ToString("0000");
                txtdenngay.Text = "03" + "/" + songaycuathang[3] + "/" + DateTime.Today.Year.ToString("0000");
            }
            if (quy == 2)
            {
                txttungay.Text = "04/" + "01" + "/" + DateTime.Today.Year.ToString("0000");
                txtdenngay.Text = "06" + "/" + songaycuathang[6].ToString() + "/" + DateTime.Today.Year.ToString("0000");
            }
            if (quy == 3)
            {
                txttungay.Text = "01/" + "07" + "/" + DateTime.Today.Year.ToString("0000");
                txtdenngay.Text = "09" + "/" + songaycuathang[9].ToString() + "/" + DateTime.Today.Year.ToString("0000");
            }
            if (quy == 4)
            {
                txttungay.Text = "10/" + "01" + "/" + DateTime.Today.Year.ToString("0000");
                txtdenngay.Text = "12" + "/" + songaycuathang[12].ToString() + "/" + DateTime.Today.Year.ToString("0000");
            }
        }
        private void SetUpdateNgay()
        {
            if (cbluachon.EditValue.ToString() == "Hôm nay")
            {
                string temp = DateTime.Now.ToString();
                string[] ngay = temp.Split(' ');
                txttungay.Text = ngay[0];
                txtdenngay.Text = ngay[0];
            }
            if (cbluachon.EditValue.ToString() == "Tuần này")
            {
                double sday = double.Parse(DateTime.Now.Day.ToString("00"));
                int day = (int)((sday / 7) + 0.8);
                if (day <= 1)
                {
                    txttungay.Text = DateTime.Today.Month.ToString("00") + "/01" + "/" + DateTime.Today.Year.ToString("0000");
                    txtdenngay.Text = DateTime.Today.Month.ToString("00") + "/07" + "/" + DateTime.Today.Year.ToString("0000");
                }
                if (day == 2)
                {
                    txttungay.Text = DateTime.Today.Month.ToString("00") + "/08" + "/" + DateTime.Today.Year.ToString("0000");
                    txtdenngay.Text = DateTime.Today.Month.ToString("00") + "/15" + "/" + DateTime.Today.Year.ToString("0000");
                }
                if (day == 3)
                {
                    txttungay.Text = DateTime.Today.Month.ToString("00") + "/16" + "/" + DateTime.Today.Year.ToString("0000");
                    txtdenngay.Text = DateTime.Today.Month.ToString("00") + "/24" + "/" + DateTime.Today.Year.ToString("0000");
                }
                if (day == 4 || sday > 25)
                {
                    txttungay.Text = DateTime.Today.Month.ToString("00") + "/25" + "/" + DateTime.Today.Year.ToString("0000");
                    txtdenngay.Text = DateTime.Today.Month.ToString("00") + "/" + songaycuathang[int.Parse(DateTime.Today.Month.ToString("00"))].ToString() + "/" + DateTime.Today.Year.ToString("0000");
                }
            }
            if (cbluachon.EditValue.ToString() == "Tháng này" || cbluachon.EditValue.ToString() == "Tùy chọn")
            {
                txttungay.Text = DateTime.Today.Month.ToString("00") + "/01" + "/" + DateTime.Today.Year.ToString("0000");
                txtdenngay.Text = DateTime.Today.Month.ToString("00") + "/" + songaycuathang[int.Parse(DateTime.Today.Month.ToString("00"))] + "/" + DateTime.Today.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Quý này")
            {
                double smonth = double.Parse(DateTime.Now.Month.ToString("00"));
                int quy = (int)((smonth / 3) + 0.9);
                SetNgayTheoQuy(quy);
            }
            if (cbluachon.EditValue.ToString() == "Tháng 1")
            {
                txttungay.Text = "01/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "01" + "/" + songaycuathang[1] + "/" + DateTime.Now.Year.ToString("0000"); 
            }
            if (cbluachon.EditValue.ToString() == "Tháng 2")
            {
                txttungay.Text = "02/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "02" + "/" + songaycuathang[2] + "/" + DateTime.Now.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Tháng 3")
            {
                txttungay.Text = "03/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "03" + "/" + songaycuathang[3] + "/" + DateTime.Now.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Tháng 4")
            {
                txttungay.Text = "04/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "04" + "/" + songaycuathang[4] + "/" + DateTime.Now.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Tháng 5")
            {
                txttungay.Text = "05/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "05" + "/" + songaycuathang[5] + "/" + DateTime.Now.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Tháng 6")
            {
                txttungay.Text = "06/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "06" + "/" + songaycuathang[6] + "/" + DateTime.Now.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Tháng 7")
            {
                txttungay.Text = "07/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "07" + "/" + songaycuathang[7] + "/" + DateTime.Now.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Tháng 8")
            {
                txttungay.Text = "08/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "08" + "/" + songaycuathang[8] + "/" + DateTime.Now.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Tháng 9")
            {
                txttungay.Text = "09/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "09" + "/" + songaycuathang[9] + "/" + DateTime.Now.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Tháng 10")
            {
                txttungay.Text = "10/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "10" + "/" + songaycuathang[10] + "/" + DateTime.Now.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Tháng 11")
            {
                txttungay.Text = "11/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "11" + "/" + songaycuathang[11] + "/" + DateTime.Now.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Tháng 12")
            {
                txttungay.Text = "12/01/" + DateTime.Now.Year.ToString("0000");
                txtdenngay.Text = "12" + "/" + songaycuathang[12] + "/" + DateTime.Now.Year.ToString("0000");
            }
            if (cbluachon.EditValue.ToString() == "Quý 1")
            {
                SetNgayTheoQuy(1);
            }
            if (cbluachon.EditValue.ToString() == "Quý 2")
            {
                SetNgayTheoQuy(2);
            }
            if (cbluachon.EditValue.ToString() == "Quý 3")
            {
                SetNgayTheoQuy(3);
            }
            if (cbluachon.EditValue.ToString() == "Quý 4")
            {
                SetNgayTheoQuy(4);
            }
        }
        private void cbluachon_EditValueChanged(object sender, EventArgs e)
        {
            SetUpdateNgay();
        }

        private void txttungay_Validated(object sender, EventArgs e)
        {
            try
            {
                DateTime.ParseExact(txttungay.Text, "dd/MM/yyyy", null);
            }
            catch
            {
                string[] temp = DateTime.Today.ToString().Split(' ');
                txttungay.Text = temp[0];
            }
        }

        private void txtdenngay_Validated(object sender, EventArgs e)
        {
            try
            {
                DateTime.ParseExact(txtdenngay.Text, "dd/MM/yyyy", null);
            }
            catch
            {
                string[] temp = DateTime.Today.ToString().Split(' ');
                txtdenngay.Text = temp[0];
            }
        }

        private void grvroottct_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;
            TheoChungTu_PNH_DTO cat = view.GetRow(e.RowHandle) as TheoChungTu_PNH_DTO;
            if (cat != null)
            {
                e.IsEmpty = !lst_pnhct.Any(x => x.MaPhieuNhapHang == cat.ChungTu);
            }
        }

        private void grvroottct_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;
            TheoChungTu_PNH_DTO cat = view.GetRow(e.RowHandle) as TheoChungTu_PNH_DTO;
            if (cat != null)
            {
                e.ChildList = lst_pnhct.Where(x => x.MaPhieuNhapHang == cat.ChungTu).ToList();
            }
        }

        private void grvroottct_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvroottct_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }

        private void grvroottct_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle < 0)
            {
                if (e.RowHandle == view.FocusedRowHandle)
                {
                    e.Appearance.ForeColor = Color.Red;
                }
                else
                {
                    int parentRowHandle = view.GetParentRowHandle(view.FocusedRowHandle);
                    while (view.IsValidRowHandle(parentRowHandle))
                    {
                        if (parentRowHandle == e.RowHandle)
                        {
                            e.Appearance.ForeColor = Color.Red;
                            e.Appearance.Font = new Font("Tahoma", 11F);
                            e.Appearance.BackColor = Color.AliceBlue;
                            break;
                        }
                        parentRowHandle = view.GetParentRowHandle(parentRowHandle);
                    }
                }
            }
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            TaoMoiThanhCong();
            this.Close();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DongThanhCong();
            this.Close();
        }
        int i = 0;
        private void btnxuat_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                grvroottct.ExportToXlsx(fbd.SelectedPath + "\\BangKeTongHopPNH" + i + ".xlsx");
                i++;
            }
        }

        private void btnsuachua_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvroottct.GetRowCellValue(grvroottct.FocusedRowHandle, "ChungTu").ToString() != "")
                {
                    GlobalVar.MaPNH = grvroottct.GetRowCellValue(grvroottct.FocusedRowHandle, "ChungTu").ToString();
                    GlobalVar.TenNhaCungCap = grvroottct.GetRowCellValue(grvroottct.FocusedRowHandle, "NhaCungCap").ToString();
                    SuaChuaThanhCong();
                    this.Close();
                }
            }
            catch { }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int i = 1;
            try {
                string temp = grvroottct.GetRowCellValue(grvroottct.FocusedRowHandle, "ChungTu").ToString();
            }
            catch
            {
                i = -1;
            }
            if (i == 1)
            {
                int temp = TheoChungTu_PNH_BUS.XoaPhieuNhapHang(grvroottct.GetRowCellValue(grvroottct.FocusedRowHandle, "ChungTu").ToString(), grvroottct.GetRowCellValue(grvroottct.FocusedRowHandle, "KhoHang").ToString());
                if (temp == -1)
                {
                    MessageBox.Show("Chứng Từ này đã có phiếu chi không thể xóa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (temp == 0)
                {
                    MessageBox.Show("Xóa phiếu nhập hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (temp > 0)
                {
                    MessageBox.Show("Xóa phiếu nhập hàng thành công", "Thông Bóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        lst = TheoChungTu_PNH_BUS.LayThongTinPhieuNhapHangTheoChungTu(txttungay.EditValue.ToString(), txtdenngay.EditValue.ToString());
                        lst_pnhct = TheoChungTu_PNH_BUS.LayThongTinCTPhieuPhapHangTheoChungTu();
                        grvtct_pnh.DataSource = lst;
                    }
                    catch { }
                }
            }
        }
    }
}