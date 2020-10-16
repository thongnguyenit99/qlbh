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

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        DangNhapBUS dangNhapBUS = new DangNhapBUS();
        public login()
        {
            InitializeComponent();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btndangnhap_Click(object sender, EventArgs e)
        {
            int RoldeId = 0;
            // xử lý nếu người dùng không điền vô textbox taikkhoan
            if (txtuser.Text == "")
            {
                MessageBox.Show("Tài khoản không được rỗng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dangNhapBUS.CheckLogin(txtuser.Text, txtmatkhau.Text, ref RoldeId))
                {
                    this.Hide();
                    TrangChu trangChu = new TrangChu(RoldeId);
                    if (trangChu.ShowDialog() != DialogResult.OK)
                    {
                        //Handle authentication failures as necessary, for example:
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
    }
}