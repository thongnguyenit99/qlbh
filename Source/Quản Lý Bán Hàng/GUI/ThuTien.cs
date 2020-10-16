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
using Quan_Ly_Ban_Hang.GUI;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class ThuTien : DevExpress.XtraEditors.XtraForm
    {
        public ThuTien()
        {
            InitializeComponent();
            LoadDanhSachPhieuThu();
        }
        private void LoadDanhSachPhieuThu()
        {
            UC_BanHang_DanhSachPhieuThu uC_BanHang_DanhSachPhieuThu = new UC_BanHang_DanhSachPhieuThu();
            uC_BanHang_DanhSachPhieuThu.CloseFormSuccess += DongBieuMau;
            uC_BanHang_DanhSachPhieuThu.Dock = DockStyle.Fill;
            UC_ThuTien.Controls.Clear();
            UC_ThuTien.Controls.Add(uC_BanHang_DanhSachPhieuThu);
        }
        private void LoadDanhSachPhieuThuCongNo()
        {
            UC_BanHang_DanhSachPhieuCongNoChiTiet uC_BanHang_DanhSachPhieuCongNoChiTiet = new UC_BanHang_DanhSachPhieuCongNoChiTiet();
            uC_BanHang_DanhSachPhieuCongNoChiTiet.CloseFormSuccess += DongBieuMau;
            uC_BanHang_DanhSachPhieuCongNoChiTiet.Dock = DockStyle.Fill;
            UC_ThuTien.Controls.Clear();
            UC_ThuTien.Controls.Add(uC_BanHang_DanhSachPhieuCongNoChiTiet);
        }
        private void LoadDanhSachPhieuThuTraNgay()
        {
            UC_BanHang_DanhSachPhieuTraNgay uC_BanHang_DanhSachPhieuTraNgay = new UC_BanHang_DanhSachPhieuTraNgay();
            uC_BanHang_DanhSachPhieuTraNgay.CloseFormSuccess += DongBieuMau;
            uC_BanHang_DanhSachPhieuTraNgay.Dock = DockStyle.Fill;
            UC_ThuTien.Controls.Clear();
            UC_ThuTien.Controls.Add(uC_BanHang_DanhSachPhieuTraNgay);
        }
        private void DongBieuMau()
        {
            this.Close();
        }

        private void navBarItemDSPT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDanhSachPhieuThu();
        }

        private void navBarItemDSPCN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDanhSachPhieuThuCongNo();
        }

        private void navBarItemDSPTN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDanhSachPhieuThuTraNgay();
        }

        private void navBarItemTDCN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItemTHCN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
    }
}