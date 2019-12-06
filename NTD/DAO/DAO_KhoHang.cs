using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_KhoHang
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "select MaKho as [Mã], TenKho as [Tên],LienHe as [Liên Hệ],DienThoai as [Điện Thoại],GhiChu as[Ghi Chú],ConQuanLy as [Còn Quản Lý] from KhoHang";
            var rs = db.GetData(sql);

            return rs;
        }
        public int ThemKhoHang(KhoHang kh)
        {
            string sql = string.Format("insert into [KhoHang](MaKho,TenKho,LienHe,DienThoai,GhiChu) Values('{0}', N'{1}',N'{2}','{3}',N'{4}')"
                , kh.MaKho,kh.TenKho,kh.LienHe,kh.DienThoai,kh.GhiChu);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteById(string ma)
        {
            string sql = string.Format("Delete from KhoHang Where MaKho = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int Update(KhoHang kh)
        {
            string sql =
 string.Format("Update KhoHang Set TenKho=N'{0}',LienHe =N'{1}',DienThoai='{2}',GhiChu=N'{3}' where MaKho='{4}'",kh.TenKho,kh.LienHe,kh.DienThoai,kh.GhiChu,kh.MaKho);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}
