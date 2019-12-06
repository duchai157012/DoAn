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

namespace NTD.GUI.frmChucNang
{
    public partial class frmTraTien : DevExpress.XtraEditors.XtraForm
    {
        public frmTraTien()
        {
            InitializeComponent();
        }
        private void LoadDanhSachPC()
        {
            Uc_TraTien_DSPC pbh = new Uc_TraTien_DSPC();
            pbh.Dock = DockStyle.Fill;
            ucControl.Controls.Clear();
            ucControl.Controls.Add(pbh);
            ucControl.Dock = DockStyle.Fill;
        }
        private void LoadDanhSachCN()
        {
            Uc_TraTien_DSPCN pbh = new Uc_TraTien_DSPCN();
            pbh.Dock = DockStyle.Fill;
            ucControl.Controls.Clear();
            ucControl.Controls.Add(pbh);
            ucControl.Dock = DockStyle.Fill;
        }
        private void LoadDanhSachTN()
        {
            Uc_TraTien_DSPTN pbh = new Uc_TraTien_DSPTN();
            pbh.Dock = DockStyle.Fill;
            ucControl.Controls.Clear();
            ucControl.Controls.Add(pbh);
            ucControl.Dock = DockStyle.Fill;
        }
        private void nbDSPC_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDanhSachPC();
        }

        private void nbDSPCN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDanhSachCN();
        }

        private void nbDSPTN_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadDanhSachTN();
        }

        private void frmTraTien_Load(object sender, EventArgs e)
        {
            LoadDanhSachPC();
        }
    }
}