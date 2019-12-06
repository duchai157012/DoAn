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
using NTD.DAO;

namespace NTD.GUI
{
    public partial class frmThemNCC : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNCC()
        {
            InitializeComponent();
            this.Text = "Thêm Nhà Cung Cấp";
            btnLuu.Text = "Lưu";
        }
        string check;
        public frmThemNCC(NhaCC ncc)
        {
            InitializeComponent();
            this.Text = "Cập Nhật Nhà Cung Cấp";
            btnLuu.Text = "Cập Nhật";

            txtMa.Enabled = false;

            check = ncc.MaNCC;

            txtMa.Text = ncc.MaNCC;
            txtTen.Text = ncc.Ten;
            txtMoTa.Text = ncc.MoTa;
            cbKhuVuc.Text = ncc.MaKV;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check == null)
            {
                NhaCC akh = new NhaCC()
                {
                    MaNCC = txtMa.Text,
                    Ten = txtTen.Text,
                    MoTa = txtMoTa.Text,
                    MaKV = cbKhuVuc.EditValue.ToString()
                };
                if (BusNCC.ThemNhaCC(akh) > 0)
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                NhaCC akh = new NhaCC()
                {
                    MaNCC = txtMa.Text,
                    Ten = txtTen.Text,
                    MoTa = txtMoTa.Text,
                    MaKV = cbKhuVuc.EditValue.ToString()
                };
                if (BusNCC.Update(akh) > 0)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        NhaCC_BUS BusNCC = new NhaCC_BUS();
        db db = new db();
        private void frmThemNCC_Load(object sender, EventArgs e)
        {
            var dataTable = BusNCC.GetAllDataKV();

            cbKhuVuc.Properties.DataSource = dataTable;
            cbKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            cbKhuVuc.Properties.ValueMember = "MaKhuVuc";

            //int stt = db.GetSoLuong("NhaCungCap") + 1;
            //string maMacDinh;
            //if (stt < 10)
            //{
            //    maMacDinh = "NCC00" + stt;
            //}
            //else
            //{
            //    maMacDinh = "NCC0" + stt;
            //}
            //txtMa.Text = maMacDinh;

        }
    }
}