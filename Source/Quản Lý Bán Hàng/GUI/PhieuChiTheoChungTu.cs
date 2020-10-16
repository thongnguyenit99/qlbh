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
using Quan_Ly_Ban_Hang.DTO;

namespace Quan_Ly_Ban_Hang.GUI
{
    public partial class PhieuChiTheoChungTu : DevExpress.XtraEditors.XtraForm
    {
        string maphieu, mancc, makh, diachi;
        DataTable dt;
        int vaitro; // 0 là của phiếu nhập hàng, 1 là phiếu xuất hàng
        PhieuChiTheoChungTuBUS PhieuChiTheoChungTuBUS = new PhieuChiTheoChungTuBUS();
        public delegate void InsertDone();
        DocSoThanhChu DocSoThanhChu = new DocSoThanhChu();
        public event InsertDone whenInsertSuccessed = null;

        private void LayThongTinTheoMaPhieu()
        {
            if(vaitro == 0)// pnh
            {
                dt = PhieuChiTheoChungTuBUS.LayThongTinChungTuTheoMa_PNH(maphieu);
                if (dt.Rows.Count > 0 && dt != null)
                {
                    txtkhachhang.Text = dt.Rows[0]["TenNCC"].ToString();
                    txttheochungtu.Text = dt.Rows[0]["MaPNH"].ToString();
                    txtngay_ct.Text = dt.Rows[0]["NgayLap"].ToString();
                    txtnhanvien.Text = dt.Rows[0]["TenNV"].ToString();
                    txtsotien.Text = dt.Rows[0]["TongThanhTien"].ToString();
                    txtdatra.Text = dt.Rows[0]["TongThanhTien"].ToString(); 
                    txtconno.Text = dt.Rows[0]["TongThanhTien"].ToString();
                    txtphieuchi.Text = PhieuChiTheoChungTuBUS.PhatSinhMaPhieuChi(maphieu, 0);
                    txtngay_pc.Text = DateTime.Now.ToString();
                    diachi = dt.Rows[0]["DiaChi"].ToString();
                    mancc = dt.Rows[0]["MaNCC"].ToString();
                }
            }
            if(vaitro == 1)
            {
                txtnhanvien.ReadOnly = false;
                txtphieuchi.Text = PhieuChiTheoChungTuBUS.PhatSinhMaPhieuThu(maphieu, 0);
                txtnhanvien.Properties.DataSource = PhieuChiTheoChungTuBUS.LayThongTinNhanVien();
                txtnhanvien.Properties.DisplayMember = "Tên";
                txtnhanvien.Properties.ValueMember = "Tên";
                txtngay_pc.Text = DateTime.Now.ToString();
                dt = PhieuChiTheoChungTuBUS.LayThongTinPhieuBanHangTheoMa(maphieu);
                if (dt.Rows.Count > 0 && dt != null)
                {
                    txtkhachhang.Text = dt.Rows[0]["TenKH"].ToString();
                    txttheochungtu.Text = dt.Rows[0]["MaPBH"].ToString();
                    txtngay_ct.Text = dt.Rows[0]["NgayLap"].ToString();
                    txtnhanvien.EditValue = dt.Rows[0]["TenNV"].ToString();
                    txtsotien.Text = dt.Rows[0]["TongThanhTien"].ToString();
                    txtdatra.Text = dt.Rows[0]["TongThanhTien"].ToString();
                    txtconno.Text = dt.Rows[0]["TongThanhTien"].ToString();
                    txtngay_pc.Text = DateTime.Now.ToString();
                    makh = dt.Rows[0]["MaKH"].ToString();
                }
            }
        }
        public PhieuChiTheoChungTu(string mapnh, int vt)
        {
            InitializeComponent();
            txtngay_pc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            txtngay_pc.Properties.Mask.EditMask = "dd/MM/yyyy";
            txtngay_pc.Properties.Mask.UseMaskAsDisplayFormat = true;
            txtngay_ct.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            txtngay_ct.Properties.Mask.EditMask = "dd/MM/yyyy";
            txtngay_ct.Properties.Mask.UseMaskAsDisplayFormat = true;
            maphieu = mapnh;
            vaitro = vt;

            // load data
            LayThongTinTheoMaPhieu();
        }

        private void txtnhanvien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (vaitro == 0)
            {
                if (PhieuChiTheoChungTuBUS.KiemTraMaPCDaTonTai(txtphieuchi.Text) < 1)
                {
                    if (PhieuChiTheoChungTuBUS.LuuThongTinPhieuChi(txtphieuchi.Text, maphieu, txtngay_pc.EditValue.ToString(), mancc, txtkhachhang.Text, float.Parse(txtsotien.Text.ToString()), txtghichu.Text) > 0)
                    {
                        whenInsertSuccessed();
                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn in không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            PrintPreView printPreView = new PrintPreView(txtkhachhang.Text, diachi, txtghichu.Text, float.Parse(txtsotien.Text.ToString()),DocSoThanhChu.So_chu(Double.Parse(txtsotien.Text.ToString())) , txttheochungtu.Text, txtphieuchi.Text, txtnhanvien.EditValue.ToString(), vaitro);
                            printPreView.ShowDialog();
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Lưu Thông tin Phiếu Chi Thất Bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Random rnd = new Random();
                    int temp = rnd.Next(1, 100000);
                    txtphieuchi.Text = PhieuChiTheoChungTuBUS.PhatSinhMaPhieuChi(maphieu, temp);
                    MessageBox.Show("Mã Phiếu Chi Đã Tồn Tại, đã phát sinh mã phiếu mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (vaitro == 1)
            {
                if(PhieuChiTheoChungTuBUS.KiemTraMaPhieuThuDaTonTai(txtphieuchi.Text) < 1)
                {
                    if (PhieuChiTheoChungTuBUS.LuuThongTinPhieuThu(txtphieuchi.Text, maphieu, txtngay_pc.EditValue.ToString(), makh, txtkhachhang.Text, float.Parse(txtsotien.Text.ToString()), txtghichu.Text) > 0)
                    {
                        whenInsertSuccessed();
                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn in không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            PrintPreView printPreView = new PrintPreView(txtkhachhang.Text, diachi, txtghichu.Text, float.Parse(txtsotien.Text.ToString()), DocSoThanhChu.So_chu(Double.Parse(txtsotien.Text.ToString())), txttheochungtu.Text, txtphieuchi.Text, txtnhanvien.EditValue.ToString(), vaitro);
                            printPreView.ShowDialog();
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Lưu Thông tin Phiếu Thu Thất Bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mã Phiếu Thu Đã Tồn Tại, Đã Phát Sinh Mã Mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Random rnd = new Random();
                    int temp = rnd.Next(1, 100000);
                    txtphieuchi.Text = PhieuChiTheoChungTuBUS.PhatSinhMaPhieuChi(maphieu, temp);
                }
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            PrintPreView printPreView = new PrintPreView(txtkhachhang.Text, diachi, txtghichu.Text, float.Parse(txtsotien.Text.ToString()), DocSoThanhChu.So_chu(Double.Parse(txtsotien.Text.ToString())), txttheochungtu.Text, txtphieuchi.Text, txtnhanvien.EditValue.ToString(), vaitro);
            printPreView.ShowDialog();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}