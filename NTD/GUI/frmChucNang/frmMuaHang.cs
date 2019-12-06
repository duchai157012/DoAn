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
    public partial class frmMuaHang : DevExpress.XtraEditors.XtraForm
    {
        public frmMuaHang()
        {
            InitializeComponent();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadPhieuNhapHang()
        {

            PhieuNhapHang pbh = new PhieuNhapHang();
            pbh.Dock = DockStyle.Fill;
            ucBanHang1.Controls.Clear();
            ucBanHang1.Controls.Add(pbh);
            ucBanHang1.Dock = DockStyle.Fill;

        }
        private void LoadTheoChungTu()
        {
            UcTheoChungTu pbh = new UcTheoChungTu();
            pbh.Dock = DockStyle.Fill;
            ucBanHang1.Controls.Clear();
            ucBanHang1.Controls.Add(pbh);
            ucBanHang1.Dock = DockStyle.Fill;

        }
        private void LoadTheoHangHoa()
        {

            UcTheoHangHoa pbh = new UcTheoHangHoa();
            pbh.Dock = DockStyle.Fill;
            ucBanHang1.Controls.Clear();
            ucBanHang1.Controls.Add(pbh);
            ucBanHang1.Dock = DockStyle.Fill;

        }
        private void nbPhieuNhapHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadPhieuNhapHang();
        }

        private void frmMuaHang_Load(object sender, EventArgs e)
        {
            LoadPhieuNhapHang();
        }

        private void nbTheoChungTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadTheoChungTu();
        }

        private void nbTheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadTheoHangHoa();
        }
    }
}