using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class RoleFormDAO
    {
        public db db = new db();
        

        public List<RoleForm> GetList(int roleId)
        {
            var rs = new List<RoleForm>();

            string sql = string.Format("select * from [RoleForm] where RoleId = '{0}'", roleId);

            var tb = db.GetData(sql);

            if (tb != null && tb.Rows.Count > 0)
            {
                foreach (DataRow row in tb.Rows)
                {
                    var roleForm = new RoleForm()
                    {
                        Id = int.Parse(row["Id"].ToString()),
                        RoleId = int.Parse(row["RoleId"].ToString()),
                        FormId = int.Parse(row["FormId"].ToString()),
                        Access = bool.Parse(row["Access"].ToString()),
                        Insert = bool.Parse(row["Insert"].ToString()),
                        Delete = bool.Parse(row["Delete"].ToString()),
                        Update = bool.Parse(row["Update"].ToString()),
                        Print = bool.Parse(row["Print"].ToString()),
                        Import = bool.Parse(row["Import"].ToString()),
                        Export = bool.Parse(row["Export"].ToString())
                    };
                    rs.Add(roleForm);
                }
            }
            return rs;
        }
    }
}
