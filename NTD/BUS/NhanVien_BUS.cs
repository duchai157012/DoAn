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
    public class NhanVien_BUS
    {
        DAO_NhanVien nva = new DAO_NhanVien();

        public DataTable GetAllData()
        {
            return nva.GetAllData();
        }

        public int ThemNV(NhanVien nv)
        {
            return nva.ThemNV(nv);
        }

        public int DeleteById(string manv)
        {
            return nva.DeleteById(manv);
        }

        public int Update(NhanVien nv)
        {
            return nva.Update(nv);
        }
    }
}
