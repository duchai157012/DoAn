namespace NTD.GUI.frmChucNang
{
    partial class frmTraTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraTien));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbDSPC = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbDSPCN = new DevExpress.XtraNavBar.NavBarItem();
            this.nbDSPTN = new DevExpress.XtraNavBar.NavBarItem();
            this.nbTDCN = new DevExpress.XtraNavBar.NavBarItem();
            this.nbTHCN = new DevExpress.XtraNavBar.NavBarItem();
            this.ucControl = new NTD.GUI.UC.UCTrong();
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
            this.dockPanel1.ID = new System.Guid("f1ab7952-cd5f-42d2-9164-f8144b09cdc3");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(194, 200);
            this.dockPanel1.Size = new System.Drawing.Size(194, 441);
            this.dockPanel1.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(185, 414);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbDSPC,
            this.nbDSPCN,
            this.nbDSPTN,
            this.nbTDCN,
            this.nbTHCN});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 185;
            this.navBarControl1.Size = new System.Drawing.Size(185, 414);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Phiếu Chi";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbDSPC)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbDSPC
            // 
            this.nbDSPC.Caption = "Danh Sách Phiếu Chi";
            this.nbDSPC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbDSPC.ImageOptions.LargeImage")));
            this.nbDSPC.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbDSPC.ImageOptions.SmallImage")));
            this.nbDSPC.Name = "nbDSPC";
            this.nbDSPC.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbDSPC_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Bảng Kê";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbDSPCN),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbDSPTN),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTDCN),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTHCN)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nbDSPCN
            // 
            this.nbDSPCN.Caption = "Danh Sách Phiếu Công Nợ";
            this.nbDSPCN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbDSPCN.ImageOptions.LargeImage")));
            this.nbDSPCN.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbDSPCN.ImageOptions.SmallImage")));
            this.nbDSPCN.Name = "nbDSPCN";
            this.nbDSPCN.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbDSPCN_LinkClicked);
            // 
            // nbDSPTN
            // 
            this.nbDSPTN.Caption = "Danh Sách Phiếu Trả Ngay";
            this.nbDSPTN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbDSPTN.ImageOptions.LargeImage")));
            this.nbDSPTN.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbDSPTN.ImageOptions.SmallImage")));
            this.nbDSPTN.Name = "nbDSPTN";
            this.nbDSPTN.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbDSPTN_LinkClicked);
            // 
            // nbTDCN
            // 
            this.nbTDCN.Caption = "Theo Dõi Công Nợ";
            this.nbTDCN.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbTDCN.ImageOptions.SmallImage")));
            this.nbTDCN.Name = "nbTDCN";
            // 
            // nbTHCN
            // 
            this.nbTHCN.Caption = "Tổng Hợp Công Nợ";
            this.nbTHCN.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbTHCN.ImageOptions.SmallImage")));
            this.nbTHCN.Name = "nbTHCN";
            // 
            // ucControl
            // 
            this.ucControl.Location = new System.Drawing.Point(195, 0);
            this.ucControl.Name = "ucControl";
            this.ucControl.Size = new System.Drawing.Size(981, 437);
            this.ucControl.TabIndex = 1;
            // 
            // frmTraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 441);
            this.Controls.Add(this.ucControl);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmTraTien";
            this.Text = "frmTraTien";
            this.Load += new System.EventHandler(this.frmTraTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private UC.UCTrong ucControl;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbDSPC;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nbDSPCN;
        private DevExpress.XtraNavBar.NavBarItem nbDSPTN;
        private DevExpress.XtraNavBar.NavBarItem nbTDCN;
        private DevExpress.XtraNavBar.NavBarItem nbTHCN;
    }
}