using NTD.DAO;
using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class DonVi_BUS
    {
        DAO_DonVi dv = new DAO_DonVi();

        public DataTable GetAllData()
        {
            return dv.GetAllData();
        }
        public int ThemDV(DonVi dv1)
        {
            return dv.ThemDV(dv1);
        }
        public int DeleteById(string ma)
        {
            return dv.DeleteById(ma);
        }

        public int Update(DonVi dv1)
        {
            return dv.Update(dv1);
        }

        public DataTable GetData()
        {
            return dv.GetData();
        }
    }
}
