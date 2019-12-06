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
    public partial class frmThemHangHoa : DevExpress.XtraEditors.XtraForm
    {
        string check;
        public frmThemHangHoa()
        {
            InitializeComponent();
            this.Text = "Thêm Hàng Hóa";
            btnLuu.Text = "Lưu";
        }

        public frmThemHangHoa(HangHoa hh)
        {
            InitializeComponent();
            this.Text = "Cập Nhật Hàng Hóa";
            btnLuu.Text = "Cập Nhật";

            txtMa.Enabled = false;

            check = hh.Ma;

            txtMa.Text = hh.Ma;
            txtTen.Text = hh.Ten;
            txtMoTa.Text = hh.MoTa;
            txtHinhAnh.Text = hh.HinhAnh;
            cbDonVi.Text = hh.DonVi;
            txtSoLuong.Text = hh.Soluong.ToString();
            txtGiaMua.Text = hh.GiaMua.ToString();
            txtGiaBan.Text = hh.GiaBan.ToString();
            txtCode.Text = hh.Code;
            cbNhaCC.Text = hh.NhaCungCap;
            cbLoai.Text = hh.MaLoai;
            cbKho.Text = hh.MaKho;
            

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        HangHoa_BUS bus_hh = new HangHoa_BUS();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check == null)
            {
                // dung nhap hinh anh
                HangHoa hh = new HangHoa()
                {
                    Ma = txtMa.Text,
                    Ten = txtTen.Text,
                    MoTa = txtMoTa.Text,
                    HinhAnh = txtHinhAnh.Text,
                    DonVi = cbDonVi.EditValue.ToString(),
                    Soluong = int.Parse(txtSoLuong.Text),
                    GiaBan = float.Parse(txtGiaMua.Text),
                    GiaMua = float.Parse(txtGiaMua.Text),
                    Code = txtCode.Text,
                    NhaCungCap = cbNhaCC.EditValue.ToString(),
                    MaLoai = cbLoai.EditValue.ToString(),
                    MaKho=cbKho.EditValue.ToString()
                };
                if (bus_hh.ThemHangHoa(hh) > 0)
                {
                    MessageBox.Show("Thêm hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                HangHoa hh = new HangHoa()
                {
                    Ma = txtMa.Text,
                    Ten = txtTen.Text,
                    MoTa = txtMoTa.Text,
                    HinhAnh = txtHinhAnh.Text,
                    DonVi = cbDonVi.EditValue.ToString(),
                    Soluong = int.Parse(txtSoLuong.Text),
                    GiaMua = float.Parse(txtGiaMua.Text),
                    GiaBan = float.Parse(txtGiaBan.Text),
                    Code = txtCode.Text,
                    NhaCungCap = cbNhaCC.EditValue.ToString(),
                    MaLoai = cbLoai.EditValue.ToString(),
                    MaKho=cbKho.EditValue.ToString()
                };
                if (bus_hh.Update(hh) > 0)
                {
                    // mã sp sai
                    MessageBox.Show("Cập nhật hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
        db db = new db();
        private void frmThemHangHoa_Load(object sender, EventArgs e)
        {
            var dataTable = bus_hh.GetAllDataNCC();

            cbNhaCC.Properties.DataSource = dataTable;
            cbNhaCC.Properties.DisplayMember = "Ten";
            cbNhaCC.Properties.ValueMember = "MaNCC";

            var dataTable1 = bus_hh.GetAllDataLoaiSP();

            cbLoai.Properties.DataSource = dataTable1;
            cbLoai.Properties.DisplayMember = "TenLoaiHang";
            cbLoai.Properties.ValueMember = "MaLoaiHang";

            var dataTable2 = bus_hh.GetAllDataKhoHang();

            cbKho.Properties.DataSource = dataTable2;
            cbKho.Properties.DisplayMember = "TenKho";
            cbKho.Properties.ValueMember = "MaKho";

            var dataTable3 = bus_hh.GetAllDataDonVi();

            cbDonVi.Properties.DataSource = dataTable3;
            cbDonVi.Properties.DisplayMember = "TenDonVi";
            cbDonVi.Properties.ValueMember = "MaDonVi";

            //int stt = db.GetSoLuong("SanPham") + 1;
            //string maMacDinh = "SP0" + stt;
            //txtMa.Text = maMacDinh;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}