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
    public partial class frmKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoHang()
        {
            InitializeComponent();
        }
        KhoHang_BUS Bus_kh = new KhoHang_BUS();
        private void LoadData()
        {
            var dataTable = Bus_kh.GetAllData();

            gcKhoHang.DataSource = dataTable;
        }
        private void frmKhoHang_Load(object sender, EventArgs e)
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
            gcKhoHang.Refresh();
        }

        private void xuat(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();

            SaveFileDialog.ShowDialog();

            gvKhoHang.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }
        private void Sua(object sender, EventArgs e)
        {
            KhoHang kh = new KhoHang()
            {
                MaKho = gvKhoHang.GetRowCellValue(gvKhoHang.FocusedRowHandle, "Mã").ToString(),
                TenKho = gvKhoHang.GetRowCellValue(gvKhoHang.FocusedRowHandle, "Tên").ToString(),
                LienHe = gvKhoHang.GetRowCellValue(gvKhoHang.FocusedRowHandle, "Liên Hệ").ToString(),
                DienThoai = gvKhoHang.GetRowCellValue(gvKhoHang.FocusedRowHandle, "Điện Thoại").ToString(),
                GhiChu = gvKhoHang.GetRowCellValue(gvKhoHang.FocusedRowHandle, "Ghi Chú").ToString()
                //ConQuanLy = bool.Parse( gvKhoHang.GetRowCellValue(gvKhoHang.FocusedRowHandle, "Còn Quản Lý").ToString())
            };

            frmThemKhoHang tnh = new frmThemKhoHang(kh);
            tnh.ShowDialog();
            LoadData();
        }

        private void Xoa(object sender, EventArgs e)
        {
            string ma = gvKhoHang.GetRowCellValue(gvKhoHang.FocusedRowHandle, "Mã").ToString();

            if (gvKhoHang.GetRowCellValue(gvKhoHang.FocusedRowHandle, "Mã").ToString() != null)
            {
                var rs = Bus_kh.DeleteById(ma);

                if (rs > 0)
                {
                    LoadData();
                    MessageBox.Show("Delete Successfully!!!!!!!!");
                }
            }
        }

        private void ThemKH(object sender, EventArgs e)
        {
            frmThemKhoHang tkh = new frmThemKhoHang();
            tkh.ShowDialog();
            LoadData();
        }

        private void dong(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}