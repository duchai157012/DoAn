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
using NTD.BUS;
using NTD.DTO;

namespace NTD.GUI
{
    public partial class frmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
            this.Text = "Thêm khách hàng";
            btnLuu.Text = "Lưu";
        }
        string check;
        public frmThemKhachHang(KhachHang kh)
        {
            InitializeComponent();
            this.Text = "Cập nhật khách hàng";
            btnLuu.Text = "Cập nhật";
            txtMa.Enabled = false;
            check = kh.MaKH;

            txtMa.Text = kh.MaKH;
            txtTen.Text = kh.Ten;
            txtDiaChi.Text = kh.DiaChi;
            txtSDT.Text = kh.SDT;
            cbKhuVuc.Text = kh.MaKV;


        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check == null)
            {
                KhachHang akh = new KhachHang()
                {
                    MaKH = txtMa.Text,
                    Ten = txtTen.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    MaKV = cbKhuVuc.EditValue.ToString()
                };
                if (BusKH.ThemKhachHang(akh) > 0)
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                KhachHang akh = new KhachHang()
                {
                    MaKH = txtMa.Text,
                    Ten = txtTen.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    MaKV = cbKhuVuc.EditValue.ToString()
                };
                if (BusKH.Update(akh) > 0)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }
        KhachHang_BUS BusKH = new KhachHang_BUS();
        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            var dataTable = BusKH.GetAllDataKV();

            cbKhuVuc.Properties.DataSource = dataTable;
            cbKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            cbKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }

    }
}