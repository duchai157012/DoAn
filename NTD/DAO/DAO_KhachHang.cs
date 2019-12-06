using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_KhachHang
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "select MaKH as [Mã KH], Name as [Tên khách hàng],Address as [Địa chỉ],Number as [Số điện thoại],MaKhuVuc as [Khu vực] from KhachHang";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable GetAllDataKV()
        {
            string sql = "Select * from KhuVuc";
            var rs = db.GetData(sql);

            return rs;
        }
        public int ThemKhachHang(KhachHang kh)
        {
            string sql = string.Format("insert into [KhachHang](MaKH,Name,Address,Number,MaKhuVuc) Values('{0}', N'{1}',N'{2}','{3}','{4}')"
                , kh.MaKH,kh.Ten,kh.DiaChi,kh.SDT,kh.MaKV);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteById(string ma)
        {
            string sql = string.Format("Delete from KhachHang Where Makh = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int Update(KhachHang kh)
        {
            string sql =
 string.Format("Update KhachHang Set Name=N'{0}',Address='{1}',Number='{2}',MaKhuVuc='{3}' where MaKH='{4}'", kh.Ten,kh.DiaChi,kh.SDT,kh.MaKV,kh.MaKH);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}
