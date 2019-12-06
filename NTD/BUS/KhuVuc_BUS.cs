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
    public class KhuVuc_BUS
    {
        DAO_KhuVuc akv = new DAO_KhuVuc();

        public DataTable GetAllData()
        {
            return akv.GetAllData();
        }
        public int ThemKV(KhuVuc kv)
        {
            return akv.ThemKV(kv);
        }
        public int DeleteById(string ma)
        {
            return akv.DeleteById(ma);
        }

        public int Update(KhuVuc kh)
        {
            return akv.Update(kh);
        }
    }
}
