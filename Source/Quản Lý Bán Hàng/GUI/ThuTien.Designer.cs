namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class ThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuTien));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemDSPT = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemDSPCN = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemDSPTN = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTDCN = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTHCN = new DevExpress.XtraNavBar.NavBarItem();
            this.UC_ThuTien = new DevExpress.XtraEditors.XtraUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("1a94a81a-eb2d-4b92-9975-937af26ff081");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 481);
            this.dockPanel1.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 454);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemDSPT,
            this.navBarItemDSPCN,
            this.navBarItemDSPTN,
            this.navBarItemTDCN,
            this.navBarItemTHCN});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 193;
            this.navBarControl1.Size = new System.Drawing.Size(193, 445);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Phiếu Thu";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDSPT)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItemDSPT
            // 
            this.navBarItemDSPT.Caption = "Danh Sách Phiếu Thu";
            this.navBarItemDSPT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemDSPT.ImageOptions.LargeImage")));
            this.navBarItemDSPT.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemDSPT.ImageOptions.SmallImage")));
            this.navBarItemDSPT.Name = "navBarItemDSPT";
            this.navBarItemDSPT.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDSPT_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Bảng Kê";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDSPCN),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDSPTN),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTDCN),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTHCN)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItemDSPCN
            // 
            this.navBarItemDSPCN.Caption = "Danh Sách Phiếu Công Nợ";
            this.navBarItemDSPCN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemDSPCN.ImageOptions.LargeImage")));
            this.navBarItemDSPCN.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemDSPCN.ImageOptions.SmallImage")));
            this.navBarItemDSPCN.Name = "navBarItemDSPCN";
            this.navBarItemDSPCN.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDSPCN_LinkClicked);
            // 
            // navBarItemDSPTN
            // 
            this.navBarItemDSPTN.Caption = "Danh Sách Phiếu Trả Ngay";
            this.navBarItemDSPTN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemDSPTN.ImageOptions.LargeImage")));
            this.navBarItemDSPTN.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemDSPTN.ImageOptions.SmallImage")));
            this.navBarItemDSPTN.Name = "navBarItemDSPTN";
            this.navBarItemDSPTN.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDSPTN_LinkClicked);
            // 
            // navBarItemTDCN
            // 
            this.navBarItemTDCN.Caption = "Theo Dõi Công Nợ";
            this.navBarItemTDCN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTDCN.ImageOptions.LargeImage")));
            this.navBarItemTDCN.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTDCN.ImageOptions.SmallImage")));
            this.navBarItemTDCN.Name = "navBarItemTDCN";
            this.navBarItemTDCN.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemTDCN_LinkClicked);
            // 
            // navBarItemTHCN
            // 
            this.navBarItemTHCN.Caption = "Tổng Hợp Công Nợ";
            this.navBarItemTHCN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTHCN.ImageOptions.LargeImage")));
            this.navBarItemTHCN.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTHCN.ImageOptions.SmallImage")));
            this.navBarItemTHCN.Name = "navBarItemTHCN";
            this.navBarItemTHCN.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemTHCN_LinkClicked);
            // 
            // UC_ThuTien
            // 
            this.UC_ThuTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_ThuTien.Location = new System.Drawing.Point(200, 0);
            this.UC_ThuTien.Name = "UC_ThuTien";
            this.UC_ThuTien.Size = new System.Drawing.Size(779, 481);
            this.UC_ThuTien.TabIndex = 1;
            // 
            // ThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 481);
            this.Controls.Add(this.UC_ThuTien);
            this.Controls.Add(this.dockPanel1);
            this.Name = "ThuTien";
            this.Tag = "26";
            this.Text = "Thu Tiền";
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDSPT;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDSPCN;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDSPTN;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTDCN;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTHCN;
        private DevExpress.XtraEditors.XtraUserControl UC_ThuTien;
    }
}