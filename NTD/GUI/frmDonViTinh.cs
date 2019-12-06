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
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }
        DonVi_BUS dv_bus = new DonVi_BUS();
        private void usChucNang1_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            var dataTable = dv_bus.GetAllData();
            gcDonVi.DataSource = dataTable;
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.dictRoleForm[tag];
            usChucNang1.EnnableFunction(roleform);
            usChucNang1.Controls["btndong"].Click += dong;
            usChucNang1.Controls["btnthem"].Click += them;
            usChucNang1.Controls["btnxoa"].Click += xoa;
            usChucNang1.Controls["btnsua"].Click += sua;
            usChucNang1.Controls["btnnaplai"].Click += naplai;
            usChucNang1.Controls["btnxuat"].Click += xuat;

            LoadData();
        }

        private void xuat(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();

            SaveFileDialog.ShowDialog();

            gvDonVi.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void naplai(object sender, EventArgs e)
        {
            gcDonVi.Refresh();
        }

        private void sua(object sender, EventArgs e)
        {
            DonVi dv = new DonVi()
            {
                Ma = gvDonVi.GetRowCellValue(gvDonVi.FocusedRowHandle, "Mã").ToString(),
                Ten = gvDonVi.GetRowCellValue(gvDonVi.FocusedRowHandle, "Tên").ToString(),
                GhiChu = gvDonVi.GetRowCellValue(gvDonVi.FocusedRowHandle, "Ghi Chú").ToString()
              
            };

            frmThemDonViTinh thh = new frmThemDonViTinh(dv);
            thh.ShowDialog();
            LoadData();
        }

        private void xoa(object sender, EventArgs e)
        {
            string ma = gvDonVi.GetRowCellValue(gvDonVi.FocusedRowHandle, "Mã").ToString();

            if (gvDonVi.GetRowCellValue(gvDonVi.FocusedRowHandle, "Mã").ToString() != null)
            {
                var rs = dv_bus.DeleteById(ma);

                if (rs > 0)
                {
                    LoadData();
                    MessageBox.Show("Delete Successfully!!!!!!!!");
                }
            }
        }

        private void them(object sender, EventArgs e)
        {
            frmThemDonViTinh thh = new frmThemDonViTinh();
            thh.ShowDialog();
            LoadData();
        }

        private void dong(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}