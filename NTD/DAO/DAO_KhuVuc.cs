using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_KhuVuc
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "select MaKhuVuc as [Mã], TenKhuVuc as [Tên] from KhuVuc";
            var rs = db.GetData(sql);

            return rs;
        }
        public int ThemKV(KhuVuc kv)
        {
            string sql = string.Format("insert into [KhuVuc](MaKhuVuc,TenKhuVuc) Values('{0}', '{1}')"
                , kv.MaKV,kv.TenKV);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteById(string ma)
        {
            string sql = string.Format("Delete from KhuVuc Where MaKhuVuc = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int Update(KhuVuc kh)
        {
            string sql =
 string.Format("Update KhuVuc Set TenKhuVuc=N'{0}' where MaKhuVuc='{1}'", kh.TenKV,kh.MaKV);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}
