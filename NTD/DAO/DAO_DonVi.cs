using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_DonVi
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "select MaDonVi as [Mã], TenDonVi as [Tên],GhiChu as [Ghi Chú],ConQuanLy as [Còn Quản Lý] from DonVi";
            var rs = db.GetData(sql);

            return rs;
        }
        public int ThemDV(DonVi dv)
        {
            string sql = string.Format("insert into [DonVi](MaDonVi,TenDonVi,GhiChu) Values('{0}', N'{1}',N'{1}')",dv.Ma,dv.Ten,dv.GhiChu);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteById(string ma)
        {
            string sql = string.Format("Delete from DonVi Where MaDonVi = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int Update(DonVi dv)
        {
            string sql =
 string.Format("Update DonVi Set TenDonVi =N'{0}',GhiChu=N'{1}' where MaDonVi='{2}'",dv.Ten, dv.GhiChu,dv.Ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public DataTable GetData()
        {
            string sql = "select MaDonVi , TenDonVi  from DonVi";
            var rs = db.GetData(sql);

            return rs;
        }
    }
}
