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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        NhaCC_BUS Bus_ncc = new NhaCC_BUS();

        private void LoadData()
        {
            var dataTable = Bus_ncc.GetAllData();

            gcNhaCC.DataSource = dataTable;
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.dictRoleForm[tag];
            usChucNang1.EnnableFunction(roleform);
            usChucNang1.Controls["btnthem"].Click += ThemNCC;
            usChucNang1.Controls["btnxoa"].Click += Xoa;
            usChucNang1.Controls["btnsua"].Click += Sua;
            usChucNang1.Controls["btnxuat"].Click += xuat;
            usChucNang1.Controls["btnnaplai"].Click += naplai;
            usChucNang1.Controls["btndong"].Click += dong;

            LoadData();
           
        }

        private void dong(object sender, EventArgs e)
        {
            this.Close();
        }

        private void naplai(object sender, EventArgs e)
        {
            gcNhaCC.Refresh();
        }

        private void xuat(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();

            SaveFileDialog.ShowDialog();

            gvNhaCungCap.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }
        private void Sua(object sender, EventArgs e)
        {
            NhaCC nh = new NhaCC()
            {
                MaNCC = gvNhaCungCap.GetRowCellValue(gvNhaCungCap.FocusedRowHandle, "Mã").ToString(),
                Ten = gvNhaCungCap.GetRowCellValue(gvNhaCungCap.FocusedRowHandle, "Tên").ToString(),
                MoTa = gvNhaCungCap.GetRowCellValue(gvNhaCungCap.FocusedRowHandle, "Mô Tả").ToString(),
                MaKV = gvNhaCungCap.GetRowCellValue(gvNhaCungCap.FocusedRowHandle, "Tên khu vực").ToString(),
            };

            frmThemNCC tnh = new frmThemNCC(nh);
            tnh.ShowDialog();
            LoadData();
        }

        private void Xoa(object sender, EventArgs e)
        {
            string ma = gvNhaCungCap.GetRowCellValue(gvNhaCungCap.FocusedRowHandle, "Mã").ToString();

            if (gvNhaCungCap.GetRowCellValue(gvNhaCungCap.FocusedRowHandle, "Mã").ToString() != null)
            {
                var rs = Bus_ncc.DeleteById(ma);

                if (rs > 0)
                {
                    LoadData();
                    MessageBox.Show("Delete Successfully!!!!!!!!");
                }
            }
        }

        private void ThemNCC(object sender, EventArgs e)
        {
            frmThemNCC ncc = new frmThemNCC();
            ncc.ShowDialog();
            LoadData();
        }
    }
}