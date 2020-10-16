namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class SaoLuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaoLuu));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnthuchien = new DevExpress.XtraEditors.SimpleButton();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.txttentaptin = new DevExpress.XtraEditors.TextEdit();
            this.txtduongdan = new DevExpress.XtraEditors.TextEdit();
            this.btnopenfile = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.txttentaptin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtduongdan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(141, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(314, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sao Lưu Dự Phòng Dữ liệu";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tiến trình";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên tập tin:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Đường dẫn:";
            // 
            // btnthuchien
            // 
            this.btnthuchien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnthuchien.Location = new System.Drawing.Point(344, 183);
            this.btnthuchien.Name = "btnthuchien";
            this.btnthuchien.Size = new System.Drawing.Size(75, 26);
            this.btnthuchien.TabIndex = 4;
            this.btnthuchien.Text = "Thực hiện";
            this.btnthuchien.Click += new System.EventHandler(this.btnthuchien_Click);
            // 
            // btndong
            // 
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btndong.Location = new System.Drawing.Point(470, 183);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 26);
            this.btndong.TabIndex = 5;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // txttentaptin
            // 
            this.txttentaptin.EditValue = "deploy99_bk.bak";
            this.txttentaptin.Location = new System.Drawing.Point(107, 92);
            this.txttentaptin.Name = "txttentaptin";
            this.txttentaptin.Size = new System.Drawing.Size(475, 20);
            this.txttentaptin.TabIndex = 6;
            // 
            // txtduongdan
            // 
            this.txtduongdan.Location = new System.Drawing.Point(107, 130);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(446, 20);
            this.txtduongdan.TabIndex = 7;
            // 
            // btnopenfile
            // 
            this.btnopenfile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btnopenfile.Location = new System.Drawing.Point(559, 127);
            this.btnopenfile.Name = "btnopenfile";
            this.btnopenfile.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnopenfile.Size = new System.Drawing.Size(23, 23);
            this.btnopenfile.TabIndex = 8;
            this.btnopenfile.Click += new System.EventHandler(this.btnopenfile_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(107, 60);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(475, 18);
            this.progressBarControl1.TabIndex = 9;
            // 
            // SaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 218);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.btnopenfile);
            this.Controls.Add(this.txttentaptin);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnthuchien);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtduongdan);
            this.MaximumSize = new System.Drawing.Size(600, 250);
            this.MinimumSize = new System.Drawing.Size(600, 250);
            this.Name = "SaoLuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "5";
            this.Text = "Sao Lưu";
            ((System.ComponentModel.ISupportInitialize)(this.txttentaptin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtduongdan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnthuchien;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private DevExpress.XtraEditors.TextEdit txttentaptin;
        private DevExpress.XtraEditors.TextEdit txtduongdan;
        private DevExpress.XtraEditors.SimpleButton btnopenfile;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
    }
}