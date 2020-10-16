namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class PhucHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhucHoi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.txtduongdan = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.btnopenfile = new DevExpress.XtraEditors.SimpleButton();
            this.btnthuchien = new DevExpress.XtraEditors.SimpleButton();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtduongdan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tiến trình";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Tập tin";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Cơ sỏ dữ liệu";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(110, 10);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(417, 18);
            this.progressBarControl1.TabIndex = 3;
            // 
            // txtduongdan
            // 
            this.txtduongdan.Location = new System.Drawing.Point(110, 34);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(389, 20);
            this.txtduongdan.TabIndex = 4;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "QLBH_Deploy99";
            this.textEdit2.Location = new System.Drawing.Point(110, 60);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(417, 20);
            this.textEdit2.TabIndex = 5;
            // 
            // btnopenfile
            // 
            this.btnopenfile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnopenfile.Location = new System.Drawing.Point(505, 32);
            this.btnopenfile.Name = "btnopenfile";
            this.btnopenfile.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnopenfile.Size = new System.Drawing.Size(22, 23);
            this.btnopenfile.TabIndex = 6;
            this.btnopenfile.Click += new System.EventHandler(this.btnopenfile_Click);
            // 
            // btnthuchien
            // 
            this.btnthuchien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthuchien.ImageOptions.Image")));
            this.btnthuchien.Location = new System.Drawing.Point(328, 103);
            this.btnthuchien.Name = "btnthuchien";
            this.btnthuchien.Size = new System.Drawing.Size(75, 26);
            this.btnthuchien.TabIndex = 7;
            this.btnthuchien.Text = "Thực hiện";
            this.btnthuchien.Click += new System.EventHandler(this.btnthuchien_Click);
            // 
            // btndong
            // 
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btndong.Location = new System.Drawing.Point(452, 103);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 26);
            this.btndong.TabIndex = 8;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // PhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 138);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnthuchien);
            this.Controls.Add(this.btnopenfile);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.txtduongdan);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "PhucHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "6";
            this.Text = "Phục Hồi Dữ Liệu";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtduongdan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.TextEdit txtduongdan;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton btnopenfile;
        private DevExpress.XtraEditors.SimpleButton btnthuchien;
        private DevExpress.XtraEditors.SimpleButton btndong;
    }
}