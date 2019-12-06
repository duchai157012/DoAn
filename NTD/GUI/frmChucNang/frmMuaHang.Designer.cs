namespace NTD.GUI
{
    partial class frmMuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuaHang));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl2 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbPhieuNhapHang = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbTheoChungTu = new DevExpress.XtraNavBar.NavBarItem();
            this.nbTheoHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.ucBanHang1 = new NTD.GUI.UC.UcBanHang();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl2)).BeginInit();
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
            this.dockPanel1.ID = new System.Guid("74e75d27-8409-48d9-8e2f-eeae8a04c76f");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 382);
            this.dockPanel1.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl2);
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 355);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl2
            // 
            this.navBarControl2.ActiveGroup = this.navBarGroup1;
            this.navBarControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl2.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl2.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbPhieuNhapHang,
            this.nbTheoChungTu,
            this.nbTheoHangHoa,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6});
            this.navBarControl2.Location = new System.Drawing.Point(0, 0);
            this.navBarControl2.Name = "navBarControl2";
            this.navBarControl2.OptionsNavPane.ExpandedWidth = 191;
            this.navBarControl2.Size = new System.Drawing.Size(191, 355);
            this.navBarControl2.TabIndex = 1;
            this.navBarControl2.Text = "navBarControl2";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Nhập Hàng";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbPhieuNhapHang)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbPhieuNhapHang
            // 
            this.nbPhieuNhapHang.Caption = "Phiếu Nhập Hàng";
            this.nbPhieuNhapHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.ImageOptions.LargeImage")));
            this.nbPhieuNhapHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.ImageOptions.SmallImage")));
            this.nbPhieuNhapHang.Name = "nbPhieuNhapHang";
            this.nbPhieuNhapHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbPhieuNhapHang_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Bảng Kê";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTheoChungTu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTheoHangHoa)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nbTheoChungTu
            // 
            this.nbTheoChungTu.Caption = "Theo Chứng Từ";
            this.nbTheoChungTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.LargeImage")));
            this.nbTheoChungTu.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.SmallImage")));
            this.nbTheoChungTu.Name = "nbTheoChungTu";
            this.nbTheoChungTu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTheoChungTu_LinkClicked);
            // 
            // nbTheoHangHoa
            // 
            this.nbTheoHangHoa.Caption = "Theo Hàng Hóa";
            this.nbTheoHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.LargeImage")));
            this.nbTheoHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.SmallImage")));
            this.nbTheoHangHoa.Name = "nbTheoHangHoa";
            this.nbTheoHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTheoHangHoa_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Thêm Danh Mục";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Hàng Hóa";
            this.navBarItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.LargeImage")));
            this.navBarItem4.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.SmallImage")));
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Khách Hàng";
            this.navBarItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.ImageOptions.LargeImage")));
            this.navBarItem5.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.ImageOptions.SmallImage")));
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Kho Hàng";
            this.navBarItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem6.ImageOptions.LargeImage")));
            this.navBarItem6.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem6.ImageOptions.SmallImage")));
            this.navBarItem6.Name = "navBarItem6";
            // 
            // navBarControl1
            // 
            this.navBarControl1.Location = new System.Drawing.Point(108, 78);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(140, 300);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // ucBanHang1
            // 
            this.ucBanHang1.Location = new System.Drawing.Point(201, 0);
            this.ucBanHang1.Name = "ucBanHang1";
            this.ucBanHang1.Size = new System.Drawing.Size(1052, 378);
            this.ucBanHang1.TabIndex = 3;
            // 
            // frmMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 382);
            this.Controls.Add(this.ucBanHang1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmMuaHang";
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.frmMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbPhieuNhapHang;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nbTheoChungTu;
        private DevExpress.XtraNavBar.NavBarItem nbTheoHangHoa;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private UC.UcBanHang ucBanHang1;
    }
}