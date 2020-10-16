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

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class SaoLuu : DevExpress.XtraEditors.XtraForm
    {
        public SaoLuu()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        string path ="";
        private void btnopenfile_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                txtduongdan.Text = fbd.SelectedPath;
                if (fbd.SelectedPath != null && fbd.SelectedPath != "")
                {
                    path = fbd.SelectedPath + txttentaptin.Text;
                }
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthuchien_Click(object sender, EventArgs e)
        {
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = 134;
            progressBarControl1.Properties.Minimum = 0;
            DB db = new DB();
            if(txtduongdan.Text != "")
            {
                if (txttentaptin.Text != "")
                {
                    progressBarControl1.Position = 1;
                    string sql = "backup database " + "QLBH_Deploy99" + " to disk = '" + path + "'";
                    progressBarControl1.Position = 2;
                    int temp = db.ExcuteSql(sql);
                    for(int i = 3; i < 133;i++)
                    {
                        progressBarControl1.Position = i;
                    }
                    if (temp == -1)
                    {
                        progressBarControl1.Position = 134;
                        DialogResult dialogResult = MessageBox.Show("Sao lưu dữ liệu thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            progressBarControl1.Position = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sao lưu dữ liệu thất bại.");
                    }
                }
                else
                {
                    MessageBox.Show("Tên tập tin không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên đường dẫn không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}