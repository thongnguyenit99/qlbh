namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class NhatKyHeThong
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
            this.grvctnhatky = new DevExpress.XtraGrid.GridControl();
            this.grvrootnhatky = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columdatetime = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.btnxuat = new DevExpress.XtraEditors.SimpleButton();
            this.btndoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnxem = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvctnhatky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvrootnhatky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columdatetime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columdatetime.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grvctnhatky);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1001, 346);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grvctnhatky
            // 
            this.grvctnhatky.Location = new System.Drawing.Point(12, 53);
            this.grvctnhatky.MainView = this.grvrootnhatky;
            this.grvctnhatky.Name = "grvctnhatky";
            this.grvctnhatky.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.columdatetime});
            this.grvctnhatky.Size = new System.Drawing.Size(977, 281);
            this.grvctnhatky.TabIndex = 0;
            this.grvctnhatky.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvrootnhatky});
            // 
            // grvrootnhatky
            // 
            this.grvrootnhatky.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.grvrootnhatky.GridControl = this.grvctnhatky;
            this.grvrootnhatky.Name = "grvrootnhatky";
            this.grvrootnhatky.OptionsView.ShowFooter = true;
            this.grvrootnhatky.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã";
            this.gridColumn1.FieldName = "MaND";
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Máy Tính";
            this.gridColumn2.FieldName = "TenMT";
            this.gridColumn2.MinWidth = 100;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Thời Gian";
            this.gridColumn3.ColumnEdit = this.columdatetime;
            this.gridColumn3.FieldName = "ThoiGian";
            this.gridColumn3.MinWidth = 100;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 100;
            // 
            // columdatetime
            // 
            this.columdatetime.AutoHeight = false;
            this.columdatetime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.columdatetime.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.columdatetime.Name = "columdatetime";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Chức Năng";
            this.gridColumn4.FieldName = "ChucNang";
            this.gridColumn4.MinWidth = 200;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 200;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Hàng Động";
            this.gridColumn5.FieldName = "HanhDong";
            this.gridColumn5.MinWidth = 100;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 100;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Đối Tượng";
            this.gridColumn6.FieldName = "DoiTuong";
            this.gridColumn6.MinWidth = 150;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 150;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btndong);
            this.panelControl1.Controls.Add(this.btnxuat);
            this.panelControl1.Controls.Add(this.btndoc);
            this.panelControl1.Controls.Add(this.btnluu);
            this.panelControl1.Controls.Add(this.btnxoa);
            this.panelControl1.Controls.Add(this.btnxem);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(977, 37);
            this.panelControl1.TabIndex = 4;
            // 
            // btndong
            // 
            this.btndong.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.cancel_16x1610;
            this.btndong.Location = new System.Drawing.Point(488, 5);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 27);
            this.btndong.TabIndex = 5;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnxuat
            // 
            this.btnxuat.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.exporttoxps_16x165;
            this.btnxuat.Location = new System.Drawing.Point(407, 5);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(75, 27);
            this.btnxuat.TabIndex = 4;
            this.btnxuat.Text = "Xuất";
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btndoc
            // 
            this.btndoc.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.open_16x16;
            this.btndoc.Location = new System.Drawing.Point(288, 5);
            this.btndoc.Name = "btndoc";
            this.btndoc.Size = new System.Drawing.Size(113, 27);
            this.btndoc.TabIndex = 3;
            this.btndoc.Text = "Đọc Từ Tập Tin";
            this.btndoc.Click += new System.EventHandler(this.btndoc_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.saveto_16x168;
            this.btnluu.Location = new System.Drawing.Point(169, 5);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(113, 27);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu Vào Tập Tin";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.cancel_16x1610;
            this.btnxoa.Location = new System.Drawing.Point(88, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 27);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnxem
            // 
            this.btnxem.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.refresh_16x161;
            this.btnxem.Location = new System.Drawing.Point(7, 5);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 27);
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
            this.Root.Size = new System.Drawing.Size(1001, 346);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 41);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(5, 41);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(981, 41);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grvctnhatky;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(981, 285);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // NhatKyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 346);
            this.Controls.Add(this.layoutControl1);
            this.Name = "NhatKyHeThong";
            this.Tag = "4";
            this.Text = "Nhật Ký Hệ Thống";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvctnhatky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvrootnhatky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columdatetime.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columdatetime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grvctnhatky;
        private DevExpress.XtraGrid.Views.Grid.GridView grvrootnhatky;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnxem;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btndoc;
        private DevExpress.XtraEditors.SimpleButton btnxuat;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit columdatetime;
    }
}