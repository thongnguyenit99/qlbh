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
using Quan_Ly_Ban_Hang.BUS;
using Quan_Ly_Ban_Hang.GUI;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class PhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        int check = 0;
        string temp;
        PhanQuyenBUS phanQuyenBUS = new PhanQuyenBUS();
        NhatKyHeThongBUS nhatKyHeThongBUS = new NhatKyHeThongBUS();
        public PhanQuyen()
        {
            try
            {
                nhatKyHeThongBUS.ThemNhatKyHeThong("Phân quyền", "Xem", "");
            }
            catch
            {

            }
            InitializeComponent();
        }
        private void Loaddata()
        {
            cbvaitroall.DataSource = phanQuyenBUS.getAllRoleUser();
            cbvaitroall.DisplayMember = "RoleName";
            cbvaitroall.ValueMember = "Id";
            temp = cbvaitroall.SelectedValue.ToString();
        }
        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            int formid = int.Parse(this.Tag.ToString());
            btnthemnd.Enabled = GlobalVar.distRoleForm[formid].Them;
            btnthemvt.Enabled = GlobalVar.distRoleForm[formid].Them;
            btnsua.Enabled = GlobalVar.distRoleForm[formid].Sua;
            btnxoa.Enabled = GlobalVar.distRoleForm[formid].Xoa;
            Loaddata();
          
        }

        private void cbvaitroall_SelectedValueChanged(object sender, EventArgs e)
        {
            int n;
            int.TryParse(cbvaitroall.SelectedValue.ToString(), out n);
            if (n > 0)
            {
                gridControl1.DataSource = phanQuyenBUS.getUserName(int.Parse(cbvaitroall.SelectedValue.ToString()));
                gridControl2.DataSource = phanQuyenBUS.getDaTaUser(int.Parse(cbvaitroall.SelectedValue.ToString()));
                gridControl3.DataSource = phanQuyenBUS.getAllRolForm(int.Parse(cbvaitroall.SelectedValue.ToString()));
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            try
            {
                nhatKyHeThongBUS.ThemNhatKyHeThong("Phân quyền", "Thoát", "");
            }
            catch
            {

            }
            this.Close();
        }

        private void btnthemnd_Click(object sender, EventArgs e)
        {
            ThemNguoiDung themNguoiDung = new ThemNguoiDung();
            themNguoiDung.whenInsertSuccessed += Loaddata;
            themNguoiDung.ShowDialog();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if(check == 1 && temp != "1")
            {
                CapNhatNguoiDung capNhatNguoiDung = new CapNhatNguoiDung(temp);
                capNhatNguoiDung.whenInsertSuccessed += Loaddata;
                capNhatNguoiDung.ShowDialog();
            }
            if(check == 0 || check == 2)
            {
                CapNhatVaiTro capNhatVaiTro = new CapNhatVaiTro(check, int.Parse(cbvaitroall.SelectedValue.ToString()));
                capNhatVaiTro.whenInsertSuccessed += Loaddata;
                capNhatVaiTro.ShowDialog();
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            check = 2;
            temp = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "UserName").ToString();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            check = 1;
            temp = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UserName").ToString();
        }

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            check = 0;
            temp = cbvaitroall.SelectedValue.ToString();
        }

        private void btnthemvt_Click(object sender, EventArgs e)
        {
            CapNhatVaiTro capNhatVaiTro = new CapNhatVaiTro(-1, -1);
            capNhatVaiTro.whenInsertSuccessed += Loaddata;
            capNhatVaiTro.ShowDialog();
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            check = 1;
            try
            {
                temp = gridView2.GetRowCellValue(gridView1.FocusedRowHandle, "UserName").ToString();
            }
            catch { }
        }

        private void gridControl2_MouseUp(object sender, MouseEventArgs e)
        {
            check = 2;
            try
            {
                temp = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "UserName").ToString();
            }
            catch { }
        }

        private void gridControl3_MouseUp(object sender, MouseEventArgs e)
        {
            check = 0;
            try
            {
                temp = cbvaitroall.SelectedValue.ToString();
            }
            catch { }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(check == 0 || check == 2)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa  nhóm vai trò này không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    if (int.Parse(cbvaitroall.SelectedValue.ToString()) == 1)
                    {
                        MessageBox.Show("Không thể xóa nhóm vai trò admin.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            phanQuyenBUS.XoaVaiTro(int.Parse(cbvaitroall.SelectedValue.ToString()));
                            nhatKyHeThongBUS.ThemNhatKyHeThong("Phân quyền", "Xóa vai trò", cbvaitroall.SelectedValue.ToString());
                            Loaddata();
                        }
                        catch
                        {

                        }
                    }
                }
            }
            if(check == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa  tai khoản " + temp + " này không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        phanQuyenBUS.XoaTaiKhoan(temp);
                        nhatKyHeThongBUS.ThemNhatKyHeThong("Phân quyền", "Xóa tài khoản", temp);
                    }
                    catch
                    {
                        MessageBox.Show(GlobalVar.loisql, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Loaddata();
                }
            }

        }
    }
}