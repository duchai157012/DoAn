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
using NTD.DAO;

namespace NTD.GUI
{
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        string check;
        public frmThemNhanVien()
        {
            InitializeComponent();

            this.Text = "Thêm Nhân Viên";
            btnLuu.Text = "Lưu";
        }

        public frmThemNhanVien( NhanVien nhanVien)
        {
            InitializeComponent();

            this.Text = "Cập Nhật Nhân Viên";
            btnLuu.Text = "Cập Nhật";

            txtMa.Enabled = false;
            check = nhanVien.MaNV;

            txtMa.Text = nhanVien.MaNV;
            txtHoTen.Text = nhanVien.HoTen;
            txtDiaChi.Text = nhanVien.DiaChi;
            txtDienThoai.Text = nhanVien.DienThoai;
        }


        NhanVien_BUS busNV = new NhanVien_BUS();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check == null)
            {
                NhanVien nhanVien = new NhanVien()
                {
                    MaNV = txtMa.Text,
                    HoTen = txtHoTen.Text,
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtDienThoai.Text
                };
                if (busNV.ThemNV(nhanVien) > 0)
                {
                    MessageBox.Show("Thêm nhan vien thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                NhanVien nhanVien = new NhanVien()
                {
                    MaNV = txtMa.Text,
                    HoTen = txtHoTen.Text,
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtDienThoai.Text

                };
                if (busNV.Update(nhanVien) > 0)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        db db = new db();
        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            int stt = db.GetSoLuong("NhanVien") + 1;
            string maMacDinh;
            if (stt < 10)
            {
                maMacDinh = "NV00" + stt;
            }
            else
            {
                maMacDinh = "NV0" + stt;
            }
            txtMa.Text = maMacDinh;
        }
    }
}