using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DTO
{
    public class HoaDonBan
    {
        public string MaHoaDon { get; set; }
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayBan { get; set; }
        public float TongTien { get; set; }
        public float DaTra { get; set; }
        public float ConLai { get; set; }
    }
}
