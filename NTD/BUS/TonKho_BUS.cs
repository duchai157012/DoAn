using NTD.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class TonKho_BUS
    {
        DAO_TonKho tk = new DAO_TonKho();
        public DataTable GetDataMa(string ma)
        {
            return tk.GetDataMa(ma);
        }
        public DataTable GetAllData()
        {
            return tk.GetAllData();
        }
        public DataTable GetAllDataKH()
        {
            return tk.GetAllDataKH();
        }
    }
}
