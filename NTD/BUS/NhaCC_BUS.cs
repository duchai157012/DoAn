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
    public class NhaCC_BUS
    {
        DAO_NhaCungCap ncc = new DAO_NhaCungCap();

        public DataTable GetAllData()
        {
            return ncc.GetAllData();
        }
        public DataTable GetAllDataKV()
        {
            return ncc.GetAllDataKV();
        }

        public int ThemNhaCC(NhaCC cc)
        {
            return ncc.ThemNhaCC(cc);
        }

        public int DeleteById(string ma)
        {
            return ncc.DeleteById(ma);
        }
        public int Update(NhaCC nh)
        {
            return ncc.Update(nh);
        }
    }
}
