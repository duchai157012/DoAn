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
using NTD.GUI.UC_report;

namespace NTD.GUI.frmChucNang
{
    public partial class frmBaoCaoKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCaoKhoHang()
        {
            InitializeComponent();
        }
        private void LoadTonKhoTongHop()
        {

            Uc_TonKhoTongHop pbh = new Uc_TonKhoTongHop();
            pbh.Dock = DockStyle.Fill;
            ucBaoCao.Controls.Clear();
            ucBaoCao.Controls.Add(pbh);
            ucBaoCao.Dock = DockStyle.Fill;

        }
        private void LoadNhapXuatTon()
        {

            Uc_NhapXuatTon pbh = new Uc_NhapXuatTon();
            pbh.Dock = DockStyle.Fill;
            ucBaoCao.Controls.Clear();
            ucBaoCao.Controls.Add(pbh);
            ucBaoCao.Dock = DockStyle.Fill;

        }
        private void LoadTheKho()
        {

            Uc_TheKho pbh = new Uc_TheKho();
            pbh.Dock = DockStyle.Fill;
            ucBaoCao.Controls.Clear();
            ucBaoCao.Controls.Add(pbh);
            ucBaoCao.Dock = DockStyle.Fill;

        }
        private void LoadChiTietHD()
        {

            Uc_SoChiTietHangHoa pbh = new Uc_SoChiTietHangHoa();
            pbh.Dock = DockStyle.Fill;
            ucBaoCao.Controls.Clear();
            ucBaoCao.Controls.Add(pbh);
            ucBaoCao.Dock = DockStyle.Fill;

        }
        private void nbTonKhoTongHop_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadTonKhoTongHop();
        }

        private void frmBaoCaoKhoHang_Load(object sender, EventArgs e)
        {
            LoadTonKhoTongHop(); 
        }

        private void nbNhapXuatTon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadNhapXuatTon();
        }

        private void nbTheKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadTheKho();
        }

        private void nbChiTietHD_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadChiTietHD();
        }

        private void nbLSHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
    }
}