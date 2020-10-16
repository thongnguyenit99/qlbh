namespace Quan_Ly_Ban_Hang.GUI
{
    partial class CapNhatTyGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapNhatTyGia));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.txtqdtygia = new DevExpress.XtraEditors.TextEdit();
            this.ckconquanly = new DevExpress.XtraEditors.CheckEdit();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqdtygia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckconquanly.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ckconquanly);
            this.groupControl1.Controls.Add(this.txtqdtygia);
            this.groupControl1.Controls.Add(this.txtten);
            this.groupControl1.Controls.Add(this.txtma);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(294, 133);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tỷ giá quy đổi";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(92, 25);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(190, 20);
            this.txtma.TabIndex = 3;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(92, 51);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(190, 20);
            this.txtten.TabIndex = 4;
            // 
            // txtqdtygia
            // 
            this.txtqdtygia.Location = new System.Drawing.Point(92, 77);
            this.txtqdtygia.Name = "txtqdtygia";
            this.txtqdtygia.Size = new System.Drawing.Size(190, 20);
            this.txtqdtygia.TabIndex = 5;
            // 
            // ckconquanly
            // 
            this.ckconquanly.Location = new System.Drawing.Point(92, 103);
            this.ckconquanly.Name = "ckconquanly";
            this.ckconquanly.Properties.Caption = "Còn quản lý";
            this.ckconquanly.Size = new System.Drawing.Size(75, 19);
            this.ckconquanly.TabIndex = 6;
            // 
            // btnluu
            // 
            this.btnluu.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.saveto_16x165;
            this.btnluu.Location = new System.Drawing.Point(111, 143);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 26);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btndong
            // 
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btndong.Location = new System.Drawing.Point(207, 143);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 26);
            this.btndong.TabIndex = 2;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // CapNhatTyGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 178);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(300, 202);
            this.MinimumSize = new System.Drawing.Size(300, 202);
            this.Name = "CapNhatTyGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật tỷ giá";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqdtygia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckconquanly.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit ckconquanly;
        private DevExpress.XtraEditors.TextEdit txtqdtygia;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btndong;
    }
}