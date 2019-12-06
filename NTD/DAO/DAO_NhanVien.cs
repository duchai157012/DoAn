using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_NhanVien
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "select nv.MaNV as [Mã],nv.HoTen as [Họ Tên],nv.DiaChi as [Địa Chỉ],nv.DienThoai as [Điện Thoại] from NhanVien nv";
            var rs = db.GetData(sql);

            return rs;
        }
        public int ThemNV(NhanVien nv)
        {
            string sql = string.Format("insert into [NhanVien](MaNV,HoTen,DiaChi,DienThoai) Values('{0}', N'{1}', N'{2}', '{3}')"
                , nv.MaNV, nv.HoTen, nv.DiaChi, nv.DienThoai);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteById(string manv)
        {
            string sql = string.Format("Delete from NhanVien Where MaNV = '{0}'", manv);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int Update(NhanVien nv)
        {
            string sql =
 string.Format("Update NhanVien Set HoTen='{0}',DiaChi='{1}',DienThoai='{2}' where MaNV='{3}'", nv.HoTen,nv.DiaChi,nv.DienThoai,nv.MaNV);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}
