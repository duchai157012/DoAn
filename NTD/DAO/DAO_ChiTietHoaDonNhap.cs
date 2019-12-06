using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_ChiTietHoaDonNhap
    {
        public db db = new db();

        public DataTable GetDataSource()
        {
            string sql = "select hdn.MaSP, hdn.TenSP, hdn.DonVi, hdn.SoLuong, hdn.DonGia, hdn.ThanhTien, hdn.GhiChu from ChiTietHoaDonNhap hdn where hdn.MaHD = 0";
            var rs = db.GetData(sql);

            return rs;
        }
    }
}
