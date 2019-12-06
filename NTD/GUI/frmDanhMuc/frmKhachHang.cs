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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        KhachHang_BUS Bus_kh = new KhachHang_BUS();

        private void LoadData()
        {
            var dataTable = Bus_kh.GetAllData();

            gcKhachHang.DataSource = dataTable;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.dictRoleForm[tag];
            usChucNang1.EnnableFunction(roleform);
            usChucNang1.Controls["btndong"].Click += dong;
            usChucNang1.Controls["btnthem"].Click += ThemKH;
            usChucNang1.Controls["btnxoa"].Click += Xoa;
            usChucNang1.Controls["btnsua"].Click += Sua;
            usChucNang1.Controls["btnxuat"].Click += xuat;
            usChucNang1.Controls["btnnaplai"].Click += naplai;

            LoadData();
        }
        private void naplai(object sender, EventArgs e)
        {
            gcKhachHang.Refresh();
        }

        private void xuat(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();

            SaveFileDialog.ShowDialog();

            gvKhachHang.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void Xoa(object sender, EventArgs e)
        {
            string ma = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Mã KH").ToString();

            if (gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Mã KH").ToString() != null)
            {
                var rs = Bus_kh.DeleteById(ma);

                if (rs > 0)
                {
                    LoadData();
                    MessageBox.Show("Delete Successfully!!!!!!!!");
                }
            }

        }

        private void Sua(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang()
            {
                MaKH = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Mã KH").ToString(),
                Ten = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Tên khách hàng").ToString(),
                DiaChi = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Địa chỉ").ToString(),
                SDT = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Số điện thoại").ToString(),
                MaKV= gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Khu vực").ToString()
            };

            frmThemKhachHang tnh = new frmThemKhachHang(kh);
            tnh.ShowDialog();
            LoadData();
        }

        private void ThemKH(object sender, EventArgs e)
        {
            frmThemKhachHang tkh = new frmThemKhachHang();
            tkh.ShowDialog();
            LoadData();
        }

        private void dong(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}