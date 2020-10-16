namespace Quan_Ly_Ban_Hang.GUI
{
    partial class CapNhatKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapNhatKhuVuc));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ckconquanly = new DevExpress.XtraEditors.CheckEdit();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.txtghichu = new DevExpress.XtraEditors.TextEdit();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckconquanly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtghichu);
            this.groupControl1.Controls.Add(this.txtten);
            this.groupControl1.Controls.Add(this.txtma);
            this.groupControl1.Controls.Add(this.ckconquanly);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(-1, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(296, 172);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ghi chú";
            // 
            // ckconquanly
            // 
            this.ckconquanly.Location = new System.Drawing.Point(67, 136);
            this.ckconquanly.Name = "ckconquanly";
            this.ckconquanly.Properties.AllowFocused = false;
            this.ckconquanly.Properties.Caption = "Con quản lý";
            this.ckconquanly.Size = new System.Drawing.Size(75, 19);
            this.ckconquanly.TabIndex = 3;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(67, 38);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(216, 20);
            this.txtma.TabIndex = 4;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(67, 69);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(216, 20);
            this.txtten.TabIndex = 5;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(67, 103);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(216, 20);
            this.txtghichu.TabIndex = 6;
            // 
            // btnluu
            // 
            this.btnluu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnluu.AllowFocus = false;
            this.btnluu.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.saveto_16x161;
            this.btnluu.Location = new System.Drawing.Point(106, 196);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btndong
            // 
            this.btndong.AllowFocus = false;
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btndong.Location = new System.Drawing.Point(207, 196);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 2;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // CapNhatKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 231);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CapNhatKhuVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatKhuVuc";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckconquanly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtghichu;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraEditors.CheckEdit ckconquanly;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btndong;
    }
}