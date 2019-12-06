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
    public class HangHoa_BUS
    {
        DAO_HangHoa hanghoa = new DAO_HangHoa();

        public DataTable GetAllData()
        {
            return hanghoa.GetAllData();
        }
        public DataTable GetAllDataNCC()
        {
            return hanghoa.GetAllDataNCC();
        }
        public DataTable GetAllDataKhoHang()
        {
            return hanghoa.GetAllDataKhohang();
        }
        public DataTable GetAllDataLoaiSP()
        {
            return hanghoa.GetAllDataLoaiSP();
        }
        public DataTable GetAllDataDonVi()
        {
            return hanghoa.GetAllDataDonVi();
        }
        public int ThemHangHoa(HangHoa hh)
        {
            return hanghoa.ThemHangHoa(hh);
        }

        public int DeleteById(string ma)
        {
            return hanghoa.DeleteById(ma);
        }

        public int Update(HangHoa hh)
        {
            return hanghoa.Update(hh);
        }

        public DataTable GetDataSPTheoNCC(string nhaCungCap)
        {
            return hanghoa.GetDataSPTheoNCC(nhaCungCap);
        }

        public DataTable GetSPTheoMaHang(string mahang)
        {
            return hanghoa.GetSPTheoMaHang(mahang);
        }

        public DataTable GetDataSP()
        {
            return hanghoa.GetDataSP();
        }
    }

}
