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
    public partial class frmThemKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhoHang()
        {
            InitializeComponent();
            this.Text = "Thêm Kho Hàng";
            btnLuu.Text = "Lưu";
        }
        string check;
        KhoHang_BUS kh_bus = new KhoHang_BUS();
        public frmThemKhoHang(KhoHang kh)
        {
            InitializeComponent();
            this.Text = "Cập Nhật Kho Hàng";
            btnLuu.Text = "Cập Nhật";

            txtMaKho.Enabled = false;

            check = kh.MaKho;
            txtMaKho.Text = kh.MaKho;
            txtTenKho.Text = kh.TenKho;
            txtLienHe.Text = kh.LienHe;
            txtGhiChu.Text = kh.GhiChu;
            txtDienThoai.Text = kh.DienThoai;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check==null)
            {
                KhoHang akh = new KhoHang()
                {
                    MaKho = txtMaKho.Text,
                    TenKho = txtTenKho.Text,
                    LienHe = txtLienHe.Text,
                    GhiChu = txtGhiChu.Text,
                    DienThoai =txtDienThoai.Text 
                    //ConQuanLy= ckQuanLy.Checked
                    
                };
                if (kh_bus.ThemKhoHang(akh) > 0)
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                KhoHang akh = new KhoHang()
                {
                    MaKho = txtMaKho.Text,
                    TenKho = txtTenKho.Text,
                    LienHe = txtLienHe.Text,
                    GhiChu = txtGhiChu.Text,
                    DienThoai = txtDienThoai.Text

                };
                if (kh_bus.Update(akh) > 0)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}