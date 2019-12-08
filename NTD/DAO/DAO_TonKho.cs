using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_TonKho
    {
        public db db = new db();
        public DataTable GetAllDataKH()
        {
            string sql = "Select TenKho as [Kho Hàng],MaKho as [Mã Kho] from KhoHang";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable GetDataMa(string ma)
        {
            // string sql = string.Format("select MaSP as [Mã hàng],TenSP as [Tên hàng],DonVi as[Đơn vị],SoLuong as[Số lượng],lsp.TenLoaiHang as [Nhóm hàng] from SanPham ,LoaiSanPham lsp where MaLoai=lsp.MaLoaiHang and MaKho ='{0}' ", ma);

            string sql = string.Format("select MaSP ,TenSP ,DonVi ,SoLuong ,lsp.TenLoaiHang, kh.TenKho from SanPham sp ,LoaiSanPham lsp,KhoHang kh where MaLoai=lsp.MaLoaiHang and kh.MaKho=sp.MaKho and sp.MaKho ='{0}' ", ma);
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable GetAllData()
        {

            string sql = string.Format("select MaSP ,TenSP ,DonVi ,SoLuong ,lsp.TenLoaiHang, kh.TenKho from SanPham sp ,LoaiSanPham lsp,KhoHang kh where MaLoai=lsp.MaLoaiHang and kh.MaKho=sp.MaKho");
            var rs = db.GetData(sql);

            return rs;
        }
    }
}
