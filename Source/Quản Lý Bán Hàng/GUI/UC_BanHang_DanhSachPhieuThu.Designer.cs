namespace Quan_Ly_Ban_Hang.GUI
{
    partial class UC_BanHang_DanhSachPhieuThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BanHang_DanhSachPhieuThu));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grvctdsthutien = new DevExpress.XtraGrid.GridControl();
            this.grvdspt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.btnxuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnxem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbluachon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txttungay = new DevExpress.XtraEditors.DateEdit();
            this.txtdenngay = new DevExpress.XtraEditors.DateEdit();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvctdsthutien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdspt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbluachon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grvctdsthutien);
            this.layoutControl1.Controls.Add(this.btndong);
            this.layoutControl1.Controls.Add(this.btnxuat);
            this.layoutControl1.Controls.Add(this.btnxoa);
            this.layoutControl1.Controls.Add(this.btnxem);
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Controls.Add(this.cbluachon);
            this.layoutControl1.Controls.Add(this.txttungay);
            this.layoutControl1.Controls.Add(this.txtdenngay);
            this.layoutControl1.Controls.Add(this.btnin);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1186, 418);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grvctdsthutien
            // 
            this.grvctdsthutien.Location = new System.Drawing.Point(12, 63);
            this.grvctdsthutien.MainView = this.grvdspt;
            this.grvctdsthutien.Name = "grvctdsthutien";
            this.grvctdsthutien.Size = new System.Drawing.Size(1162, 343);
            this.grvctdsthutien.TabIndex = 26;
            this.grvctdsthutien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvdspt});
            this.grvctdsthutien.DoubleClick += new System.EventHandler(this.grvctdsthutien_DoubleClick);
            this.grvctdsthutien.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grvctdsthutien_MouseDoubleClick);
            // 
            // grvdspt
            // 
            this.grvdspt.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.grvdspt.GridControl = this.grvctdsthutien;
            this.grvdspt.Name = "grvdspt";
            this.grvdspt.OptionsView.ShowAutoFilterRow = true;
            this.grvdspt.OptionsView.ShowFooter = true;
            this.grvdspt.OptionsView.ShowGroupPanel = false;
            this.grvdspt.DoubleClick += new System.EventHandler(this.grvdspt_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Phiếu";
            this.gridColumn1.FieldName = "MaPT";
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày";
            this.gridColumn2.FieldName = "NgayLap";
            this.gridColumn2.MinWidth = 120;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Chứng Từ";
            this.gridColumn3.FieldName = "MaPBH";
            this.gridColumn3.MinWidth = 120;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 120;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã KH";
            this.gridColumn4.FieldName = "MaKH";
            this.gridColumn4.MinWidth = 150;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 150;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên Khách Hàng";
            this.gridColumn5.FieldName = "TenKH";
            this.gridColumn5.MinWidth = 250;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 250;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số Tiền";
            this.gridColumn6.FieldName = "TongTien";
            this.gridColumn6.MinWidth = 150;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 150;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ghi Chú";
            this.gridColumn7.FieldName = "GhiChu";
            this.gridColumn7.MinWidth = 200;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 200;
            // 
            // btndong
            // 
            this.btndong.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.closeheaderandfooter_16x16;
            this.btndong.Location = new System.Drawing.Point(757, 37);
            this.btndong.Name = "btndong";
            this.btndong.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btndong.Size = new System.Drawing.Size(54, 22);
            this.btndong.StyleController = this.layoutControl1;
            this.btndong.TabIndex = 25;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnxuat
            // 
            this.btnxuat.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.pagecolor_16x16;
            this.btnxuat.Location = new System.Drawing.Point(703, 37);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnxuat.Size = new System.Drawing.Size(50, 22);
            this.btnxuat.StyleController = this.layoutControl1;
            this.btnxuat.TabIndex = 24;
            this.btnxuat.Text = "Xuất";
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.cancel_16x1610;
            this.btnxoa.Location = new System.Drawing.Point(653, 37);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnxoa.Size = new System.Drawing.Size(46, 22);
            this.btnxoa.StyleController = this.layoutControl1;
            this.btnxoa.TabIndex = 23;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnxem
            // 
            this.btnxem.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.zoom_16x162;
            this.btnxem.Location = new System.Drawing.Point(601, 37);
            this.btnxem.Name = "btnxem";
            this.btnxem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnxem.Size = new System.Drawing.Size(48, 22);
            this.btnxem.StyleController = this.layoutControl1;
            this.btnxem.TabIndex = 22;
            this.btnxem.Text = "Xem";
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1162, 21);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "Bảng Kê Phiếu Thu Tiền";
            // 
            // cbluachon
            // 
            this.cbluachon.Location = new System.Drawing.Point(20, 37);
            this.cbluachon.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbluachon.Name = "cbluachon";
            this.cbluachon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbluachon.Properties.Appearance.Options.UseFont = true;
            this.cbluachon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbluachon.Size = new System.Drawing.Size(186, 20);
            this.cbluachon.StyleController = this.layoutControl1;
            this.cbluachon.TabIndex = 4;
            this.cbluachon.SelectedValueChanged += new System.EventHandler(this.cbluachon_SelectedValueChanged);
            // 
            // txttungay
            // 
            this.txttungay.EditValue = null;
            this.txttungay.Location = new System.Drawing.Point(228, 37);
            this.txttungay.Name = "txttungay";
            this.txttungay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttungay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttungay.Properties.DisplayFormat.FormatString = "";
            this.txttungay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txttungay.Properties.EditFormat.FormatString = "";
            this.txttungay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txttungay.Properties.Mask.EditMask = "";
            this.txttungay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txttungay.Size = new System.Drawing.Size(176, 20);
            this.txttungay.StyleController = this.layoutControl1;
            this.txttungay.TabIndex = 6;
            // 
            // txtdenngay
            // 
            this.txtdenngay.EditValue = null;
            this.txtdenngay.Location = new System.Drawing.Point(433, 37);
            this.txtdenngay.Name = "txtdenngay";
            this.txtdenngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdenngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdenngay.Properties.DisplayFormat.FormatString = "";
            this.txtdenngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtdenngay.Properties.EditFormat.FormatString = "";
            this.txtdenngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtdenngay.Properties.Mask.EditMask = "";
            this.txtdenngay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtdenngay.Size = new System.Drawing.Size(164, 20);
            this.txtdenngay.StyleController = this.layoutControl1;
            this.txtdenngay.TabIndex = 7;
            // 
            // btnin
            // 
            this.btnin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.Image")));
            this.btnin.Location = new System.Drawing.Point(815, 37);
            this.btnin.Name = "btnin";
            this.btnin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnin.Size = new System.Drawing.Size(51, 22);
            this.btnin.StyleController = this.layoutControl1;
            this.btnin.TabIndex = 27;
            this.btnin.Text = "In";
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1186, 418);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 25);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(5, 25);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1166, 25);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbluachon;
            this.layoutControlItem2.CustomizationFormText = " ";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(198, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(198, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(198, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = " ";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txttungay;
            this.layoutControlItem4.CustomizationFormText = "Từ";
            this.layoutControlItem4.Location = new System.Drawing.Point(198, 25);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(198, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(198, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(198, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Từ";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(13, 13);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtdenngay;
            this.layoutControlItem5.CustomizationFormText = "Đến";
            this.layoutControlItem5.Location = new System.Drawing.Point(396, 25);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(193, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(193, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(193, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "Đến";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(20, 13);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnxem;
            this.layoutControlItem8.Location = new System.Drawing.Point(589, 25);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(52, 26);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(52, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(52, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btndong;
            this.layoutControlItem3.Location = new System.Drawing.Point(745, 25);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(58, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(58, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(58, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnxuat;
            this.layoutControlItem6.Location = new System.Drawing.Point(691, 25);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(54, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(54, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(54, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnxoa;
            this.layoutControlItem7.Location = new System.Drawing.Point(641, 25);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(50, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(50, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(50, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.grvctdsthutien;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 51);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(1166, 347);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnin;
            this.layoutControlItem10.Location = new System.Drawing.Point(803, 25);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(55, 26);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(55, 26);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(55, 26);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(858, 25);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(308, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // UC_BanHang_DanhSachPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_BanHang_DanhSachPhieuThu";
            this.Size = new System.Drawing.Size(1186, 418);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvctdsthutien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdspt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbluachon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ComboBoxEdit cbluachon;
        private DevExpress.XtraEditors.DateEdit txttungay;
        private DevExpress.XtraEditors.DateEdit txtdenngay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private DevExpress.XtraEditors.SimpleButton btnxuat;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnxem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.GridControl grvctdsthutien;
        private DevExpress.XtraGrid.Views.Grid.GridView grvdspt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
    }
}
