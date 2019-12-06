using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NTD.GUI.UC;

namespace NTD.GUI
{
    public partial class frmThuTien : DevExpress.XtraEditors.XtraForm
    {
        public frmThuTien()
        {
            InitializeComponent();
        }
        private void LoadPhieuChuyenKho()
        {
            Uc_ThuTien_DSPT pbh = new Uc_ThuTien_DSPT();
            pbh.Dock = DockStyle.Fill;
            ucControl.Controls.Clear();
            ucControl.Controls.Add(pbh);
            ucControl.Dock = DockStyle.Fill;
        }
        private void LoadPhieuCongNo()
        {
            Uc_ThuTien_DSPCN pbh = new Uc_ThuTien_DSPCN();
            pbh.Dock = DockStyle.Fill;
            ucControl.Controls.Clear();
            ucControl.Controls.Add(pbh);
            ucControl.Dock = DockStyle.Fill;
        }
        private void LoadPhieuTraNgay()
        {
            Uc_ThuTien_DSPCN pbh = new Uc_ThuTien_DSPCN();
            pbh.Dock = DockStyle.Fill;
            ucControl.Controls.Clear();
            ucControl.Controls.Add(pbh);
            ucControl.Dock = DockStyle.Fill;
        }
        private void nbDSPT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadPhieuChuyenKho();
        }

        private void frmThuTien_Load(object sender, EventArgs e)
        {
            LoadPhieuChuyenKho();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadPhieuCongNo();
        }

        private void nbTraNgay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadPhieuTraNgay();
        }

        private void nvTheoDoiCongNo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void nbTongHopCongNo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
    }
}