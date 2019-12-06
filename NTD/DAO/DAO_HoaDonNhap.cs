using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_HoaDonNhap
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "select ncc.MaNCC as [Mã], ncc.Ten as [Tên],ncc.MoTa as [Mô Tả],kv.TenKhuVuc as [Tên khu vực]  from NhaCungCap ncc ,KhuVuc kv where kv.MaKhuVuc= ncc.MaKhuVuc";
            var rs = db.GetData(sql);

            return rs;
        }

    }
}
