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

namespace NTD.GUI
{
    public partial class PhieuBanHang : UserControl
    {
        public PhieuBanHang()
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
        KhachHang_BUS khachHang = new KhachHang_BUS();
        decimal soluong = 0;
        decimal thanhtien = 0;
        decimal dongia = 0;
        int tongtien = 0;
        decimal ck = 0;
        decimal vat = 0;
        

        private void groupControl2_Paint(object sender, EventArgs e)
        {
            var table = khachHang.GetAllData();

            cbTenKH.Properties.DataSource = table;
            cbTenKH.Properties.DisplayMember = "Tên khách hàng";
            cbTenKH.Properties.ValueMember = "Mã KH";

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

            LookupEditMaHang.NullText = @"Chọn mã sản phẩm";
            LookUpDonVi.NullText = @"Chọn đơn vị";
            TextEditTenSP.NullText = @"(Click vào đây)";


            var dt = hdn.GetDataSource();

            gridControl1.DataSource = dt;

            loadSPTheoMaHang();
            loadDonVi();

            LookUpDonVi.BestFitMode = BestFitMode.BestFitResizePopup;
            LookupEditMaHang.BestFitMode = BestFitMode.BestFitResizePopup;

            txtVAT.EditValue = 0;
            txtCK.EditValue = 0;
        }

        private void loadSPTheoMaHang()
        {
            var dt = hh.GetDataSP();
            LookupEditMaHang.DataSource = dt;

            LookupEditMaHang.ValueMember = "MaSP";
            LookupEditMaHang.DisplayMember = "MaSP";

            colMaHang.ColumnEdit = LookupEditMaHang;
        }

        private void loadDonVi()
        {
            var dt = dv.GetData();
            LookUpDonVi.DataSource = dt;

            LookUpDonVi.ValueMember = "MaDonVi";
            LookUpDonVi.DisplayMember = "TenDonVi";

            colDonVi.ColumnEdit = LookUpDonVi;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaSP" )
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
                ck = Convert.ToDecimal(txtCK.EditValue) / 100;
                vat = Convert.ToDecimal(txtVAT.EditValue) / 100;

                soluong = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colSoLuong));
                dongia = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colDonGia));
                thanhtien = soluong * dongia;

                if(ck != 0 && vat != 0)
                    thanhtien = (thanhtien + (thanhtien *  vat)) - (thanhtien * ck);
                gridView1.SetFocusedRowCellValue(colThanhTien, thanhtien);

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    tongtien += Convert.ToInt32(gridView1.GetRowCellValue(i, "ThanhTien"));

                    txtThanhToan.EditValue = tongtien.ToString();
                }
            }

            
        }

        private void cbTenKH_EditValueChanged_1(object sender, EventArgs e)
        {
            txtMaKH.Text = cbTenKH.EditValue.ToString();
            DataTable dt = khachHang.GetAllData();
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
            else if (e.Button.Properties.Caption == "Lưu & Thêm")
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
                
            }
        }

        //private void groupControl2_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}

