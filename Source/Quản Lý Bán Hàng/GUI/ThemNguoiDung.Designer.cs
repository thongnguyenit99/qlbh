namespace Quan_Ly_Ban_Hang.GUI
{
    partial class ThemNguoiDung
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemNguoiDung));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.ckconquanly = new DevExpress.XtraEditors.CheckEdit();
            this.txtxacnhan = new DevExpress.XtraEditors.TextEdit();
            this.txtpass = new DevExpress.XtraEditors.TextEdit();
            this.txttk = new DevExpress.XtraEditors.TextEdit();
            this.btnthemvt = new DevExpress.XtraEditors.SimpleButton();
            this.cbvaitro = new System.Windows.Forms.ComboBox();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckconquanly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtxacnhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnexit);
            this.panelControl1.Controls.Add(this.btndong);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnluu);
            this.panelControl1.Controls.Add(this.ckconquanly);
            this.panelControl1.Controls.Add(this.txtxacnhan);
            this.panelControl1.Controls.Add(this.txtpass);
            this.panelControl1.Controls.Add(this.txttk);
            this.panelControl1.Controls.Add(this.btnthemvt);
            this.panelControl1.Controls.Add(this.cbvaitro);
            this.panelControl1.Controls.Add(this.cbnhanvien);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(339, 279);
            this.panelControl1.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.AllowFocus = false;
            this.btnexit.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.cancel_16x1610;
            this.btnexit.Location = new System.Drawing.Point(309, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnexit.Size = new System.Drawing.Size(23, 23);
            this.btnexit.TabIndex = 1;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndong
            // 
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndong.ImageOptions.Image")));
            this.btndong.Location = new System.Drawing.Point(252, 237);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 17;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thêm người dùng";
            // 
            // btnluu
            // 
            this.btnluu.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.save_16x162;
            this.btnluu.Location = new System.Drawing.Point(137, 237);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 16;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // ckconquanly
            // 
            this.ckconquanly.EditValue = true;
            this.ckconquanly.Location = new System.Drawing.Point(86, 195);
            this.ckconquanly.Name = "ckconquanly";
            this.ckconquanly.Properties.Caption = "Còn quản lý";
            this.ckconquanly.Size = new System.Drawing.Size(75, 19);
            this.ckconquanly.TabIndex = 15;
            // 
            // txtxacnhan
            // 
            this.txtxacnhan.Location = new System.Drawing.Point(86, 135);
            this.txtxacnhan.Name = "txtxacnhan";
            this.txtxacnhan.Size = new System.Drawing.Size(241, 20);
            this.txtxacnhan.TabIndex = 13;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(86, 109);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(241, 20);
            this.txtpass.TabIndex = 12;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(86, 83);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(241, 20);
            this.txttk.TabIndex = 11;
            // 
            // btnthemvt
            // 
            this.btnthemvt.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.add_16x161;
            this.btnthemvt.Location = new System.Drawing.Point(303, 161);
            this.btnthemvt.Name = "btnthemvt";
            this.btnthemvt.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnthemvt.Size = new System.Drawing.Size(24, 23);
            this.btnthemvt.TabIndex = 10;
            this.btnthemvt.Click += new System.EventHandler(this.btnthemvt_Click);
            // 
            // cbvaitro
            // 
            this.cbvaitro.FormattingEnabled = true;
            this.cbvaitro.Location = new System.Drawing.Point(86, 161);
            this.cbvaitro.Name = "cbvaitro";
            this.cbvaitro.Size = new System.Drawing.Size(215, 21);
            this.cbvaitro.TabIndex = 9;
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(86, 56);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(241, 21);
            this.cbnhanvien.TabIndex = 8;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 169);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Vai trò";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 142);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Xác nhận";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Mật khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Tài khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nhân viên";
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(0, 28);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(339, 22);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin bắt buộc";
            // 
            // ThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 279);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNguoiDung";
            this.Load += new System.EventHandler(this.ThemNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckconquanly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtxacnhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnthemvt;
        private System.Windows.Forms.ComboBox cbvaitro;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtpass;
        private DevExpress.XtraEditors.TextEdit txttk;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.CheckEdit ckconquanly;
        private DevExpress.XtraEditors.TextEdit txtxacnhan;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private DevExpress.XtraEditors.SimpleButton btnexit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}