using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Quản_Lý_Bán_Hàng.BUS;
using Quản_Lý_Bán_Hàng.GUI;
using Quan_Ly_Ban_Hang.DTO;
using DevExpress.XtraEditors;

namespace Quản_Lý_Bán_Hàng
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TrangChuBUS trangChuBUS = new TrangChuBUS();
        string taikhoandn;
        int roleID;
        public TrangChu(int roleId, string taikhoan)
        {
            InitializeComponent();
            taikhoandn = taikhoan;
            roleID = roleId;
            // Phân quyền trên thanh menubar
            RoleMenubar(roleId);
            //Phân quyền trên các nút trên menubar
            EnabledButton();
            
        }

        // lấy danh sách các group menu mà tài khoản vừa đăng nhập có quyền gì hiện lên giao diện
        private void RoleMenubar(int roleid)
        {
            DataTable dt = trangChuBUS.GetAllRoleMenuBar(roleid);
            if (dt.Rows.Count > 0 && dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (int.Parse(dt.Rows[i]["MeNuBarId"].ToString()) == 1)
                        Hethong.Visible = true;
                    else if (int.Parse(dt.Rows[i]["MeNuBarId"].ToString()) == 2)
                        Danhmuc.Visible = true;
                    else if (int.Parse(dt.Rows[i]["MeNuBarId"].ToString()) == 3)
                        Chucnang.Visible = true;
                    Trogiup.Visible = true;
                }
            }
        }

        // phần quyền các nút
        private void EnabledButton()
        {
            barhtthongtin.Enabled = GlobalVar.distRoleForm[1].TruyCap;
            barbtnphanquyen.Enabled = GlobalVar.distRoleForm[2].TruyCap;
            barbtndoimatkhau.Enabled = GlobalVar.distRoleForm[3].TruyCap;
            barbtnnhatkyhethong.Enabled = GlobalVar.distRoleForm[4].TruyCap;
            barbtnsaoluu.Enabled = GlobalVar.distRoleForm[5].TruyCap;
            barbtnphuchoi.Enabled = GlobalVar.distRoleForm[6].TruyCap;
            barbtnsuachua.Enabled = GlobalVar.distRoleForm[7].TruyCap;
            barbtnketchuyen.Enabled = GlobalVar.distRoleForm[8].TruyCap;
            barbtnnhapdanhmucexcel.Enabled = GlobalVar.distRoleForm[9].TruyCap;
            barbtnkhuvuc.Enabled = GlobalVar.distRoleForm[10].TruyCap;
            barbtnkhachhang.Enabled = GlobalVar.distRoleForm[11].TruyCap;
            barbtnnhacungcap.Enabled = GlobalVar.distRoleForm[12].TruyCap;
            barbtnkhohang.Enabled = GlobalVar.distRoleForm[13].TruyCap;
            barbtndvtinh.Enabled = GlobalVar.distRoleForm[14].TruyCap;
            barbtnnhomhang.Enabled = GlobalVar.distRoleForm[15].TruyCap;
            barbtnhanghoa.Enabled = GlobalVar.distRoleForm[16].TruyCap;
            barbtnmavach.Enabled = GlobalVar.distRoleForm[17].TruyCap;
            barbtntigia.Enabled = GlobalVar.distRoleForm[18].TruyCap;
            barbtnbophan.Enabled = GlobalVar.distRoleForm[19].TruyCap;
            barbtnnhanvien.Enabled = GlobalVar.distRoleForm[20].TruyCap;
            barbtnmuahang.Enabled = GlobalVar.distRoleForm[21].TruyCap;
            barbtnbanhang.Enabled = GlobalVar.distRoleForm[22].TruyCap;
            barbtntonkho.Enabled = GlobalVar.distRoleForm[23].TruyCap;
            barbtnchuyenkho.Enabled = GlobalVar.distRoleForm[24].TruyCap;
            barbtnnhapsodudauky.Enabled = GlobalVar.distRoleForm[25].TruyCap;
            barbtnthutien.Enabled = GlobalVar.distRoleForm[26].TruyCap;
            barbtntratien.Enabled = GlobalVar.distRoleForm[27].TruyCap;
            barbtnbaocaokhachhang.Enabled = GlobalVar.distRoleForm[28].TruyCap;
            barbtnbaocaokhohang.Enabled = GlobalVar.distRoleForm[29].TruyCap;
            barbtnchungtu.Enabled = GlobalVar.distRoleForm[30].TruyCap;
        }

        private void Barbtnketthuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Barbtnphanquyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            PhanQuyen phanQuyen = new PhanQuyen();
            if (ExistsForm(phanQuyen)) return;
            phanQuyen.MdiParent = this;
            phanQuyen.Show();
        }

        private void Barbtnmuahang_ItemClick(object sender, ItemClickEventArgs e)
        {
            MuaHang muaHang = new MuaHang(taikhoandn);
            if (ExistsForm(muaHang)) return;
            muaHang.MdiParent = this;
            muaHang.Show();
        }

        private void Barbtnkhuvuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhuVuc khuVuc = new KhuVuc();
            if (ExistsForm(khuVuc)) return;
            khuVuc.MdiParent = this;
            khuVuc.Show();
        }

        private void barbtnkhachhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            KhachHang KhachHang = new KhachHang();
            if (ExistsForm(KhachHang)) return;
            KhachHang.MdiParent = this;
            KhachHang.Show();
        }

        private void barbtnnhacungcap_ItemClick(object sender, ItemClickEventArgs e)
        {

            NhaCungCap NhaCungCap = new NhaCungCap();
            if (ExistsForm(NhaCungCap)) return;
            NhaCungCap.MdiParent = this;
            NhaCungCap.Show();

        }

        private void barbtnkhohang_ItemClick(object sender, ItemClickEventArgs e)
        {

            KhoHang KhoHang = new KhoHang();
            if (ExistsForm(KhoHang)) return;
            KhoHang.MdiParent = this;
            KhoHang.Show();
        }

        private void barbtndvtinh_ItemClick(object sender, ItemClickEventArgs e)
        {

            DonViTnh DonViTnh = new DonViTnh();
            if (ExistsForm(DonViTnh)) return;
            DonViTnh.MdiParent = this;
            DonViTnh.Show();
        }

        private void barbtnnhomhang_ItemClick(object sender, ItemClickEventArgs e)
        {

            NhomHang NhomHang = new NhomHang();
            if (ExistsForm(NhomHang)) return;
            NhomHang.MdiParent = this;
            NhomHang.Show();
        }

        private void barbtnhanghoa_ItemClick(object sender, ItemClickEventArgs e)
        {

            HangHoa HangHoa = new HangHoa();
            if (ExistsForm(HangHoa)) return;
            HangHoa.MdiParent = this;
            HangHoa.Show();
        }

        private void barbtntigia_ItemClick(object sender, ItemClickEventArgs e)
        {
            TyGia TyGia = new TyGia();
            if (ExistsForm(TyGia)) return;
            TyGia.MdiParent = this;
            TyGia.Show();
        }

        private void barbtnbophan_ItemClick(object sender, ItemClickEventArgs e)
        {
            BoPhan BoPhan = new BoPhan();
            if (ExistsForm(BoPhan)) return;
            BoPhan.MdiParent = this;
            BoPhan.Show();
        }

        private void barbtnnhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhanVien NhanVien = new NhanVien();
            if (ExistsForm(NhanVien)) return;
            NhanVien.MdiParent = this;
            NhanVien.Show();
        }

        private void barbtnnhapdanhmucexcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhapTuExcel NhapTuExcel = new NhapTuExcel();
            NhapTuExcel.ShowDialog();
        }

        private void barbtnmavach_ItemClick(object sender, ItemClickEventArgs e)
        {
            InMaVach InMaVach = new InMaVach();
            if (ExistsForm(InMaVach)) return;
            InMaVach.MdiParent = this;
            InMaVach.Show();
        }

        private void barbtnbanhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            BanHang BanHang = new BanHang(taikhoandn);
            if (ExistsForm(BanHang)) return;
            BanHang.MdiParent = this;
            BanHang.Show();
        }

        private void barbtntonkho_ItemClick(object sender, ItemClickEventArgs e)
        {
            TonKho TonKho = new TonKho();
            if (ExistsForm(TonKho)) return;
            TonKho.MdiParent = this;
            TonKho.Show();
        }

        private void barbtnchuyenkho_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChuyenKho ChuyenKho = new ChuyenKho();
            if (ExistsForm(ChuyenKho)) return;
            ChuyenKho.MdiParent = this;
            ChuyenKho.Show();
        }

        private void barbtnnhapsodudauky_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhapSoDuDauKy NhapSoDuDauKy = new NhapSoDuDauKy();
            if (ExistsForm(NhapSoDuDauKy)) return;
            NhapSoDuDauKy.MdiParent = this;
            NhapSoDuDauKy.Show();
        }

        private void barbtntratien_ItemClick(object sender, ItemClickEventArgs e)
        {
            TraTien TraTien = new TraTien();
            if (ExistsForm(TraTien)) return;
            TraTien.MdiParent = this;
            TraTien.Show();
        }

        private void barbtnthutien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThuTien ThuTien = new ThuTien();
            if (ExistsForm(ThuTien)) return;
            ThuTien.MdiParent = this;
            ThuTien.Show();
        }

        private void barbtnbaocaokhohang_ItemClick(object sender, ItemClickEventArgs e)
        {
            BaoCaoKhoHang BaoCaoKhoHang = new BaoCaoKhoHang();
            if (ExistsForm(BaoCaoKhoHang)) return;
            BaoCaoKhoHang.MdiParent = this;
            BaoCaoKhoHang.Show();
        }

        private void barbtnbaocaokhachhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            BaoCaoKhachHang BaoCaoKhachHang = new BaoCaoKhachHang();
            if (ExistsForm(BaoCaoKhachHang)) return;
            BaoCaoKhachHang.MdiParent = this;
            BaoCaoKhachHang.Show();
        }

        private void barbtnchungtu_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChungTu ChungTu = new ChungTu();
            if (ExistsForm(ChungTu)) return;
            ChungTu.MdiParent = this;
            ChungTu.Show();
        }

        private void barbtnsaoluu_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaoLuu SaoLuu = new SaoLuu();
            SaoLuu.ShowDialog();
        }

        private void barbtnnhatkyhethong_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhatKyHeThong NhatKyHeThong = new NhatKyHeThong();
            if (ExistsForm(NhatKyHeThong)) return;
            NhatKyHeThong.MdiParent = this;
            NhatKyHeThong.Show();
        }

        private void barbtnsuachua_ItemClick(object sender, ItemClickEventArgs e)
        {
            SuaChua SuaChua = new SuaChua();
            SuaChua.ShowDialog();
        }

        private void barbtnketchuyen_ItemClick(object sender, ItemClickEventArgs e)
        {

            KetChuyen KetChuyen = new KetChuyen();
            KetChuyen.ShowDialog();
        }

        private void barhtthongtin_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongTin ThongTin = new ThongTin();
            ThongTin.ShowDialog();
        }

        private void barbtndoimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoiMatKhau DoiMatKhau = new DoiMatKhau(taikhoandn);
            DoiMatKhau.ShowDialog();
        }

        private void barbtnphuchoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            PhucHoi PhucHoi = new PhucHoi();
            PhucHoi.ShowDialog();
        }
        private bool ExistsForm(XtraForm form)
        {
            foreach(var child in MdiChildren)
            {
                if(child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            barEditItem1.EditValue = System.Environment.MachineName.ToString();
            barStaticItem2.Caption = DateTime.Now.ToString();
        }
    }
}