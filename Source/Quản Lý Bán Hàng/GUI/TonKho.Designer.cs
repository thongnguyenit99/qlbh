namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class TonKho
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grvcttonkho = new DevExpress.XtraGrid.GridControl();
            this.grvroottonkho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.btnxuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnxem = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvcttonkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvroottonkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grvcttonkho);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1086, 333);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grvcttonkho
            // 
            this.grvcttonkho.Location = new System.Drawing.Point(12, 51);
            this.grvcttonkho.MainView = this.grvroottonkho;
            this.grvcttonkho.Name = "grvcttonkho";
            this.grvcttonkho.Size = new System.Drawing.Size(1062, 270);
            this.grvcttonkho.TabIndex = 6;
            this.grvcttonkho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvroottonkho});
            // 
            // grvroottonkho
            // 
            this.grvroottonkho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.grvroottonkho.GridControl = this.grvcttonkho;
            this.grvroottonkho.GroupCount = 1;
            this.grvroottonkho.Name = "grvroottonkho";
            this.grvroottonkho.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn7, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Hàng";
            this.gridColumn1.FieldName = "MaHang";
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 119;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Hàng";
            this.gridColumn2.FieldName = "TenHang";
            this.gridColumn2.MinWidth = 250;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 250;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Đơn Vị";
            this.gridColumn3.FieldName = "DonVi";
            this.gridColumn3.MinWidth = 70;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số Lượng";
            this.gridColumn4.FieldName = "SoLuong";
            this.gridColumn4.MinWidth = 70;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nhóm Hàng";
            this.gridColumn5.FieldName = "NhomHang";
            this.gridColumn5.MinWidth = 150;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 150;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Còn Quản Lý";
            this.gridColumn6.FieldName = "ConQuanLy";
            this.gridColumn6.MinWidth = 50;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Kho Hàng";
            this.gridColumn7.FieldName = "KhoHang";
            this.gridColumn7.MinWidth = 200;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 200;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btndong);
            this.panelControl1.Controls.Add(this.btnin);
            this.panelControl1.Controls.Add(this.btnxuat);
            this.panelControl1.Controls.Add(this.btnxem);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1062, 35);
            this.panelControl1.TabIndex = 5;
            // 
            // btndong
            // 
            this.btndong.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.cancel_16x1610;
            this.btndong.Location = new System.Drawing.Point(248, 7);
            this.btndong.Name = "btndong";
            this.btndong.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 3;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnin
            // 
            this.btnin.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.printernetwork_16x166;
            this.btnin.Location = new System.Drawing.Point(167, 7);
            this.btnin.Name = "btnin";
            this.btnin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 2;
            this.btnin.Text = "In";
            // 
            // btnxuat
            // 
            this.btnxuat.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.exporttoxps_16x164;
            this.btnxuat.Location = new System.Drawing.Point(86, 7);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnxuat.Size = new System.Drawing.Size(75, 23);
            this.btnxuat.TabIndex = 1;
            this.btnxuat.Text = "Xuất";
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnxem
            // 
            this.btnxem.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.zoom_16x161;
            this.btnxem.Location = new System.Drawing.Point(5, 6);
            this.btnxem.Name = "btnxem";
            this.btnxem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnxem.Size = new System.Drawing.Size(75, 23);
            this.btnxem.TabIndex = 0;
            this.btnxem.Text = "Xem";
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1086, 333);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 39);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(5, 39);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1066, 39);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grvcttonkho;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 39);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1066, 274);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 333);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TonKho";
            this.Tag = "23";
            this.Text = "Tồn Kho";
            this.Load += new System.EventHandler(this.TonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvcttonkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvroottonkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnxem;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.SimpleButton btnxuat;
        private DevExpress.XtraGrid.GridControl grvcttonkho;
        private DevExpress.XtraGrid.Views.Grid.GridView grvroottonkho;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}