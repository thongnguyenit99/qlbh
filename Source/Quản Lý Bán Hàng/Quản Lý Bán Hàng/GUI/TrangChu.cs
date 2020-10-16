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

namespace Quản_Lý_Bán_Hàng
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TrangChuBUS trangChuBUS = new TrangChuBUS();
        public TrangChu(int roleId)
        {
            InitializeComponent();
            // Phân quyền trên thanh menubar
            RoleMenubar(roleId);
            //Phân quyền trên các nút trên menubar
            VisiableButton(roleId);
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

        // lấy danh dách cách nút mà tài khoản không có quyền sử dụng sau đó update giao diện
        private void VisiableButton(int roleId)
        {
            DataTable dt = trangChuBUS.GetAllVisiableButton(roleId);
            if (dt.Rows.Count > 0 && dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 5)
                        barbtnketthuc.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 6)
                        barhtthongtin.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 7)
                        barbtnphanquyen.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 8)
                        barbtndoimatkhau.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 9)
                        barbtnnhatkyhethong.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 10)
                        barbtnsaoluu.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 11)
                        barbtnphuchoi.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 12)
                        barbtnsuachua.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 13)
                        barbtnketchuyen.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 14)
                        barbtnnhapdanhmucexcel.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 15)
                        barbtnkhuvuc.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 16)
                        barbtnkhachhang.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 17)
                        barbtnkhohang.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 18)
                        barbtndvtinh.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 19)
                        barbtnnhomhang.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 20)
                        barbtnhanghoa.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 21)
                        barbtnmavach.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 22)
                        barbtntigia.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 23)
                        barbtnbophan.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 24)
                        barbtnnhanvien.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 25)
                        barbtnmuahang.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 26)
                        barbtnbanhang.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 27)
                        barbtntonkho.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 28)
                        barhtthongtin.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 29)
                        barbtnchuyenkho.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 30)
                        barbtntratien.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 31)
                        barbtnthutien.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 32)
                        barbtnbaocaokhohang.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 33)
                        barbtnbaocaokhachhang.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 34)
                        barbtnchungtu.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 35)
                        barbtntrogiup.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 36)
                        barbtnhuongdansudung.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 37)
                        barbtnlienhe.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 38)
                        barbtndangky.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 39)
                        barbtnthongtin.Enabled = false;
                    else if (int.Parse(dt.Rows[i]["ButtonId"].ToString()) == 40)
                        barbtncapnhat.Enabled = false;
                }
            }
        }

        private void Barbtnketthuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Barbtnphanquyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            PhanQuyen phanQuyen = new PhanQuyen();
            phanQuyen.MdiParent = this;
            phanQuyen.Show();
        }

        private void Barbtnmuahang_ItemClick(object sender, ItemClickEventArgs e)
        {
            MuaHang muaHang = new MuaHang();
            muaHang.MdiParent = this;
            muaHang.Show();
        }
    }
}