using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_HangHoa
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "select sp.MaSP as [Mã Hàng],sp.TenSP as [Tên Hàng],sp.MoTa as [Mô Tả]," +
                "sp.HinhAnh as [Hình Ảnh],sp.DonVi as [Đơn Vị], sp.SoLuong as [Số Lượng],sp.GiaMua as [Giá Mua],sp.GiaBan as [Giá Bán],sp.Code" +
                ",sp.NhaCungCap as [Nhà Cung Cấp],sp.MaLoai as [Mã Loại],sp.MaKho as [Mã kho] from SanPham sp";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable GetAllDataNCC()
        {
            string sql = "Select * from NhaCungCap";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable GetAllDataKhohang()
        {
            string sql = "Select * from KhoHang";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable GetAllDataLoaiSP()
        {
            string sql = "Select * from LoaiSanPham";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable GetAllDataDonVi()
        {
            string sql = "Select * from DonVi";
            var rs = db.GetData(sql);

            return rs;
        }

        public int ThemHangHoa(HangHoa hh)
        {
            string sql = string.Format("insert into [SanPham] Values('{0}', N'{1}', N'{2}', '{3}',N'{4}',{5},{6},{7},'{8}','{9}','{10}','{11}')"
                , hh.Ma,hh.Ten,hh.MoTa,hh.HinhAnh,hh.DonVi,hh.Soluong,hh.GiaMua,hh.GiaBan,hh.Code,hh.NhaCungCap,hh.MaLoai,hh.MaKho);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteById(string masp)
        {
            string sql = string.Format("Delete from SanPham Where MaSP = '{0}'", masp);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int Update(HangHoa hh)
        {
            string sql =
 string.Format("Update SanPham Set TenSP=N'{0}',MoTa=N'{1}',HinhAnh='{2}',DonVi=N'{3}',SoLuong={4},GiaMua={5},GiaBan={6},Code='{7}',NhaCungCap='{8}',MaLoai='{9}',MaKho='{10}' where MaSP='{11}'"
                    , hh.Ten,hh.MoTa,hh.HinhAnh,hh.DonVi,hh.Soluong,hh.GiaMua,hh.GiaBan,hh.Code,hh.NhaCungCap,hh.MaLoai,hh.MaKho,hh.Ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public DataTable GetDataSPTheoNCC(string nhaCungCap)
        {
            string sql = "select p.MaSP, p.TenSP, p.SoLuong, p.MaKho, p.GiaMua, p.GiaBanLe, p.GiaBanSi from SanPham p where p.NhaCungCap = '" + nhaCungCap + "' ";
            var rs = db.GetData(sql);

            return rs;
        }

        public DataTable GetSPTheoMaHang(string mahang)
        {
            string sql = "select * from SanPham p where p.MaSP= '" + mahang + "' ";
            var rs = db.GetData(sql);

            return rs;
        }

        public DataTable GetDataSP()
        {
            string sql = "select p.MaSP, p.TenSP, p.SoLuong, p.MaKho, p.GiaMua, p.GiaBanLe, p.GiaBanSi from SanPham p";
            var rs = db.GetData(sql);

            return rs;
        }
    }
}
