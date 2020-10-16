namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class ChuyenKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuyenKho));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbgphieuchuyenkho = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbgTheoChungTu = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgTheoHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbgHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgKhoHang = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.userct_chuyenkho = new DevExpress.XtraEditors.XtraUserControl();
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
            this.dockPanel1.ID = new System.Guid("e8a6509c-c774-4f4f-9b0b-2c0ab143da18");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 505);
            this.dockPanel1.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 478);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbgphieuchuyenkho,
            this.nbgTheoChungTu,
            this.nbgTheoHangHoa,
            this.nbgHangHoa,
            this.nbgKhoHang,
            this.nbgNhanVien});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 193;
            this.navBarControl1.Size = new System.Drawing.Size(193, 481);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Options.UseTextOptions = true;
            this.navBarGroup1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarGroup1.Caption = "Chuyển Kho";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbgphieuchuyenkho)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbgphieuchuyenkho
            // 
            this.nbgphieuchuyenkho.Caption = "Phiếu Chuyển Kho";
            this.nbgphieuchuyenkho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgphieuchuyenkho.ImageOptions.LargeImage")));
            this.nbgphieuchuyenkho.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbgphieuchuyenkho.ImageOptions.SmallImage")));
            this.nbgphieuchuyenkho.Name = "nbgphieuchuyenkho";
            this.nbgphieuchuyenkho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbgphieuchuyenkho_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Options.UseTextOptions = true;
            this.navBarGroup2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarGroup2.Caption = "Bảng Kệ";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbgTheoChungTu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbgTheoHangHoa)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nbgTheoChungTu
            // 
            this.nbgTheoChungTu.Caption = "Theo Chứng Từ";
            this.nbgTheoChungTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgTheoChungTu.ImageOptions.LargeImage")));
            this.nbgTheoChungTu.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbgTheoChungTu.ImageOptions.SmallImage")));
            this.nbgTheoChungTu.Name = "nbgTheoChungTu";
            this.nbgTheoChungTu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbgTheoChungTu_LinkClicked);
            // 
            // nbgTheoHangHoa
            // 
            this.nbgTheoHangHoa.Caption = "Theo Hàng Hóa";
            this.nbgTheoHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgTheoHangHoa.ImageOptions.LargeImage")));
            this.nbgTheoHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbgTheoHangHoa.ImageOptions.SmallImage")));
            this.nbgTheoHangHoa.Name = "nbgTheoHangHoa";
            this.nbgTheoHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbgTheoHangHoa_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Appearance.Options.UseTextOptions = true;
            this.navBarGroup3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarGroup3.Caption = "Thêm Danh Mục";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbgHangHoa),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbgKhoHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbgNhanVien)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // nbgHangHoa
            // 
            this.nbgHangHoa.Caption = "Hàng Hóa";
            this.nbgHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgHangHoa.ImageOptions.LargeImage")));
            this.nbgHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbgHangHoa.ImageOptions.SmallImage")));
            this.nbgHangHoa.Name = "nbgHangHoa";
            this.nbgHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbgHangHoa_LinkClicked);
            // 
            // nbgKhoHang
            // 
            this.nbgKhoHang.Caption = "Kho Hàng";
            this.nbgKhoHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgKhoHang.ImageOptions.LargeImage")));
            this.nbgKhoHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbgKhoHang.ImageOptions.SmallImage")));
            this.nbgKhoHang.Name = "nbgKhoHang";
            this.nbgKhoHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbgKhoHang_LinkClicked);
            // 
            // nbgNhanVien
            // 
            this.nbgNhanVien.Caption = "Nhân Viên";
            this.nbgNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbgNhanVien.ImageOptions.LargeImage")));
            this.nbgNhanVien.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbgNhanVien.ImageOptions.SmallImage")));
            this.nbgNhanVien.Name = "nbgNhanVien";
            this.nbgNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbgNhanVien_LinkClicked);
            // 
            // userct_chuyenkho
            // 
            this.userct_chuyenkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userct_chuyenkho.Location = new System.Drawing.Point(200, 0);
            this.userct_chuyenkho.Name = "userct_chuyenkho";
            this.userct_chuyenkho.Size = new System.Drawing.Size(725, 505);
            this.userct_chuyenkho.TabIndex = 1;
            // 
            // ChuyenKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 505);
            this.Controls.Add(this.userct_chuyenkho);
            this.Controls.Add(this.dockPanel1);
            this.Name = "ChuyenKho";
            this.Tag = "24";
            this.Text = "Chuyển Kho";
            this.Load += new System.EventHandler(this.ChuyenKho_Load);
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
        private DevExpress.XtraNavBar.NavBarItem nbgphieuchuyenkho;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nbgTheoChungTu;
        private DevExpress.XtraNavBar.NavBarItem nbgTheoHangHoa;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem nbgHangHoa;
        private DevExpress.XtraNavBar.NavBarItem nbgKhoHang;
        private DevExpress.XtraNavBar.NavBarItem nbgNhanVien;
        private DevExpress.XtraEditors.XtraUserControl userct_chuyenkho;
    }
}