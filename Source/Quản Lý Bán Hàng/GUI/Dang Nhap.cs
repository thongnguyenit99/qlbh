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
using Quản_Lý_Bán_Hàng.DAO;
using Quản_Lý_Bán_Hàng.BUS;
using Quan_Ly_Ban_Hang.DTO;
using System.IO;
using System.Reflection;
using DevExpress.XtraRichEdit.Model;
using Quan_Ly_Ban_Hang.BUS;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        DangNhapBUS dangNhapBUS = new DangNhapBUS();
        public static int RoldeId = 0;
        public login()
        {
            InitializeComponent();
            pictureEdit1.Image = Image.FromFile(@"Resources\login.png");
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btndangnhap_Click(object sender, EventArgs e)
        {
            // xử lý nếu người dùng không điền vô textbox taikkhoan
            if (txtuser.Text == "")
            {
                MessageBox.Show("Tài khoản không được rỗng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dangNhapBUS.CheckLogin(txtuser.Text, txtmatkhau.Text, ref RoldeId))
                {
                    NhatKyHeThongBUS nhatKyHeThongBUS = new NhatKyHeThongBUS();
                    try
                    {
                        nhatKyHeThongBUS.ThemNhatKyHeThong("Hệ Thống", "Đăng Nhập", " ");
                    }
                    catch
                    {

                    }
                    if (checksave.Checked)
                    {
                        Quan_Ly_Ban_Hang.Properties.Settings.Default.UserName = txtuser.Text;
                        Quan_Ly_Ban_Hang.Properties.Settings.Default.Password = txtmatkhau.Text;
                        Quan_Ly_Ban_Hang.Properties.Settings.Default.Save();
                    }
                    GlobalVar.tendn = txtuser.Text;
                    var list = dangNhapBUS.GetListRolform(RoldeId);
                    // Đưa vô distionary
                    foreach(var RoleForm in list)
                    {
                        GlobalVar.distRoleForm.Add(RoleForm.FormId, RoleForm);
                    }
                    this.Hide();
                    TrangChu trangChu = new TrangChu(RoldeId, txtuser.Text);
                    if (trangChu.ShowDialog() != DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        trangChu.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checksave_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            txtuser.Text = Quan_Ly_Ban_Hang.Properties.Settings.Default.UserName;
            txtmatkhau.Text = Quan_Ly_Ban_Hang.Properties.Settings.Default.Password;
        }
    }
}