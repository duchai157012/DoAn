using NTD.DAO;
using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class RoleForm_BUS
    {
        RoleFormDAO roleFormDAO = new RoleFormDAO();
        public List<RoleForm> GetList(int roleId)
        {
            return roleFormDAO.GetList(roleId);
        }
    }
}
