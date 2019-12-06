using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_NhaCungCap
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "select ncc.MaNCC as [Mã], ncc.Ten as [Tên],ncc.MoTa as [Mô Tả],kv.TenKhuVuc as [Tên khu vực]  from NhaCungCap ncc ,KhuVuc kv where kv.MaKhuVuc= ncc.MaKhuVuc";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable GetAllDataKV()
        {
            string sql = "Select * from KhuVuc";
            var rs = db.GetData(sql);

            return rs;
        }
        public int ThemNhaCC(NhaCC kh)
        {
            string sql = string.Format("insert into [NhaCungCap] Values('{0}', N'{1}', N'{2}', '{3}')"
                , kh.MaNCC,kh.Ten,kh.MoTa,kh.MaKV);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int DeleteById(string ma)
        {
            string sql = string.Format("Delete from NhaCungCap Where MaNCC = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int Update(NhaCC ncc)
        {
            string sql =
 string.Format("Update NhaCungCap Set Ten='{0}',MoTa='{1}',MaKhuVuc='{2}' where MaNCC='{3}'"
                                , ncc.Ten,ncc.MoTa,ncc.MaKV,ncc.MaNCC );
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}
