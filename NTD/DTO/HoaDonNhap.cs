using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DTO
{
    public class HoaDonNhap
    {
        public string MaHoaDon { get; set; }
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayMua { get; set; }
        public float TongTien { get; set; }
        public float DaTra { get; set; }
        public float ConLai { get; set; }
    }
}
