namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class NhapTuExcel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapTuExcel));
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Quan_Ly_Ban_Hang.GUI.WaitForm1), true, true);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnnaplai = new DevExpress.XtraEditors.SimpleButton();
            this.cbluuchon = new System.Windows.Forms.ComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.nhaCungCapDTOBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiLienHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnimport = new DevExpress.XtraEditors.SimpleButton();
            this.cbsheet = new System.Windows.Forms.ComboBox();
            this.btnbrow = new DevExpress.XtraEditors.SimpleButton();
            this.txtfilename = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapDTOBDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfilename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnnaplai);
            this.layoutControl1.Controls.Add(this.cbluuchon);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btnimport);
            this.layoutControl1.Controls.Add(this.cbsheet);
            this.layoutControl1.Controls.Add(this.btnbrow);
            this.layoutControl1.Controls.Add(this.txtfilename);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1269, 296);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnnaplai
            // 
            this.btnnaplai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnaplai.ImageOptions.Image")));
            this.btnnaplai.Location = new System.Drawing.Point(746, 38);
            this.btnnaplai.Name = "btnnaplai";
            this.btnnaplai.Size = new System.Drawing.Size(76, 22);
            this.btnnaplai.StyleController = this.layoutControl1;
            this.btnnaplai.TabIndex = 10;
            this.btnnaplai.Text = "Nạp Lại";
            this.btnnaplai.Click += new System.EventHandler(this.btnnaplai_Click);
            // 
            // cbluuchon
            // 
            this.cbluuchon.FormattingEnabled = true;
            this.cbluuchon.Location = new System.Drawing.Point(408, 38);
            this.cbluuchon.Name = "cbluuchon";
            this.cbluuchon.Size = new System.Drawing.Size(224, 21);
            this.cbluuchon.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nhaCungCapDTOBDBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1245, 220);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // nhaCungCapDTOBDBindingSource
            // 
            this.nhaCungCapDTOBDBindingSource.DataSource = typeof(Quan_Ly_Ban_Hang.DTO.NhaCungCapDTO_BD);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNCC,
            this.colTenNCC,
            this.colMaKV,
            this.colNguoiLienHe,
            this.colDiaChi,
            this.colDienThoai,
            this.colDiDong,
            this.colFax,
            this.colChucVu,
            this.colConQuanLy});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaNCC
            // 
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 0;
            // 
            // colTenNCC
            // 
            this.colTenNCC.FieldName = "TenNCC";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.Visible = true;
            this.colTenNCC.VisibleIndex = 1;
            // 
            // colMaKV
            // 
            this.colMaKV.FieldName = "MaKV";
            this.colMaKV.Name = "colMaKV";
            this.colMaKV.Visible = true;
            this.colMaKV.VisibleIndex = 2;
            // 
            // colNguoiLienHe
            // 
            this.colNguoiLienHe.FieldName = "NguoiLienHe";
            this.colNguoiLienHe.Name = "colNguoiLienHe";
            this.colNguoiLienHe.Visible = true;
            this.colNguoiLienHe.VisibleIndex = 3;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 4;
            // 
            // colDienThoai
            // 
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 5;
            // 
            // colDiDong
            // 
            this.colDiDong.FieldName = "DiDong";
            this.colDiDong.Name = "colDiDong";
            this.colDiDong.Visible = true;
            this.colDiDong.VisibleIndex = 6;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 7;
            // 
            // colChucVu
            // 
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 8;
            // 
            // colConQuanLy
            // 
            this.colConQuanLy.FieldName = "ConQuanLy";
            this.colConQuanLy.Name = "colConQuanLy";
            this.colConQuanLy.Visible = true;
            this.colConQuanLy.VisibleIndex = 9;
            // 
            // btnimport
            // 
            this.btnimport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnimport.ImageOptions.Image")));
            this.btnimport.Location = new System.Drawing.Point(636, 38);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(106, 22);
            this.btnimport.StyleController = this.layoutControl1;
            this.btnimport.TabIndex = 1;
            this.btnimport.Text = "Thêm DB";
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // cbsheet
            // 
            this.cbsheet.FormattingEnabled = true;
            this.cbsheet.Location = new System.Drawing.Point(96, 38);
            this.cbsheet.Name = "cbsheet";
            this.cbsheet.Size = new System.Drawing.Size(224, 21);
            this.cbsheet.TabIndex = 7;
            this.cbsheet.SelectedValueChanged += new System.EventHandler(this.cbsheet_SelectedValueChanged);
            // 
            // btnbrow
            // 
            this.btnbrow.Location = new System.Drawing.Point(1236, 12);
            this.btnbrow.MaximumSize = new System.Drawing.Size(21, 22);
            this.btnbrow.MinimumSize = new System.Drawing.Size(21, 22);
            this.btnbrow.Name = "btnbrow";
            this.btnbrow.Size = new System.Drawing.Size(21, 22);
            this.btnbrow.StyleController = this.layoutControl1;
            this.btnbrow.TabIndex = 6;
            this.btnbrow.Text = "...";
            this.btnbrow.Click += new System.EventHandler(this.btnbrow_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(96, 12);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(1136, 20);
            this.txtfilename.StyleController = this.layoutControl1;
            this.txtfilename.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1269, 296);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbsheet;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(312, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(312, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(312, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Sheet";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnimport;
            this.layoutControlItem5.Location = new System.Drawing.Point(624, 26);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(110, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(110, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(110, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1249, 224);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtfilename;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1224, 26);
            this.layoutControlItem2.Text = "Đường dẫn";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnbrow;
            this.layoutControlItem3.Location = new System.Drawing.Point(1224, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(25, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbluuchon;
            this.layoutControlItem6.Location = new System.Drawing.Point(312, 26);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(312, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(312, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(312, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "Lựu chọn các lưu";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(81, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(814, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(435, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnnaplai;
            this.layoutControlItem7.Location = new System.Drawing.Point(734, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // NhapTuExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 296);
            this.Controls.Add(this.layoutControl1);
            this.Name = "NhapTuExcel";
            this.Tag = "9";
            this.Text = "Nhập Từ Excel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapTuExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapDTOBDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfilename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtfilename;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnbrow;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ComboBox cbsheet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnimport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource nhaCungCapDTOBDBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKV;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiLienHe;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDiDong;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colConQuanLy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ComboBox cbluuchon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnnaplai;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}