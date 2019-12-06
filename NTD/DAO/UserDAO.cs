using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        { get { if (instance == null) instance = new UserDAO(); return instance; }
           private set => instance = value;
        }

        public db db = new db();

        public UserInfo Login(string userName, string password)
        {
            string sql = string.Format("select Id, RoleId, UserName from [User] where UserName = '{0}' and Password = '{1}'", userName, password);

            var tb = db.GetData(sql);

            if (tb != null && tb.Rows.Count>0)
            {
                return new UserInfo
                {
                    Id = int.Parse(tb.Rows[0]["Id"].ToString()),
                    RoleId = int.Parse(tb.Rows[0]["RoleId"].ToString()),
                    userName = tb.Rows[0]["UserName"].ToString()
                };
            }
            
            return null;
        }

        public int DoiMatKhau(string matkhau, string username)
        {
            string sql = "update [User] set Password = '"+ matkhau + "' where UserName = '"+ username +"'";
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int KiemTraMatKhauCu(string matkhau)
        {
            string sql = "select * from [User] where Password = '" + matkhau + "'";
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}
