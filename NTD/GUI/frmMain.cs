using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using NTD.BUS;
using NTD.GUI;
using NTD.GUI.frmChucNang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NTD
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public int RoleId;
        public Form1(int roleId)
        {
            this.RoleId = roleId;
            InitializeComponent();
            CheckVisible();
        }

        private void CheckVisible()
        {
            if (RoleId == 1)
            {
                this.ribbonPage2.Visible = false;
                this.btnPhanQuyen.Visibility = BarItemVisibility.Never;
                this.btnNhatKyHeThong.Visibility = BarItemVisibility.Never;
                btnMuaHang.Visibility = BarItemVisibility.Never;
                btnTonKho.Visibility = BarItemVisibility.Never;
                btnNhapSoDu.Visibility = BarItemVisibility.Never;
                btnChungTu.Visibility = BarItemVisibility.Never;
                //barButtonItem8.Visibility = BarItemVisibility.Never;
                btnKhoHang.Visibility = BarItemVisibility.Never;
            }

            if (RoleId == 2)
            {
                this.btnPhanQuyen.Visibility = BarItemVisibility.Never;
            }
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhanQuyen phanQuyen = new frmPhanQuyen();           
            if (ExistsForm(phanQuyen)) return;
            phanQuyen.MdiParent = this;
            phanQuyen.Show();
        }

        private void btnNhatKyHeThong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhatKy nk = new frmNhatKy();
            if (ExistsForm(nk)) return;
            nk.MdiParent = this;
            nk.Show();
        }

        private void K_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhuVuc kv = new frmKhuVuc();
            if (ExistsForm(kv)) return;
            kv.MdiParent = this;
            kv.Show();
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            if (ExistsForm(kh)) return;
            kh.MdiParent = this;
            kh.Show();
        }

        private void btnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhaCungCap ncc = new frmNhaCungCap();
            if (ExistsForm(ncc)) return;
            ncc.MdiParent=this;
            ncc.Show();
        }

        private void btnKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoHang kh = new frmKhoHang();
            if (ExistsForm(kh)) return;
            kh.MdiParent = this;
            kh.Show();
        }

        private void btnDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDonViTinh dvt = new frmDonViTinh();
            if (ExistsForm(dvt)) return;
            dvt.MdiParent = this;
            dvt.Show();
        }

        private void btnNhomHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhomHang nh = new frmNhomHang();
            if (ExistsForm(nh)) return;
            nh.MdiParent = this;
            nh.Show();
        }

        private void btnHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHangHoa hh = new frmHangHoa();
            if (ExistsForm(hh)) return;
            hh.MdiParent = this;
            hh.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTyGia tg = new frmTyGia();
            if (ExistsForm(tg)) return;
            tg.MdiParent = this;
            tg.Show();
        }


        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNVien nvien = new frmNVien();
            if (ExistsForm(nvien)) return;
            nvien.MdiParent = this;
            nvien.Show();
        }

        private void btnMuaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMuaHang muaHang = new frmMuaHang();
            if (ExistsForm(muaHang)) return;
            muaHang.MdiParent = this;
            muaHang.Show();
        }

        private void btnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBanHang bh = new frmBanHang();
            if (ExistsForm(bh)) return;
            bh.MdiParent = this;
            bh.Show();
        }

        private void btnTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTonKho tk = new frmTonKho();
            if (ExistsForm(tk)) return;
            tk.MdiParent = this;
            tk.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChuyenKho ck = new frmChuyenKho();
            if (ExistsForm(ck)) return;
            ck.MdiParent = this;
            ck.Show();
        }

        private void btnTraTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTraTien tt = new frmTraTien();
            if (ExistsForm(tt)) return;
            tt.MdiParent = this;
            tt.Show();
        }

        private void btnThuTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThuTien thuTien = new frmThuTien();
            if (ExistsForm(thuTien)) return;
            thuTien.MdiParent = this;
            thuTien.Show();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn thoát???", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTT_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("NTD","Thông Tin",MessageBoxButtons.OK);
        }
        private bool ExistsForm(XtraForm form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMK mk = new frmDoiMK();
            mk.ShowDialog();
        }

        private void btnBaoCaoKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaoCaoKhoHang bc = new frmBaoCaoKhoHang();
            if (ExistsForm(bc)) return;
            bc.MdiParent = this;
            bc.Show();
        }

        private void btnBaoCaoBH_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaoCaoBanHang bc = new frmBaoCaoBanHang();
            if (ExistsForm(bc)) return;
            bc.MdiParent = this;
            bc.Show();
        }

        private void btnChungTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChungTu bc = new frmChungTu();
            if (ExistsForm(bc)) return;
            bc.MdiParent = this;
            bc.Show();
        }
    }
}
