using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    class DAO_PhanQuyen
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "select f.Description as [Chức Năng], Access as [Truy Cập],[Insert] as [Thêm],[Delete] as [Xóa] ,[Update] as [Sửa],[Print] as [In],Import as [Nhập],Export as [Xuất] from RoleForm r, Form f where f.Id=r.FormId";
            var rs = db.GetData(sql);

            return rs;
        }
    }
}
