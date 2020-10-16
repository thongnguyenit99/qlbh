namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class login
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btndangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checksave = new DevExpress.XtraEditors.CheckEdit();
            this.txtmatkhau = new DevExpress.XtraEditors.TextEdit();
            this.txtuser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(314, 211);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.pictureEdit1);
            this.panelControl3.Controls.Add(this.simpleButton1);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.btndangnhap);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.checksave);
            this.panelControl3.Controls.Add(this.txtmatkhau);
            this.panelControl3.Controls.Add(this.txtuser);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(310, 207);
            this.panelControl3.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit1.Location = new System.Drawing.Point(8, 9);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(71, 63);
            this.pictureEdit1.TabIndex = 10;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.Location = new System.Drawing.Point(207, 172);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Kết thúc";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(85, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Mật khẩu để trống";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(85, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(195, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Đăng nhập lần đầu tài khoản: Hadestran";
            // 
            // btndangnhap
            // 
            this.btndangnhap.AllowFocus = false;
            this.btndangnhap.Location = new System.Drawing.Point(110, 171);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(91, 23);
            this.btndangnhap.TabIndex = 6;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.Click += new System.EventHandler(this.Btndangnhap_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(124, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "ĐĂNG NHẬP";
            // 
            // checksave
            // 
            this.checksave.EditValue = true;
            this.checksave.Location = new System.Drawing.Point(110, 144);
            this.checksave.Name = "checksave";
            this.checksave.Properties.AllowFocused = false;
            this.checksave.Properties.Caption = "Nhớ tài khoản và mật khẩu";
            this.checksave.Size = new System.Drawing.Size(155, 19);
            this.checksave.TabIndex = 4;
            this.checksave.CheckedChanged += new System.EventHandler(this.checksave_CheckedChanged);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(110, 118);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Properties.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(190, 20);
            this.txtmatkhau.TabIndex = 3;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(110, 92);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(190, 20);
            this.txtuser.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(56, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(56, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tài khoản";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 211);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btndangnhap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit checksave;
        private DevExpress.XtraEditors.TextEdit txtmatkhau;
        private DevExpress.XtraEditors.TextEdit txtuser;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}