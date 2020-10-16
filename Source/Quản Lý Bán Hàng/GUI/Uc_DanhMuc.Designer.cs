namespace Quan_Ly_Ban_Hang.GUI
{
    partial class Uc_DanhMuc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucbtnin = new DevExpress.XtraEditors.SimpleButton();
            this.ucbtndong = new DevExpress.XtraEditors.SimpleButton();
            this.ucbtnnhap = new DevExpress.XtraEditors.SimpleButton();
            this.ucbtnxuat = new DevExpress.XtraEditors.SimpleButton();
            this.ucbtnnaplai = new DevExpress.XtraEditors.SimpleButton();
            this.ucbtnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.ucbtnsua = new DevExpress.XtraEditors.SimpleButton();
            this.ucbtnthem = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // ucbtnin
            // 
            this.ucbtnin.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.printernetwork_16x162;
            this.ucbtnin.Location = new System.Drawing.Point(375, 6);
            this.ucbtnin.Name = "ucbtnin";
            this.ucbtnin.Size = new System.Drawing.Size(72, 23);
            this.ucbtnin.TabIndex = 7;
            this.ucbtnin.Text = "In";
            // 
            // ucbtndong
            // 
            this.ucbtndong.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.cancel_16x166;
            this.ucbtndong.Location = new System.Drawing.Point(661, 6);
            this.ucbtndong.Name = "ucbtndong";
            this.ucbtndong.Size = new System.Drawing.Size(72, 23);
            this.ucbtndong.TabIndex = 6;
            this.ucbtndong.Text = "Đóng";
            // 
            // ucbtnnhap
            // 
            this.ucbtnnhap.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.exporttoxlsx_16x161;
            this.ucbtnnhap.Location = new System.Drawing.Point(469, 6);
            this.ucbtnnhap.Name = "ucbtnnhap";
            this.ucbtnnhap.Size = new System.Drawing.Size(72, 23);
            this.ucbtnnhap.TabIndex = 5;
            this.ucbtnnhap.Text = "Nhập";
            // 
            // ucbtnxuat
            // 
            this.ucbtnxuat.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.exporttoxps_16x162;
            this.ucbtnxuat.Location = new System.Drawing.Point(563, 6);
            this.ucbtnxuat.Name = "ucbtnxuat";
            this.ucbtnxuat.Size = new System.Drawing.Size(72, 23);
            this.ucbtnxuat.TabIndex = 4;
            this.ucbtnxuat.Text = "Xuất";
            // 
            // ucbtnnaplai
            // 
            this.ucbtnnaplai.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.reset2_16x16;
            this.ucbtnnaplai.Location = new System.Drawing.Point(283, 6);
            this.ucbtnnaplai.Name = "ucbtnnaplai";
            this.ucbtnnaplai.Size = new System.Drawing.Size(72, 23);
            this.ucbtnnaplai.TabIndex = 3;
            this.ucbtnnaplai.Text = "Nạp lại";
            // 
            // ucbtnxoa
            // 
            this.ucbtnxoa.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.trash_16x16;
            this.ucbtnxoa.Location = new System.Drawing.Point(190, 6);
            this.ucbtnxoa.Name = "ucbtnxoa";
            this.ucbtnxoa.Size = new System.Drawing.Size(72, 23);
            this.ucbtnxoa.TabIndex = 2;
            this.ucbtnxoa.Text = "Xóa";
            // 
            // ucbtnsua
            // 
            this.ucbtnsua.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.cleartablestyle_16x16;
            this.ucbtnsua.Location = new System.Drawing.Point(98, 6);
            this.ucbtnsua.Name = "ucbtnsua";
            this.ucbtnsua.Size = new System.Drawing.Size(72, 23);
            this.ucbtnsua.TabIndex = 1;
            this.ucbtnsua.Text = "Sửa";
            // 
            // ucbtnthem
            // 
            this.ucbtnthem.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.addfile_16x161;
            this.ucbtnthem.Location = new System.Drawing.Point(5, 6);
            this.ucbtnthem.Name = "ucbtnthem";
            this.ucbtnthem.Size = new System.Drawing.Size(72, 23);
            this.ucbtnthem.TabIndex = 0;
            this.ucbtnthem.Text = "Thêm";
            // 
            // Uc_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucbtnin);
            this.Controls.Add(this.ucbtndong);
            this.Controls.Add(this.ucbtnnhap);
            this.Controls.Add(this.ucbtnxuat);
            this.Controls.Add(this.ucbtnnaplai);
            this.Controls.Add(this.ucbtnxoa);
            this.Controls.Add(this.ucbtnsua);
            this.Controls.Add(this.ucbtnthem);
            this.Name = "Uc_DanhMuc";
            this.Size = new System.Drawing.Size(736, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ucbtnthem;
        private DevExpress.XtraEditors.SimpleButton ucbtnsua;
        private DevExpress.XtraEditors.SimpleButton ucbtnxoa;
        private DevExpress.XtraEditors.SimpleButton ucbtnnaplai;
        private DevExpress.XtraEditors.SimpleButton ucbtnxuat;
        private DevExpress.XtraEditors.SimpleButton ucbtnnhap;
        private DevExpress.XtraEditors.SimpleButton ucbtndong;
        private DevExpress.XtraEditors.SimpleButton ucbtnin;
    }
}
