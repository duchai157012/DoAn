using NTD.DAO;
using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTD.BUS
{
    public class User_BUS
    {
        UserDAO userDAO = new UserDAO();
        public UserInfo Login(string userName, string passWord)
        {
            if (userName.Length < 2 || passWord.Length < 2)
            {
                //MessageBox.Show("UserName hoặc mật khẩu quá ngắn.");
                return null;
            }
            return userDAO.Login(userName, passWord);
        }

        public int DoiMatKhau(string matkhau, string username)
        {
            return userDAO.DoiMatKhau(matkhau, username);
        }

        public int KiemTraMatKhauCu(string matkhau)
        {
            return userDAO.KiemTraMatKhauCu(matkhau);
        }
    }
}
