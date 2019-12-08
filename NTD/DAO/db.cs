using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class db
    {
        public  string connStr = @"Data Source=DESKTOP-UER81O0;Initial Catalog=QUANLIBANHANG;Integrated Security=True";

        public DataTable GetData(string sql)
        {
            //Tao ket noi
            SqlConnection sqlConnection = new SqlConnection(connStr);

            //Bo chuyen doi du lieu
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            //Bang chua du lieu
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

        public int ExecuteSQL(string sql)
        {
            //Tao ket noi
            SqlConnection sqlConnection = new SqlConnection(connStr);

            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            int rs = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return rs;
        }

        public int ExecuteStore(string sql, SqlParameter[] param)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);

            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            //Them tham so
            sqlCommand.Parameters.AddRange(param);

            sqlConnection.Open();

            //Trar ve so dong bi anh huong
            var affectedRows = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return affectedRows;
        }

        public int Login(NguoiDung user)
        {
            string sql = string.Format("select count(*) from [User] where UserName = '{0}' and Password = '{1}'", user.Name, user.Password);

            SqlConnection sqlConnection = new SqlConnection(connStr);

            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            int rs = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();

            if(rs == 1)
            {
                return 1;
            }

            return 0;
        }

        public int GetRoleId(NguoiDung user)
        {
            string sql = string.Format("select RoleID from [User] where UserName = '{0}'", user.Name);

            SqlConnection sqlConnection = new SqlConnection(connStr);

            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            int rs = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();

            return rs;
        }
        public int GetSoLuong(string tableName)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);

            string sql = string.Format("select count(*) from [{0}]", tableName);

            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            int rs = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();

            return rs;
        }
    }
}
