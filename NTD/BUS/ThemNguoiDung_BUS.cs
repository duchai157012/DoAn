using NTD.DAO;
using NTD.DTO;
//using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class ThemNguoiDung_BUS
    {
        DAO_ThemNguoiDung tnd = new DAO_ThemNguoiDung();
        public DataTable GetAllDataVT()
        {
            return tnd.GetAllDataVT();
        }

        public DataTable GetAllDataNV()
        {
            return tnd.GetAllDataNV();
        }
        DAO_ThemNguoiDung addND = new DAO_ThemNguoiDung();
        public int AddUser(NguoiDung nd)
        {
            return addND.AddUser(nd);
        }



        //public int NhapNDForm(string Name, string Pass, int vaiTro, string MaNV)
        //{

        //}
    }
}
