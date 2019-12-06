using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTD.BUS;
using NTD.DAO;
using DevExpress.XtraEditors.Controls;


namespace NTD.GUI.UC
{
    public partial class PhieuNhapHang : UserControl
    {
        public PhieuNhapHang()
        {
            InitializeComponent();
        }

        public virtual Size PopupFormMinSize { get; set; }

        NhaCC_BUS ncc = new NhaCC_BUS();
        ThemNguoiDung_BUS tnd = new ThemNguoiDung_BUS();
        KhoHang_BUS khohang = new KhoHang_BUS();
        db db = new db();
        HangHoa_BUS hh = new HangHoa_BUS();
        ChiTietHoaDonNhap_BUS hdn = new ChiTietHoaDonNhap_BUS();
        DonVi_BUS dv = new DonVi_BUS();
        KhachHang_BUS khachHang = new KhachHang_BUS();
        decimal soluong = 0;
        decimal thanhtien = 0;
        decimal dongia = 0;
        int tongtien = 0;
        decimal ck = 0;
        decimal vat = 0;

        private void groupControl2_Paint(object sender, EventArgs e)
        {
            var table = ncc.GetAllData();

            cbTenNCC.Properties.DataSource = table;
            cbTenNCC.Properties.DisplayMember = "Tên";
            cbTenNCC.Properties.ValueMember = "Mã";

            var dataTable1 = tnd.GetAllDataNV();
            cbNhanVien.Properties.DataSource = dataTable1;
            cbNhanVien.Properties.DisplayMember = "HoTen";
            cbNhanVien.Properties.ValueMember = "MaNV";

            cbNhanVien.EditValue = dataTable1.Rows[0][0];

            DateTime today = DateTime.UtcNow.Date;
            cbNgay.DateTime = today;

            var dataTable2 = khohang.GetAllData();
            cbKhoHang.Properties.DataSource = dataTable2;
            cbKhoHang.Properties.DisplayMember = "Tên";
            cbKhoHang.Properties.ValueMember = "Mã";

            cbKhoHang.EditValue = dataTable2.Rows[0][0];

            int sl = db.GetSoLuong("HoaDonNhap") + 1;

            string mhd;
            if (sl < 10)
            {
                mhd = "HD00" + sl;
            }
            else
            {
                mhd = "HD0" + sl;
            }
            txtMaPhieu.Text = mhd;

            LookUpMaHang.NullText = @"Chọn mã sản phẩm";
            LookUpEditDonVi.NullText = @"Chọn đơn vị";
            TextEditTenHang.NullText = @"(Click vào đây)";


            var dt = hdn.GetDataSource();

            gridControl1.DataSource = dt;

            LookUpMaHang.BestFitMode = BestFitMode.BestFitResizePopup;
            LookUpEditDonVi.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        string maNCC;
        private void cbTenNCC_EditValueChanged_1(object sender, EventArgs e)
        {
            txtMaNCC.Text = cbTenNCC.EditValue.ToString();
            maNCC = cbTenNCC.EditValue.ToString();

            loadSPTheoMaHang();
            loadDonVi();
        }

        private void loadSPTheoMaHang()
        {
            var dt = hh.GetDataSPTheoNCC(maNCC);
            LookUpMaHang.DataSource = dt;

            LookUpMaHang.ValueMember = "MaSP";
            LookUpMaHang.DisplayMember = "MaSP";

            colMaHang.ColumnEdit = LookUpMaHang;

            
        }

        private void loadDonVi()
        {
            var dt = dv.GetData();
            LookUpEditDonVi.DataSource = dt;

            LookUpEditDonVi.ValueMember = "MaDonVi";
            LookUpEditDonVi.DisplayMember = "TenDonVi";

            colDonVi.ColumnEdit = LookUpEditDonVi;
        }

        private void gridView1_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaSP")
            {
                var value = gridView1.GetRowCellValue(e.RowHandle, e.Column);
                var dt = hh.GetSPTheoMaHang((string)value);
                if (dt != null)
                {
                    string tenSP = (string)dt.Rows[0]["TenSP"];
                    gridView1.SetRowCellValue(e.RowHandle, "TenSP", tenSP);
                    gridView1.SetRowCellValue(e.RowHandle, "DonVi", dt.Rows[0]["DonVi"]);
                    gridView1.SetRowCellValue(e.RowHandle, "DonGia", dt.Rows[0]["GiaMua"]);

                }
            }

            if (e.Column.FieldName == "SoLuong")
            {
                //thanhtien = 0;
                //gridView1.SetFocusedRowCellValue(colThanhTien, thanhtien);
                ck = Convert.ToDecimal(txtCK.EditValue) / 100;
                vat = Convert.ToDecimal(txtVAT.EditValue) / 100;

                soluong = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colSoLuong));
                dongia = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colDonGia));
                thanhtien = soluong * dongia;
                gridView1.SetFocusedRowCellValue(colThanhTien, thanhtien);

                if (ck != 0 && vat != 0)
                    thanhtien = (thanhtien + (thanhtien * vat)) - (thanhtien * ck);
                gridView1.SetFocusedRowCellValue(colThanhTien, thanhtien);

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    tongtien += Convert.ToInt32(gridView1.GetRowCellValue(i, "ThanhTien"));

                    txtThanhToan.EditValue = tongtien.ToString();
                }
            }

        }

        private void cbTenKH_EditValueChanged(object sender, EventArgs e)
        {
            txtMaNCC.Text = cbTenNCC.EditValue.ToString();
            DataTable dt = khachHang.GetAllData();
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {

        }

    }
}
