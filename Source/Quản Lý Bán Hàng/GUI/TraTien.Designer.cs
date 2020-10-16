namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class TraTien
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemDSPC = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemDSPCN = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemDSPTN = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTTCN = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTHCN = new DevExpress.XtraNavBar.NavBarItem();
            this.uc_tratien = new DevExpress.XtraEditors.XtraUserControl();
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
            this.dockPanel1.ID = new System.Guid("718a4622-7873-45cd-8c0e-82c41556b6e7");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 416);
            this.dockPanel1.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 389);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemDSPC,
            this.navBarItemDSPCN,
            this.navBarItemDSPTN,
            this.navBarItemTTCN,
            this.navBarItemTHCN});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 193;
            this.navBarControl1.Size = new System.Drawing.Size(193, 380);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Phiếu Chi";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDSPC)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItemDSPC
            // 
            this.navBarItemDSPC.Caption = "Danh Sách Phiếu Chi";
            this.navBarItemDSPC.ImageOptions.LargeImage = global::Quan_Ly_Ban_Hang.Properties.Resources.report2_32x321;
            this.navBarItemDSPC.ImageOptions.SmallImage = global::Quan_Ly_Ban_Hang.Properties.Resources.report2_16x161;
            this.navBarItemDSPC.Name = "navBarItemDSPC";
            this.navBarItemDSPC.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDSPC_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Bảng Kê";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDSPCN),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDSPTN),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTTCN),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTHCN)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItemDSPCN
            // 
            this.navBarItemDSPCN.Caption = "Danh Sách Phiếu Công Nợ";
            this.navBarItemDSPCN.ImageOptions.LargeImage = global::Quan_Ly_Ban_Hang.Properties.Resources.chartsshowlegend_32x32;
            this.navBarItemDSPCN.ImageOptions.SmallImage = global::Quan_Ly_Ban_Hang.Properties.Resources.chartsshowlegend_16x16;
            this.navBarItemDSPCN.Name = "navBarItemDSPCN";
            this.navBarItemDSPCN.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDSPCN_LinkClicked);
            // 
            // navBarItemDSPTN
            // 
            this.navBarItemDSPTN.Caption = "Danh Sách Phiếu Trả Ngay";
            this.navBarItemDSPTN.ImageOptions.LargeImage = global::Quan_Ly_Ban_Hang.Properties.Resources.chartsshowlegend_32x321;
            this.navBarItemDSPTN.ImageOptions.SmallImage = global::Quan_Ly_Ban_Hang.Properties.Resources.chartsshowlegend_16x161;
            this.navBarItemDSPTN.Name = "navBarItemDSPTN";
            this.navBarItemDSPTN.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDSPTN_LinkClicked);
            // 
            // navBarItemTTCN
            // 
            this.navBarItemTTCN.Caption = "Theo Dõi Công Nợ";
            this.navBarItemTTCN.ImageOptions.LargeImage = global::Quan_Ly_Ban_Hang.Properties.Resources.content_32x322;
            this.navBarItemTTCN.ImageOptions.SmallImage = global::Quan_Ly_Ban_Hang.Properties.Resources.content_16x162;
            this.navBarItemTTCN.Name = "navBarItemTTCN";
            this.navBarItemTTCN.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemTTCN_LinkClicked);
            // 
            // navBarItemTHCN
            // 
            this.navBarItemTHCN.Caption = "Tổng Hợp Công Nợ";
            this.navBarItemTHCN.ImageOptions.LargeImage = global::Quan_Ly_Ban_Hang.Properties.Resources.pivot_32x321;
            this.navBarItemTHCN.ImageOptions.SmallImage = global::Quan_Ly_Ban_Hang.Properties.Resources.pivot_16x161;
            this.navBarItemTHCN.Name = "navBarItemTHCN";
            this.navBarItemTHCN.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemTHCN_LinkClicked);
            // 
            // uc_tratien
            // 
            this.uc_tratien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_tratien.Location = new System.Drawing.Point(200, 0);
            this.uc_tratien.Name = "uc_tratien";
            this.uc_tratien.Size = new System.Drawing.Size(836, 416);
            this.uc_tratien.TabIndex = 1;
            // 
            // TraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 416);
            this.Controls.Add(this.uc_tratien);
            this.Controls.Add(this.dockPanel1);
            this.Name = "TraTien";
            this.Tag = "27";
            this.Text = "Phiếu Chi";
            this.Load += new System.EventHandler(this.TraTien_Load);
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
        private DevExpress.XtraNavBar.NavBarItem navBarItemDSPC;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDSPCN;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDSPTN;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTTCN;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTHCN;
        private DevExpress.XtraEditors.XtraUserControl uc_tratien;
    }
}