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
using DevExpress.Utils.CommonDialogs;
using Quản_Lý_Bán_Hàng.DAO;

namespace Quản_Lý_Bán_Hàng.GUI
{
    public partial class PhucHoi : DevExpress.XtraEditors.XtraForm
    {
        public PhucHoi()
        {
            InitializeComponent();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthuchien_Click(object sender, EventArgs e)
        {
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = 4;
            progressBarControl1.Properties.Minimum = 0;
            progressBarControl1.Position = 1;
            if (txtduongdan.Text.ToString().Trim() != "")
            {
                progressBarControl1.Position = 1;
                DB db = new DB();
                progressBarControl1.Position = 1;
                string sql = "RESTORE DATABASE QLBH_Deploy99 FROM DISK = '" + path + "' WITH REPLACE";
                int temp = db.ExcuteSql(sql);
                progressBarControl1.Position = 4;
                MessageBox.Show("Backup thất bại vì bạn đang kêt nối với datatbase.");
                progressBarControl1.Position = 0;
            }
            else
            {

            }
        }
        string path = "";
        private void btnopenfile_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Files (backup) | *.bak";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                txtduongdan.Text = path;
            }
                
        }
    }
}