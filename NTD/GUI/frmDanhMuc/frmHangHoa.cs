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
                Ma = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Mã Hàng").ToString(),
                Ten = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Tên Hàng").ToString(),
                MoTa = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Mô Tả").ToString(),
                HinhAnh = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Hình Ảnh").ToString(),
                DonVi = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Đơn Vị").ToString(),
                Soluong = int.Parse( gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Số Lượng").ToString()),
                GiaMua = float.Parse( gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Giá Mua").ToString()),
                GiaBan = float.Parse(gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Giá Bán").ToString()),
                Code = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Code").ToString(),
                NhaCungCap = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Nhà Cung Cấp").ToString(),
                MaLoai= gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Mã Loại").ToString(),
                MaKho = gc_rootHangHoa.GetRowCellValue(gc_rootHangHoa.FocusedRowHandle, "Mã kho").ToString()
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
    }
}