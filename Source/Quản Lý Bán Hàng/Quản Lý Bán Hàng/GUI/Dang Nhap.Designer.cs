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
            this.btndangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checksave = new DevExpress.XtraEditors.CheckEdit();
            this.txtmatkhau = new DevExpress.XtraEditors.TextEdit();
            this.txtuser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnexit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checksave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(350, 250);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btndangnhap);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.checksave);
            this.panelControl3.Controls.Add(this.txtmatkhau);
            this.panelControl3.Controls.Add(this.txtuser);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 31);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(346, 217);
            this.panelControl3.TabIndex = 1;
            // 
            // btndangnhap
            // 
            this.btndangnhap.AllowFocus = false;
            this.btndangnhap.Location = new System.Drawing.Point(126, 178);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(75, 23);
            this.btndangnhap.TabIndex = 6;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.Click += new System.EventHandler(this.Btndangnhap_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(126, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "ĐĂNG NHẬP";
            // 
            // checksave
            // 
            this.checksave.Location = new System.Drawing.Point(31, 140);
            this.checksave.Name = "checksave";
            this.checksave.Properties.Caption = "Nhớ tài khoản và mật khẩu";
            this.checksave.Size = new System.Drawing.Size(155, 19);
            this.checksave.TabIndex = 4;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(31, 114);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(282, 20);
            this.txtmatkhau.TabIndex = 3;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(31, 69);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(282, 20);
            this.txtuser.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tai khoản:";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnexit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(346, 29);
            this.panelControl2.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.AllowFocus = false;
            this.btnexit.ImageOptions.Image = global::Quản_Lý_Bán_Hàng.Properties.Resources.cancel_16x163;
            this.btnexit.Location = new System.Drawing.Point(317, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnexit.Size = new System.Drawing.Size(24, 23);
            this.btnexit.TabIndex = 0;
            this.btnexit.Click += new System.EventHandler(this.Btnexit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checksave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnexit;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btndangnhap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit checksave;
        private DevExpress.XtraEditors.TextEdit txtmatkhau;
        private DevExpress.XtraEditors.TextEdit txtuser;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}