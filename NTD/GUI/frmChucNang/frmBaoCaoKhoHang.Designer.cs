namespace NTD.GUI.frmChucNang
{
    partial class frmBaoCaoKhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoKhoHang));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbTonKhoTongHop = new DevExpress.XtraNavBar.NavBarItem();
            this.nbNhapXuatTon = new DevExpress.XtraNavBar.NavBarItem();
            this.nbTheKho = new DevExpress.XtraNavBar.NavBarItem();
            this.nbChiTietHD = new DevExpress.XtraNavBar.NavBarItem();
            this.nbLSHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ucBaoCao = new NTD.GUI.UC.UCTrong();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.dockPanel1.ID = new System.Guid("f2ec8574-feaf-4fb5-a43f-5cd8eecc3f25");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 419);
            this.dockPanel1.Text = "Danh Sách Báo Cáo";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 390);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.navBarControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(193, 390);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbTonKhoTongHop,
            this.nbNhapXuatTon,
            this.nbTheKho,
            this.nbChiTietHD,
            this.nbLSHangHoa});
            this.navBarControl1.Location = new System.Drawing.Point(12, 12);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 169;
            this.navBarControl1.Size = new System.Drawing.Size(169, 366);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Tồn Kho";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTonKhoTongHop),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbNhapXuatTon),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTheKho),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbChiTietHD),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbLSHangHoa)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbTonKhoTongHop
            // 
            this.nbTonKhoTongHop.Caption = "Tồn Kho Tổng Hợp";
            this.nbTonKhoTongHop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbTonKhoTongHop.ImageOptions.LargeImage")));
            this.nbTonKhoTongHop.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbTonKhoTongHop.ImageOptions.SmallImage")));
            this.nbTonKhoTongHop.Name = "nbTonKhoTongHop";
            this.nbTonKhoTongHop.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTonKhoTongHop_LinkClicked);
            // 
            // nbNhapXuatTon
            // 
            this.nbNhapXuatTon.Caption = "Nhập-Xuất-Tồn";
            this.nbNhapXuatTon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.LargeImage")));
            this.nbNhapXuatTon.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.SmallImage")));
            this.nbNhapXuatTon.Name = "nbNhapXuatTon";
            this.nbNhapXuatTon.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbNhapXuatTon_LinkClicked);
            // 
            // nbTheKho
            // 
            this.nbTheKho.Caption = "Thẻ Kho";
            this.nbTheKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.LargeImage")));
            this.nbTheKho.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.SmallImage")));
            this.nbTheKho.Name = "nbTheKho";
            this.nbTheKho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTheKho_LinkClicked);
            // 
            // nbChiTietHD
            // 
            this.nbChiTietHD.Caption = "Số Chi Tiết Hóa Đơn";
            this.nbChiTietHD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.LargeImage")));
            this.nbChiTietHD.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.SmallImage")));
            this.nbChiTietHD.Name = "nbChiTietHD";
            this.nbChiTietHD.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbChiTietHD_LinkClicked);
            // 
            // nbLSHangHoa
            // 
            this.nbLSHangHoa.Caption = "Lịch Sử Hàng Hóa";
            this.nbLSHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.ImageOptions.LargeImage")));
            this.nbLSHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.ImageOptions.SmallImage")));
            this.nbLSHangHoa.Name = "nbLSHangHoa";
            this.nbLSHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbLSHangHoa_LinkClicked);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(193, 390);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.navBarControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(173, 370);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucBaoCao
            // 
            this.ucBaoCao.Location = new System.Drawing.Point(202, 0);
            this.ucBaoCao.Name = "ucBaoCao";
            this.ucBaoCao.Size = new System.Drawing.Size(761, 416);
            this.ucBaoCao.TabIndex = 1;
            // 
            // frmBaoCaoKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 419);
            this.Controls.Add(this.ucBaoCao);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmBaoCaoKhoHang";
            this.Text = "Báo Cáo Tổng Hợp Kho";
            this.Load += new System.EventHandler(this.frmBaoCaoKhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private UC.UCTrong ucBaoCao;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbTonKhoTongHop;
        private DevExpress.XtraNavBar.NavBarItem nbNhapXuatTon;
        private DevExpress.XtraNavBar.NavBarItem nbTheKho;
        private DevExpress.XtraNavBar.NavBarItem nbChiTietHD;
        private DevExpress.XtraNavBar.NavBarItem nbLSHangHoa;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}