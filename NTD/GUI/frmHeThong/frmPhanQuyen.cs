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

namespace NTD.GUI
{
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void btnThemNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemNguoiDung ND = new frmThemNguoiDung();
            ND.ShowDialog();
        }
        PhanQuyen_BUS phanQuyenBUS = new PhanQuyen_BUS();
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            var dataTable = phanQuyenBUS.GetAllData();

            GCPhanQuyen.DataSource = dataTable;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}