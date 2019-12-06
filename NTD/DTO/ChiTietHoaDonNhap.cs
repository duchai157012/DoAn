using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DTO
{
    public class ChiTietHoaDonNhap
    {
        public string MaHoaDon { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
    }
}
