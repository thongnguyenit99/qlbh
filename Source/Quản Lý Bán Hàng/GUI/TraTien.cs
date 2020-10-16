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
    public partial class TraTien : DevExpress.XtraEditors.XtraForm
    {
        public TraTien()
        {
            InitializeComponent();
        }
        private void LoadDanhSachPhieuChi()
        {
            UC_DanhSachPhieuChi UC_DanhSachPhieuChi = new UC_DanhSachPhieuChi();
            UC_DanhSachPhieuChi.CloseFormSuccess += DongBieuMau;
            UC_DanhSachPhieuChi.Dock = DockStyle.Fill;
            uc_tratien.Controls.Clear();
            uc_tratien.Controls.Add(UC_DanhSachPhieuChi);
        }
        private void TraTien_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieuChi();
        }
        private void LoadDanhSachPhieuCongNoPhaiChi()
        {
            UC_DanhSachPhieuCongNoPhaiChi uC_DanhSachPhieuCongNoPhaiChi = new UC_DanhSachPhieuCongNoPhaiChi();
            uC_DanhSachPhieuCongNoPhaiChi.CloseFormSuccess += DongBieuMau;
            uC_DanhSachPhieuCongNoPhaiChi.Dock = DockStyle.Fill;
            uc_tratien.Controls.Clear();
            uc_tratien.Controls.Add(uC_DanhSachPhieuCongNoPhaiChi);
        }
        private void LoadDanhSachPhieuTraNgay_PhieuChi()
        {
            UC_PhieuChiThanhToanNgay uC_PhieuChiThanhToanNgay = new UC_PhieuChiThanhToanNgay();
            uC_PhieuChiThanhToanNgay.CloseFormSuccess += DongBieuMau;
            uC_PhieuChiThanhToanNgay.Dock = DockStyle.Fill;
            uc_tratien.Controls.Clear();
            uc_tratien.Controls.Add(uC_PhieuChiThanhToanNgay);
        }

        private void DongBieuMau()
        {
            this.Close();
        }

        private void navBarItemDSPCN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDanhSachPhieuCongNoPhaiChi();
        }

        private void navBarItemDSPC_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDanhSachPhieuChi();
        }

        private void navBarItemDSPTN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDanhSachPhieuTraNgay_PhieuChi();
        }

        private void navBarItemTTCN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void navBarItemTHCN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
    }
}