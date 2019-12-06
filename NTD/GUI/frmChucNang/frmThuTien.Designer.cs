namespace NTD.GUI
{
    partial class frmThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuTien));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbDSPT = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.nbTraNgay = new DevExpress.XtraNavBar.NavBarItem();
            this.nvTheoDoiCongNo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbTongHopCongNo = new DevExpress.XtraNavBar.NavBarItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ucControl = new NTD.GUI.UC.UcBanHang();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
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
            this.dockPanel2});
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
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel2.ID = new System.Guid("2301a320-aff9-49a1-a51c-cd549b9eecad");
            this.dockPanel2.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(211, 200);
            this.dockPanel2.Size = new System.Drawing.Size(211, 498);
            this.dockPanel2.Text = "Chức năng";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.layoutControl1);
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(202, 471);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.navBarControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(202, 471);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbDSPT,
            this.navBarItem2,
            this.nbTraNgay,
            this.nvTheoDoiCongNo,
            this.nbTongHopCongNo});
            this.navBarControl1.Location = new System.Drawing.Point(12, 12);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 178;
            this.navBarControl1.Size = new System.Drawing.Size(178, 447);
            this.navBarControl1.TabIndex = 4;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Phiếu Thu";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbDSPT)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbDSPT
            // 
            this.nbDSPT.Caption = "Danh Sách Phiếu Thu";
            this.nbDSPT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbDSPT.ImageOptions.LargeImage")));
            this.nbDSPT.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbDSPT.ImageOptions.SmallImage")));
            this.nbDSPT.Name = "nbDSPT";
            this.nbDSPT.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbDSPT_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Bảng Kê";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTraNgay),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvTheoDoiCongNo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTongHopCongNo)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Danh Sách Phiếu Công Nợ";
            this.navBarItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.LargeImage")));
            this.navBarItem2.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.SmallImage")));
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // nbTraNgay
            // 
            this.nbTraNgay.Caption = "Danh Sách Phiếu Trả Ngay";
            this.nbTraNgay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbTraNgay.ImageOptions.LargeImage")));
            this.nbTraNgay.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbTraNgay.ImageOptions.SmallImage")));
            this.nbTraNgay.Name = "nbTraNgay";
            this.nbTraNgay.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTraNgay_LinkClicked);
            // 
            // nvTheoDoiCongNo
            // 
            this.nvTheoDoiCongNo.Caption = "Theo Dõi Công Nợ";
            this.nvTheoDoiCongNo.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.SmallImage")));
            this.nvTheoDoiCongNo.Name = "nvTheoDoiCongNo";
            this.nvTheoDoiCongNo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvTheoDoiCongNo_LinkClicked);
            // 
            // nbTongHopCongNo
            // 
            this.nbTongHopCongNo.Caption = "Tổng Hợp Công Nợ";
            this.nbTongHopCongNo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.ImageOptions.LargeImage")));
            this.nbTongHopCongNo.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.ImageOptions.SmallImage")));
            this.nbTongHopCongNo.Name = "nbTongHopCongNo";
            this.nbTongHopCongNo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTongHopCongNo_LinkClicked);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(202, 471);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.navBarControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(182, 451);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucControl
            // 
            this.ucControl.Location = new System.Drawing.Point(200, 0);
            this.ucControl.Name = "ucControl";
            this.ucControl.Size = new System.Drawing.Size(909, 494);
            this.ucControl.TabIndex = 3;
            // 
            // frmThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 498);
            this.Controls.Add(this.ucControl);
            this.Controls.Add(this.dockPanel2);
            this.Name = "frmThuTien";
            this.Text = "frmThuTien";
            this.Load += new System.EventHandler(this.frmThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UC.UcBanHang ucControl;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbDSPT;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem nbTraNgay;
        private DevExpress.XtraNavBar.NavBarItem nvTheoDoiCongNo;
        private DevExpress.XtraNavBar.NavBarItem nbTongHopCongNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}