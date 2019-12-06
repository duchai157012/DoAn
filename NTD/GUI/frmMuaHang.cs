using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using NTD.BUS;
using NTD.DAO;
using NTD.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace NTD.GUI
{
    public partial class frmMuaHang : DevExpress.XtraEditors.XtraForm
    {
        public frmMuaHang()
        {
            InitializeComponent();
        }

        NhaCC_BUS ncc = new NhaCC_BUS();
        ThemNguoiDung_BUS tnd = new ThemNguoiDung_BUS();
        KhoHang_BUS khohang = new KhoHang_BUS();
        db db = new db();
        HangHoa_BUS hh = new HangHoa_BUS();
        ChiTietHoaDonNhap_BUS hdn = new ChiTietHoaDonNhap_BUS();
        DonVi_BUS dv = new DonVi_BUS();
        decimal soluong = 0;
        decimal thanhtien = 0;
        decimal dongia = 0;

        private void frmMuaHang_Load(object sender, EventArgs e)
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
      
            DateTime today =  DateTime.UtcNow.Date;
            cbNgay.DateTime = today;

            var dataTable2 = khohang.GetData();
            cbKhoHang.Properties.DataSource = dataTable2;
            cbKhoHang.Properties.DisplayMember = "TenKho";
            cbKhoHang.Properties.ValueMember = "MaKho";
            cbKhoHang.EditValue = dataTable2.Rows[0][0];

            int sl = db.GetSoLuong("HoaDonNhap") + 1;
           
            string mhd;
            if(sl < 10)
            {
                 mhd = "HD00" + sl;
            }
            else
            {
                 mhd = "HD0" + sl;
            }
            txtMaPhieu.Text = mhd;

            GridLookUpMaHang.NullText = @"Chọn mã sản phẩm";
            GridLookUpDonVi.NullText = @"Chọn đơn vị";
            TextEditTenSP.NullText = @"(Click vào đây)";
            

            var dt = hdn.GetDataSource();

            gridControl1.DataSource = dt;



        }

        string maNCC;
        private void cbTenNCC_EditValueChanged(object sender, EventArgs e)
        {
            txtMaNCC.Text = cbTenNCC.EditValue.ToString();
            maNCC = cbTenNCC.EditValue.ToString();

            loadSPTheoMaHang();
            loadDonVi();
        }

        private void loadSPTheoMaHang()
        {          
            var dt = hh.GetDataSPTheoNCC(maNCC);
            GridLookUpMaHang.DataSource = dt;

            GridLookUpMaHang.ValueMember = "MaSP";
            GridLookUpMaHang.DisplayMember = "MaSP";

            colMaSP.ColumnEdit = GridLookUpMaHang;
            
            GridLookUpMaHang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            gridView1.BestFitColumns();
        }

        private void loadDonVi()
        {
            var dt = dv.GetData();
            GridLookUpDonVi.DataSource = dt;

            GridLookUpDonVi.ValueMember = "MaDonVi";
            GridLookUpDonVi.DisplayMember = "TenDonVi";

            colDonVi.ColumnEdit = GridLookUpDonVi;

            GridLookUpDonVi.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "MaSP")
            {
                var value = gridView1.GetRowCellValue(e.RowHandle, e.Column);
                var dt = hh.GetSPTheoMaHang((string)value);
                if(dt != null)
                {
                    string tenSP = (string)dt.Rows[0]["TenSP"];
                    gridView1.SetRowCellValue(e.RowHandle, "TenSP", tenSP);
                    gridView1.SetRowCellValue(e.RowHandle, "DonVi", dt.Rows[0]["DonVi"]);
                    gridView1.SetRowCellValue(e.RowHandle, "DonGia", dt.Rows[0]["GiaMua"]);
                    
                }
            }

            if(e.Column.FieldName == "SoLuong")
            {
                soluong = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colSoLuong));
                dongia = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colDonGia));
                thanhtien = soluong * dongia;
                gridView1.SetFocusedRowCellValue(colThanhTien, thanhtien);
            }

        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Tạo Mới")
            {
                gridView1.OptionsSelection.MultiSelect = true;

                gridView1.SelectAll();
                gridView1.DeleteSelectedRows();

                txtDiaChi.Text = "";
                txtGhiChu.Text = "";

                MessageBox.Show("Tạo Thành Công Đơn Nhập Hàng");
            }
            else if(e.Button.Properties.Caption == "Lưu & Thêm")
            {
                gridView1.OptionsSelection.MultiSelect = true;

                gridView1.SelectAll();
                gridView1.DeleteSelectedRows();

                txtDiaChi.Text = "";
                txtGhiChu.Text = "";

                MessageBox.Show("Lưu Thành Công Đơn Nhập Hàng");
            }
            else if (e.Button.Properties.Caption == "Nạp Lại")
            {
                MessageBox.Show("Lưu Thành Công Đơn Nhập Hàng");
            }
            else if (e.Button.Properties.Caption == "In")
            {
                MessageBox.Show("Lưu Thành Công Đơn Nhập Hàng");
            }
            else if (e.Button.Properties.Caption == "Đóng")
            {
                this.Close();
            }
        }
    }
}