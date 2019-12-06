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
    public partial class frmThemNhomHang : DevExpress.XtraEditors.XtraForm
    {
        string check;
        public frmThemNhomHang()
        {
            InitializeComponent();

            this.Text = "Thêm Nhóm Hàng";
            btnLuu.Text = "Lưu";

        }

        public frmThemNhomHang(NhomHang nh)
        {
            InitializeComponent();
            this.Text = "Cập Nhật Nhóm Hàng";
            btnLuu.Text = "Cập nhật";
            txtMa.Enabled = false;

            check = nh.Ma;

            txtMa.Text = nh.Ma;
            txtTen.Text = nh.Ten;
        }

        NhomHang_BUS bus_nh = new NhomHang_BUS();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check == null)
            {
                NhomHang akh = new NhomHang()
                {
                    Ma = txtMa.Text,
                    Ten = txtTen.Text

                };
                if (bus_nh.ThemNhomHang(akh) > 0)
                {
                    MessageBox.Show("Thêm nhóm hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                NhomHang akh = new NhomHang()
                {
                    Ma = txtMa.Text,
                    Ten = txtTen.Text

                };
                if (bus_nh.Update(akh) > 0)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}