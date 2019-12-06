using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_NhomHang
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "select MaLoaiHang as [Mã] ,TenLoaiHang as [Tên] from LoaiSanPham";
            var rs = db.GetData(sql);

            return rs;
        }
        public int DeleteById(string maloaihang)
        {
            string sql = string.Format("Delete from LoaiSanPham Where MaLoaiHang = '{0}'", maloaihang);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int Update(NhomHang nh)
        {
            string sql =
 string.Format("Update LoaiSanPham Set TenLoaiHang='{0}' where MaLoaiHang='{1}'",nh.Ten,nh.Ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int ThemNhomHang(NhomHang nh)
        {
            string sql = string.Format("insert into [LoaiSanPham] Values('{0}', N'{1}')"
                , nh.Ma,nh.Ten);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}
