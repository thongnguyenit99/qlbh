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
using Quan_Ly_Ban_Hang.BUS;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class UC_BanHang_TheoHangHoa : DevExpress.XtraEditors.XtraUserControl
    {
        TheoHangHoa_PNH_BUS TheoHangHoa_PNH_BUS = new TheoHangHoa_PNH_BUS();
        UC_BanHang_TheoHangHoaBUS UC_BanHang_TheoHangHoaBUS = new UC_BanHang_TheoHangHoaBUS();
        DataTable dt;

        public delegate void SuaChua();
        public event SuaChua SuaChuaThanhCong = null;

        public delegate void TaoMoi();
        public event SuaChua TaoMoiThanhCong = null;

        public delegate void Dong(string temp);
        public event SuaChua DongThanhCong = null;
        UC_BanHang_TheoChungTuBUS UC_BanHang_TheoChungTuBUS = new UC_BanHang_TheoChungTuBUS();

        int[] songaycuathang = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public class NCC
        {
            public string Ten { get; set; }
            public string Ma { get; set; }
        }
        private void NapDuLieuChoNhaCungCap()
        {
            BindingList<NCC> ds = new BindingList<NCC>();
            dt = UC_BanHang_TheoChungTuBUS.LayThongTinKhachHang();
            if (dt.Rows.Count > 0)
            {
                NCC ncc1 = new NCC();
                ncc1.Ten = "Tất cả";
                ncc1.Ma = "All";
                ds.Add(ncc1);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NCC ncc = new NCC();
                    ncc.Ten = dt.Rows[i]["Tên Khách Hàng"].ToString();
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
        public UC_BanHang_TheoHangHoa()
        {
            InitializeComponent();
            GridColumn column = grvrootTheoHangHoa.Columns["SoLuong"];
            column.SummaryItem.SummaryType = SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0}";
            GridColumn column1 = grvrootTheoHangHoa.Columns["ThanhTien"];
            column1.SummaryItem.SummaryType = SummaryItemType.Sum;
            column1.SummaryItem.DisplayFormat = "{0}";
            KiemTraNamNhuan(int.Parse(DateTime.Today.Year.ToString("0000")));
            NapDuLieuChoNhaCungCap();
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
            cbluachon.SelectedIndex = 0;
            LoadDaTa();
        }
        private void LoadDaTa()
        {
           grvcttheohanghoa.DataSource = UC_BanHang_TheoHangHoaBUS.LayThongTinPhieuNhapHangTheoHangHoa(txttungay.EditValue.ToString(), txtdenngay.EditValue.ToString());
        }
        private void cbluachon_SelectedValueChanged(object sender, EventArgs e)
        {
            SetUpdateNgay();
        }

        private void cbxemtatca_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            if (cbxemtatca.EditValue.ToString() == "All")
                LoadDaTa();
            else
            {
                grvcttheohanghoa.DataSource = UC_BanHang_TheoHangHoaBUS.LayThongTinPhieuNhapHangTheoHangHoa_MaKH(txttungay.EditValue.ToString(), txtdenngay.EditValue.ToString(), cbxemtatca.EditValue.ToString());
            }
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            TaoMoiThanhCong();
        }

        private void btnsuachua_Click(object sender, EventArgs e)
        {
            int i = 1;
            try
            {
                string temp = grvrootTheoHangHoa.GetRowCellValue(grvrootTheoHangHoa.FocusedRowHandle, "ChungTu").ToString();
            }
            catch
            {
                i = -1;
            }
            if (i == 1)
            {
                GlobalVar.MaPBH = grvrootTheoHangHoa.GetRowCellValue(grvrootTheoHangHoa.FocusedRowHandle, "ChungTu").ToString();
                SuaChuaThanhCong();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DongThanhCong();
        }
        int i = 0;
        private void btnxuat_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                grvrootTheoHangHoa.ExportToXlsx(fbd.SelectedPath + "\\BanHang_TheoHangHoa" + i + ".xlsx");
                i++;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = UC_BanHang_TheoChungTuBUS.XoaThongTinPhieuBanHang(grvrootTheoHangHoa.GetRowCellValue(grvrootTheoHangHoa.FocusedRowHandle, "ChungTu").ToString(), grvrootTheoHangHoa.GetRowCellValue(grvrootTheoHangHoa.FocusedRowHandle, "KhoHang").ToString());
                if (temp > 0)
                {
                    MessageBox.Show("Xóa phiếu mua hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDaTa();
                }
                if (temp == -1)
                {
                    MessageBox.Show("Phiếu mua hàng này đã có phiếu thu, không thể xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (temp == 0)
                {
                    MessageBox.Show("Xóa phiếu mua hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }
    }
}
