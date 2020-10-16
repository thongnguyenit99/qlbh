namespace Quan_Ly_Ban_Hang.GUI
{
    partial class CapNhatNhomHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapNhatNhomHang));
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ckconquanly = new DevExpress.XtraEditors.CheckEdit();
            this.txtghichu = new DevExpress.XtraEditors.TextEdit();
            this.txtenhomhang = new DevExpress.XtraEditors.TextEdit();
            this.txtmanhomhang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckconquanly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenhomhang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanhomhang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndong.ImageOptions.Image")));
            this.btndong.Location = new System.Drawing.Point(254, 142);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 5;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.saveto_16x164;
            this.btnluu.Location = new System.Drawing.Point(153, 142);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ckconquanly);
            this.groupControl1.Controls.Add(this.txtghichu);
            this.groupControl1.Controls.Add(this.txtenhomhang);
            this.groupControl1.Controls.Add(this.txtmanhomhang);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(336, 130);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin";
            // 
            // ckconquanly
            // 
            this.ckconquanly.Location = new System.Drawing.Point(56, 105);
            this.ckconquanly.Name = "ckconquanly";
            this.ckconquanly.Properties.Caption = "Còn quản lý";
            this.ckconquanly.Size = new System.Drawing.Size(75, 19);
            this.ckconquanly.TabIndex = 6;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(55, 80);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(273, 20);
            this.txtghichu.TabIndex = 5;
            // 
            // txtenhomhang
            // 
            this.txtenhomhang.Location = new System.Drawing.Point(55, 52);
            this.txtenhomhang.Name = "txtenhomhang";
            this.txtenhomhang.Size = new System.Drawing.Size(273, 20);
            this.txtenhomhang.TabIndex = 4;
            // 
            // txtmanhomhang
            // 
            this.txtmanhomhang.Location = new System.Drawing.Point(55, 25);
            this.txtmanhomhang.Name = "txtmanhomhang";
            this.txtmanhomhang.Size = new System.Drawing.Size(273, 20);
            this.txtmanhomhang.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ghi Chú";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã";
            // 
            // CapNhatNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 188);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(343, 212);
            this.MinimumSize = new System.Drawing.Size(343, 212);
            this.Name = "CapNhatNhomHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật nhóm hàng";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckconquanly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenhomhang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanhomhang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btndong;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit ckconquanly;
        private DevExpress.XtraEditors.TextEdit txtghichu;
        private DevExpress.XtraEditors.TextEdit txtenhomhang;
        private DevExpress.XtraEditors.TextEdit txtmanhomhang;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}