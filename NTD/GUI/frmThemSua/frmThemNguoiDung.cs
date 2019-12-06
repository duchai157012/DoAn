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
using NTD.DAO;
using System.Data.SqlClient;
using NTD.BUS;
using NTD.DTO;

namespace NTD.GUI
{
    public partial class frmThemNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }

        private void btnDongND_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData();
            //LoadNhanVien();
        }

        ThemNguoiDung_BUS tnd = new ThemNguoiDung_BUS();
        public void LoadData()
        {
            var dataTable = tnd.GetAllDataVT();

            cbVaiTro.Properties.DataSource = dataTable;
            cbVaiTro.Properties.DisplayMember = "Descript";
            cbVaiTro.Properties.ValueMember = "Id";

            var dataTable1 = tnd.GetAllDataNV();
            cbnhanvien.Properties.DataSource = dataTable1;
            //cbNhanVien.DataSource = dataTable1;
            cbnhanvien.Properties.DisplayMember = "HoTen";
            cbnhanvien.Properties.ValueMember = "MaNV";
        }
       
        ThemNguoiDung_BUS nd = new ThemNguoiDung_BUS();
        private void btnLuuND_Click(object sender, EventArgs e)
        {
            NguoiDung nguoiDung = new NguoiDung()
            {
                Name = txtTaiKhoan.Text, Password = txtMatKhau.Text, VaiTro = int.Parse(cbVaiTro.EditValue.ToString()), MaNV = cbnhanvien.EditValue.ToString()
            };
            if(tnd.AddUser(nguoiDung) > 0)
            {
                MessageBox.Show("Thêm tai khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}