namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class BanHang
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
            this.dockchucnang = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemPBH = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemTCT = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTheoHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.CapNhatHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.btntaomoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnluuvathem = new DevExpress.XtraEditors.SimpleButton();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.btnnaplai = new DevExpress.XtraEditors.SimpleButton();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.uc_banhang = new DevExpress.XtraEditors.XtraUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockchucnang.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockchucnang});
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
            // dockchucnang
            // 
            this.dockchucnang.Controls.Add(this.dockPanel1_Container);
            this.dockchucnang.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockchucnang.ID = new System.Guid("84e3f3a9-f0e8-454b-b662-ccc5e016d19a");
            this.dockchucnang.Location = new System.Drawing.Point(0, 0);
            this.dockchucnang.Name = "dockchucnang";
            this.dockchucnang.OriginalSize = new System.Drawing.Size(177, 200);
            this.dockchucnang.Size = new System.Drawing.Size(177, 587);
            this.dockchucnang.Text = "Chức năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(170, 560);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemPBH,
            this.navBarItemTCT,
            this.navBarItemTheoHangHoa,
            this.CapNhatHangHoa,
            this.navBarItem5,
            this.navBarItem6});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 170;
            this.navBarControl1.Size = new System.Drawing.Size(170, 560);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Options.UseTextOptions = true;
            this.navBarGroup1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarGroup1.Caption = "Bán hàng";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPBH)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItemPBH
            // 
            this.navBarItemPBH.Caption = "Phiếu bán hàng";
            this.navBarItemPBH.ImageOptions.LargeImage = global::Quan_Ly_Ban_Hang.Properties.Resources.hideproduct_32x32;
            this.navBarItemPBH.ImageOptions.SmallImage = global::Quan_Ly_Ban_Hang.Properties.Resources.hideproduct_16x16;
            this.navBarItemPBH.Name = "navBarItemPBH";
            this.navBarItemPBH.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemPBH_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Options.UseTextOptions = true;
            this.navBarGroup2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarGroup2.Caption = "Bảng Kê";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTCT),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTheoHangHoa)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItemTCT
            // 
            this.navBarItemTCT.Caption = "Theo Chứng Từ";
            this.navBarItemTCT.ImageOptions.LargeImage = global::Quan_Ly_Ban_Hang.Properties.Resources.richeditbookmark_32x321;
            this.navBarItemTCT.ImageOptions.SmallImage = global::Quan_Ly_Ban_Hang.Properties.Resources.richeditbookmark_16x161;
            this.navBarItemTCT.Name = "navBarItemTCT";
            this.navBarItemTCT.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemTCT_LinkClicked);
            // 
            // navBarItemTheoHangHoa
            // 
            this.navBarItemTheoHangHoa.Caption = "Theo Hàng Hóa";
            this.navBarItemTheoHangHoa.ImageOptions.LargeImage = global::Quan_Ly_Ban_Hang.Properties.Resources.product_32x32;
            this.navBarItemTheoHangHoa.ImageOptions.SmallImage = global::Quan_Ly_Ban_Hang.Properties.Resources.product_16x16;
            this.navBarItemTheoHangHoa.Name = "navBarItemTheoHangHoa";
            this.navBarItemTheoHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemTheoHangHoa_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Appearance.Options.UseTextOptions = true;
            this.navBarGroup3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarGroup3.Caption = "Thêm Danh Mục";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.CapNhatHangHoa),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // CapNhatHangHoa
            // 
            this.CapNhatHangHoa.Caption = "Hàng Hóa";
            this.CapNhatHangHoa.ImageOptions.LargeImage = global::Quan_Ly_Ban_Hang.Properties.Resources.boproductgroup_32x323;
            this.CapNhatHangHoa.ImageOptions.SmallImage = global::Quan_Ly_Ban_Hang.Properties.Resources.boproductgroup_16x163;
            this.CapNhatHangHoa.Name = "CapNhatHangHoa";
            this.CapNhatHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Khách Hàng";
            this.navBarItem5.ImageOptions.LargeImage = global::Quan_Ly_Ban_Hang.Properties.Resources.usergroup_32x323;
            this.navBarItem5.ImageOptions.SmallImage = global::Quan_Ly_Ban_Hang.Properties.Resources.usergroup_16x163;
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Kho Hàng";
            this.navBarItem6.ImageOptions.LargeImage = global::Quan_Ly_Ban_Hang.Properties.Resources.home_32x322;
            this.navBarItem6.ImageOptions.SmallImage = global::Quan_Ly_Ban_Hang.Properties.Resources.home_16x162;
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem6_LinkClicked);
            // 
            // btntaomoi
            // 
            this.btntaomoi.AllowFocus = false;
            this.btntaomoi.Location = new System.Drawing.Point(5, 7);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btntaomoi.Size = new System.Drawing.Size(75, 23);
            this.btntaomoi.TabIndex = 2;
            // 
            // btnluuvathem
            // 
            this.btnluuvathem.AllowFocus = false;
            this.btnluuvathem.Location = new System.Drawing.Point(86, 7);
            this.btnluuvathem.Name = "btnluuvathem";
            this.btnluuvathem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnluuvathem.Size = new System.Drawing.Size(83, 23);
            this.btnluuvathem.TabIndex = 6;
            // 
            // btnin
            // 
            this.btnin.AllowFocus = false;
            this.btnin.Location = new System.Drawing.Point(179, 6);
            this.btnin.Name = "btnin";
            this.btnin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnin.Size = new System.Drawing.Size(62, 23);
            this.btnin.TabIndex = 7;
            // 
            // btnnaplai
            // 
            this.btnnaplai.AllowFocus = false;
            this.btnnaplai.Location = new System.Drawing.Point(247, 7);
            this.btnnaplai.Name = "btnnaplai";
            this.btnnaplai.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnnaplai.Size = new System.Drawing.Size(75, 23);
            this.btnnaplai.TabIndex = 8;
            // 
            // btndong
            // 
            this.btndong.AllowFocus = false;
            this.btndong.Location = new System.Drawing.Point(328, 7);
            this.btndong.Name = "btndong";
            this.btndong.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 9;
            // 
            // uc_banhang
            // 
            this.uc_banhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_banhang.Location = new System.Drawing.Point(177, 0);
            this.uc_banhang.Name = "uc_banhang";
            this.uc_banhang.Size = new System.Drawing.Size(643, 587);
            this.uc_banhang.TabIndex = 3;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 587);
            this.Controls.Add(this.uc_banhang);
            this.Controls.Add(this.dockchucnang);
            this.Name = "BanHang";
            this.Tag = "22";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockchucnang.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockchucnang;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItemPBH;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTCT;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTheoHangHoa;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem CapNhatHangHoa;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraEditors.XtraUserControl uc_banhang;
        private DevExpress.XtraEditors.SimpleButton btntaomoi;
        private DevExpress.XtraEditors.SimpleButton btnluuvathem;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.SimpleButton btnnaplai;
        private DevExpress.XtraEditors.SimpleButton btndong;
    }
}