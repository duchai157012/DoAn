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
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmHangHoa()
        {
            InitializeComponent();          
        }
        HangHoa_BUS hh = new HangHoa_BUS();
        private void LoadData()
        {
            var dataTable = hh.GetAllData();
            gcHangHoa.DataSource = dataTable;
        }
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.dictRoleForm[tag];
            usChucNang1.EnnableFunction(roleform);

            usChucNang1.Controls["btnthem"].Click += ThemHH;
            usChucNang1.Controls["btnxoa"].Click += XoaHH;
            usChucNang1.Controls["btnsua"].Click += SuaHH;
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
            gcHangHoa.Refresh();
        }

        private void xuat(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();

            SaveFileDialog.ShowDialog();

            gcHangHoa.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void SuaHH(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa()
            {
                Ma = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "MaSP").ToString(),
                Ten = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "TenSP").ToString(),
                MoTa = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "MoTa").ToString(),
                HinhAnh = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "HinhAnh").ToString(),
                DonVi = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "DonVi").ToString(),
                Soluong = int.Parse(gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "SoLuong").ToString()),
                GiaMua = float.Parse(gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "GiaMua").ToString()),
                GiaBanLe = float.Parse(gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "GiaBanLe").ToString()),
                GiaBanSi = float.Parse(gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "GiaBanSi").ToString()),
                Code = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Code").ToString(),
                NhaCungCap = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "NhaCungCap").ToString(),
                MaLoai = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "MaLoai").ToString(),
                MaKho = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "MaKho").ToString()
            };

            frmThemHangHoa thh = new frmThemHangHoa(hh);
            thh.ShowDialog();
            LoadData();
        }

        private void XoaHH(object sender, EventArgs e)
        {
            string ma = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Mã Hàng").ToString();

            if (gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Mã Hàng").ToString() != null)
            {
                var rs = hh.DeleteById(ma);

                if (rs > 0)
                {
                    LoadData();
                    MessageBox.Show("Delete Successfully!!!!!!!!");
                }
            }
        }

        private void ThemHH(object sender, EventArgs e)
        {
            frmThemHangHoa thh = new frmThemHangHoa();
            thh.ShowDialog();
            LoadData();
        }

        private void comboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}