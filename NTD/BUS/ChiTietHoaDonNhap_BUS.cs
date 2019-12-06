using NTD.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class ChiTietHoaDonNhap_BUS
    {
        DAO_ChiTietHoaDonNhap hdn = new DAO_ChiTietHoaDonNhap();
        public DataTable GetDataSource()
        {
            return hdn.GetDataSource();
        }
    }
}
