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
    public class KhoHang_BUS
    {
        DAO_KhoHang kh = new DAO_KhoHang();

        public DataTable GetAllData()
        {
            return kh.GetAllData();
        }

        public int ThemKhoHang(KhoHang kh1)
        {
            return kh.ThemKhoHang(kh1);
        }

        public int DeleteById(string ma)
        {
            return kh.DeleteById(ma);
        }

        public int Update(KhoHang kh1)
        {
            return kh.Update(kh1);
        }
    }
}
