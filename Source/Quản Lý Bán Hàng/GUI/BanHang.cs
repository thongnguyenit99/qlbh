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
using Quan_Ly_Ban_Hang.GUI;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class BanHang : DevExpress.XtraEditors.XtraForm
    {
        public string tentkdn;
        public static int tag;
        public BanHang(string tentk)
        {
            tentkdn= tentk;
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            tag = int.Parse(this.Tag.ToString());
            LoadBieuMauBanHang(0);
        }
        UC_PhieuBanHang uC_PhieuBanHang = new UC_PhieuBanHang(GlobalVar.tendn, tag);
        private void LoadBieuMauBanHang(int chucnang)
        // 1: Tải thông tin hàng hóa , 2: Tải lại dữ liệu khách hàng ,3: Tải lại dữ liệu kho hàng
        {
            navBarGroup3.Visible = true;
            uC_PhieuBanHang.DongThanhCong += CloseForm;
            if (chucnang == 0)
            {
                uC_PhieuBanHang.Dock = DockStyle.Fill;
                uc_banhang.Controls.Clear();
                uc_banhang.Controls.Add(uC_PhieuBanHang);
            }
            if (chucnang == -1)
            {
                uC_PhieuBanHang.Dock = DockStyle.Fill;
                uC_PhieuBanHang.ThucThiKhiCapNhat();
                uc_banhang.Controls.Clear();
                uc_banhang.Controls.Add(uC_PhieuBanHang);
            }
            if (chucnang == 1)
            {
                uC_PhieuBanHang.LayThongTinHangHoa();
            }
            if (chucnang == 2)
            {
                uC_PhieuBanHang.LoaddataTenKhachHang();
            }

            if (chucnang == 3)
            {
                uC_PhieuBanHang.LoadKhoHang();
            }
        }

        private void navBarItemPBH_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadBieuMauBanHang(0);
        }
        private void ThucThiKhiUpdate()
        {
            LoadBieuMauBanHang(-1);
        }
        private void TaiBieuMauBanHangTheoChungTu()
        {
            navBarGroup3.Visible = false;
            UC_BanHang_TheoChungTu uC_BanHang_TheoChungTu = new UC_BanHang_TheoChungTu();
            uC_BanHang_TheoChungTu.Dock = DockStyle.Fill;
            uC_BanHang_TheoChungTu.DongThanhCong += CloseForm;
            uC_BanHang_TheoChungTu.TaoMoiThanhCong += LoadBieuMauBanHang_tam;
            uC_BanHang_TheoChungTu.SuaChuaThanhCong += ThucThiKhiUpdate;
            uc_banhang.Controls.Clear();
            uc_banhang.Controls.Add(uC_BanHang_TheoChungTu);
        }
        private void TaiBieuMauBanHangTheoHangHoa()
        {
            navBarGroup3.Visible = false;
            UC_BanHang_TheoHangHoa uC_BanHang_TheoHangHoa = new UC_BanHang_TheoHangHoa();
            uC_BanHang_TheoHangHoa.Dock = DockStyle.Fill;
            uC_BanHang_TheoHangHoa.DongThanhCong += CloseForm;
            uC_BanHang_TheoHangHoa.TaoMoiThanhCong += LoadBieuMauBanHang_tam;
            uC_BanHang_TheoHangHoa.SuaChuaThanhCong += ThucThiKhiUpdate;
            uc_banhang.Controls.Clear();
            uc_banhang.Controls.Add(uC_BanHang_TheoHangHoa);
        }
        private void LoadBieuMauBanHang_tam()
        {
            LoadBieuMauBanHang(0);
        }

        private void navBarItemTCT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaiBieuMauBanHangTheoChungTu();
        }
        private void navBarItemTheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TaiBieuMauBanHangTheoHangHoa();
        }
        private void TaiLaiHangHoa()
        {
            LoadBieuMauBanHang(1);
        }
        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CapNhatHangHoa capNhatHangHoa = new CapNhatHangHoa("-1");
            capNhatHangHoa.whenInsertSuccessed += TaiLaiHangHoa;
            capNhatHangHoa.ShowDialog();
        }
        private void TaiLaiKhachHang()
        {
            LoadBieuMauBanHang(2);
        }
        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CapNhatKhachHang capNhatKhachHang = new CapNhatKhachHang("-1");
            capNhatKhachHang.whenInsertSuccessed += TaiLaiKhachHang;
            capNhatKhachHang.ShowDialog();
        }
        private void TaiLaiKhohang()
        {
            LoadBieuMauBanHang(3);
        }
        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CapNhatKhoHang capNhatKhoHang = new CapNhatKhoHang("-1");
            capNhatKhoHang.whenInsertSuccessed += TaiLaiKhohang;
            capNhatKhoHang.ShowDialog();
        }
        private void CloseForm()
        {
            this.Close();
        }
    }
}