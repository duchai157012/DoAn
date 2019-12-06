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
    public partial class frmTonKho : DevExpress.XtraEditors.XtraForm
    {
        public frmTonKho()
        {
            InitializeComponent();
        }
        TonKho_BUS bus_tk = new TonKho_BUS();

        private void LoadData(string ma)
        { 

            var dataTable = bus_tk.GetAllData(ma);

            gcTonKho.DataSource = dataTable;
        }
        private void frmTonKho_Load(object sender, EventArgs e)
        {
            var dataTable = bus_tk.GetAllDataKH();

            cbKhoHang.Properties.DataSource = dataTable;
            cbKhoHang.Properties.DisplayMember = "Kho Hàng";
            cbKhoHang.Properties.ValueMember = "Mã Kho";


        }

        private void cbKhoHang_EditValueChanged(object sender, EventArgs e)
        {
            string ma = cbKhoHang.EditValue.ToString();
            LoadData(ma);
        }
    }
}