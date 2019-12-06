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
using NTD.DTO;
using NTD.BUS;

namespace NTD.GUI
{
    public partial class frmThemDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmThemDonViTinh()
        {
            InitializeComponent();
            this.Text = "Thêm Đơn Vị";
            btnLuu.Text = "Lưu";
        }
        string check;
        DonVi_BUS dv_bus = new DonVi_BUS();
        public frmThemDonViTinh(DonVi dv)
        {
            InitializeComponent();
            this.Text = "Cập Nhật Đơn Vị";
            btnLuu.Text = "Cập Nhật";

            check = dv.Ma;
            txtMa.Enabled = false;

            txtMa.Text = dv.Ma;
            txtTen.Text = dv.Ten;
            txtGhiChu.Text = dv.GhiChu;

        }
        private void frmThemDonViTinh_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check== null)
            {
                DonVi dv = new DonVi()
                {
                    Ma = txtMa.Text,
                    Ten = txtTen.Text,
                    GhiChu = txtGhiChu.Text
                };
                if (dv_bus.ThemDV(dv) > 0)
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DonVi dv = new DonVi()
                {
                    Ma = txtMa.Text,
                    Ten = txtTen.Text,
                    GhiChu = txtGhiChu.Text
                };
                if (dv_bus.Update(dv) > 0)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}