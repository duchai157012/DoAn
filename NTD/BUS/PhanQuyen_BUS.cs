using NTD.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class PhanQuyen_BUS
    {
        DAO_PhanQuyen phanQuyen = new DAO_PhanQuyen();

        public DataTable GetAllData()
        {
            return phanQuyen.GetAllData();
        }
    }
}
