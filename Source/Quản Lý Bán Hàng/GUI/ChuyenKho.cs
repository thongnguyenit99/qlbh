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
    public partial class ChuyenKho : DevExpress.XtraEditors.XtraForm
    {
        public ChuyenKho()
        {
            InitializeComponent();
        }
        UC_PhieuChuyenKho uC_PhieuChuyenKho = new UC_PhieuChuyenKho();
        private void ChuyenKho_Load(object sender, EventArgs e)
        {
            LoadPhieuChuyenKho();
        }
        private void DongBieuMau()
        {
            this.Close();
        }
        private void LoadPhieuChuyenKho()
        {
            userct_chuyenkho.Controls.Clear();
            uC_PhieuChuyenKho.Dock = DockStyle.Fill;
            uC_PhieuChuyenKho.DongThanhCong += DongBieuMau;
            userct_chuyenkho.Controls.Add(uC_PhieuChuyenKho);
        }

        private void nbgHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CapNhatHangHoa capNhatHangHoa = new CapNhatHangHoa("-1");
            capNhatHangHoa.whenInsertSuccessed += uC_PhieuChuyenKho.LoadDanhSachSanPham;
            capNhatHangHoa.ShowDialog();
        }

        private void nbgKhoHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CapNhatKhoHang capNhatKhoHang = new CapNhatKhoHang("-1");
            capNhatKhoHang.whenInsertSuccessed += uC_PhieuChuyenKho.LoadKhoHang;
            capNhatKhoHang.ShowDialog();
        }

        private void nbgNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CapNhatNhanVien capNhatNhanVien = new CapNhatNhanVien("-1");
            capNhatNhanVien.whenInsertSuccessed += uC_PhieuChuyenKho.LoadNhanVien;
            capNhatNhanVien.ShowDialog();
        }

        private void nbgTheoChungTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UC_PhieuChuyenKho_TCT uC_PhieuChuyenKho_TCT = new UC_PhieuChuyenKho_TCT();
            userct_chuyenkho.Controls.Clear();
            uC_PhieuChuyenKho_TCT.Dock = DockStyle.Fill;
            userct_chuyenkho.Controls.Add(uC_PhieuChuyenKho_TCT);
        }

        private void nbgTheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UC_PhieuChuyenKho_THH uC_PhieuChuyenKho_THH = new UC_PhieuChuyenKho_THH();
            userct_chuyenkho.Controls.Clear();
            uC_PhieuChuyenKho_THH.Dock = DockStyle.Fill;
            userct_chuyenkho.Controls.Add(uC_PhieuChuyenKho_THH);
        }

        private void nbgphieuchuyenkho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadPhieuChuyenKho();
        }
    }
}