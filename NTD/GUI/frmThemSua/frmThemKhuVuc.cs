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
    public partial class frmThemKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhuVuc()
        {
            InitializeComponent();
            this.Text = "Thêm Khu Vực";
            btnLuu.Text = "Lưu";
        }
        KhuVuc_BUS Bus_kv = new KhuVuc_BUS();
        string check;
        public frmThemKhuVuc(KhuVuc kv)
        {
            InitializeComponent();
            this.Text = "Cập Nhật Khu Vực";
            btnLuu.Text = "Cập Nhật";
            txtMa.Enabled = false;

            check = kv.MaKV;
            txtMa.Text = kv.MaKV;
            txtTen.Text = kv.TenKV;

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check == null)
            {
                if (txtMa.Text.Length == 0 || txtTen.Text.Length == 0)
                {
                    MessageBox.Show("Mã hoặc tên không được bỏ trống ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    KhuVuc kv = new KhuVuc()
                    {
                        MaKV = txtMa.Text,
                        TenKV = txtTen.Text

                    };
                    if (Bus_kv.ThemKV(kv) > 0)
                    {
                        MessageBox.Show("Thêm khu vực thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (txtMa.Text.Length == 0 || txtTen.Text.Length == 0)
                {
                    MessageBox.Show("Mã hoặc tên không được bỏ trống ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    KhuVuc kv = new KhuVuc()
                    {
                        MaKV = txtMa.Text,
                        TenKV = txtTen.Text

                    };
                    if (Bus_kv.Update(kv) > 0)
                    {
                        MessageBox.Show("Cập nhật khu vực thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}