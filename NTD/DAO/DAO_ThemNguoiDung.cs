using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_ThemNguoiDung
    {
        public db db = new db();
        public DataTable GetAllDataVT()
        {
            string sql = "Select * from RoleUser";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable GetAllDataNV()
        {
            string sql = "Select * from NhanVien";
            var rs = db.GetData(sql);

            return rs;
        }
        public int AddUser(NguoiDung nd)
        {
            string sql= string.Format("insert into [User](UserName,Password,RoleID,MaNV) Values('{0}', '{1}', '{2}', '{3}')"
                ,nd.Name,nd.Password,nd.VaiTro,nd.MaNV);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}
