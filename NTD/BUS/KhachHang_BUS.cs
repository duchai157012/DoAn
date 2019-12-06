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
    public class KhachHang_BUS
    {
        DAO_KhachHang kh = new DAO_KhachHang();

        public DataTable GetAllData()
        {
            return kh.GetAllData();
        }
        public DataTable GetAllDataKV()
        {
            return kh.GetAllDataKV();
        }
        DAO_KhachHang addkh= new DAO_KhachHang();
        public int ThemKhachHang(KhachHang kh)
        {
            return addkh.ThemKhachHang(kh);
        }

        public int DeleteById(string ma)
        {
            return addkh.DeleteById(ma);
        }

        public int Update(KhachHang kh)
        {
            return addkh.Update(kh);
        }
    }
}
