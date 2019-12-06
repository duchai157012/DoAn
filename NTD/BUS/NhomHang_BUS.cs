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
    public class NhomHang_BUS
    {
        DAO_NhomHang nhomhang = new DAO_NhomHang();

        public DataTable GetAllData()
        {
            return nhomhang.GetAllData();
        }
        public int ThemNhomHang(NhomHang nh)
        {
            return nhomhang.ThemNhomHang(nh);
        }

        public int DeleteById(string manhomhang)
        {
            return nhomhang.DeleteById(manhomhang);
        }

        public int Update(NhomHang nh)
        {
            return nhomhang.Update(nh);
        }
    }
}
