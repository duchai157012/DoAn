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
    public partial class frmKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmKhuVuc()
        {
            InitializeComponent();
        }
        KhuVuc_BUS Bus_kv = new KhuVuc_BUS();
        private void LoadData()
        {
            var dataTable = Bus_kv.GetAllData();

            gcKhuVuc.DataSource = dataTable;
        }
        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.dictRoleForm[tag];
            usChucNang1.EnnableFunction(roleform);
            usChucNang1.Controls["btndong"].Click += Dong;
            usChucNang1.Controls["btnthem"].Click += ThemKV;
            usChucNang1.Controls["btnsua"].Click += sua;
            usChucNang1.Controls["btnxoa"].Click += xoa;
            usChucNang1.Controls["btnxuat"].Click += xuat;
            usChucNang1.Controls["btnnaplai"].Click += naplai;

            LoadData();

        }

        private void naplai(object sender, EventArgs e)
        {
            gcKhuVuc.Refresh();           
        }

        private void xuat(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();
            SaveFileDialog.ShowDialog();

            gvKhuVuc.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void xoa(object sender, EventArgs e)
        {
            string ma = gvKhuVuc.GetRowCellValue(gvKhuVuc.FocusedRowHandle, "Mã").ToString();

            if (gvKhuVuc.GetRowCellValue(gvKhuVuc.FocusedRowHandle, "Mã").ToString() != null)
            {
                var rs = Bus_kv.DeleteById(ma);

                if (rs > 0)
                {
                    LoadData();
                    MessageBox.Show("Delete Successfully!!!!!!!!");
                }
            }
        }

        private void sua(object sender, EventArgs e)
        {

            KhuVuc kh = new KhuVuc()
            {
                MaKV = gvKhuVuc.GetRowCellValue(gvKhuVuc.FocusedRowHandle, "Mã").ToString(),
                TenKV = gvKhuVuc.GetRowCellValue(gvKhuVuc.FocusedRowHandle, "Tên").ToString()
               
            };

            frmThemKhuVuc tnh = new frmThemKhuVuc(kh);
            tnh.ShowDialog();
            LoadData();
        }

        private void ThemKV(object sender, EventArgs e)
        {
            frmThemKhuVuc tkv = new frmThemKhuVuc();
            tkv.ShowDialog();
        }

        private void Dong(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}