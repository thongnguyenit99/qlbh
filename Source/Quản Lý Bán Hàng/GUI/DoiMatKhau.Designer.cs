namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class DoiMatKhau
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
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btndongy = new DevExpress.XtraEditors.SimpleButton();
            this.txtnewpass1 = new DevExpress.XtraEditors.TextEdit();
            this.txtnewpass = new DevExpress.XtraEditors.TextEdit();
            this.txtpass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnewpass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnewpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.AllowFocus = false;
            this.btnthoat.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.cancel_16x169;
            this.btnthoat.Location = new System.Drawing.Point(264, 148);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(67, 26);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndongy
            // 
            this.btndongy.AllowFocus = false;
            this.btndongy.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.apply_16x16;
            this.btndongy.Location = new System.Drawing.Point(170, 148);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(67, 26);
            this.btndongy.TabIndex = 7;
            this.btndongy.Text = "Đồng ý";
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // txtnewpass1
            // 
            this.txtnewpass1.Location = new System.Drawing.Point(133, 115);
            this.txtnewpass1.Name = "txtnewpass1";
            this.txtnewpass1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass1.Properties.Appearance.Options.UseFont = true;
            this.txtnewpass1.Properties.PasswordChar = '*';
            this.txtnewpass1.Size = new System.Drawing.Size(199, 22);
            this.txtnewpass1.TabIndex = 6;
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(132, 87);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.Properties.Appearance.Options.UseFont = true;
            this.txtnewpass.Properties.PasswordChar = '*';
            this.txtnewpass.Size = new System.Drawing.Size(199, 22);
            this.txtnewpass.TabIndex = 5;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(133, 59);
            this.txtpass.Name = "txtpass";
            this.txtpass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Properties.Appearance.Options.UseFont = true;
            this.txtpass.Properties.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(199, 22);
            this.txtpass.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Left;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Location = new System.Drawing.Point(11, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(106, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Nhập lại mật khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Left;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu mới";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Left;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu cũ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(84, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(176, 19);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(17, 6);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit1.TabIndex = 10;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 186);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtnewpass1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "3";
            this.Text = "Thay đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtnewpass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnewpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btndongy;
        private DevExpress.XtraEditors.TextEdit txtnewpass1;
        private DevExpress.XtraEditors.TextEdit txtnewpass;
        private DevExpress.XtraEditors.TextEdit txtpass;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}