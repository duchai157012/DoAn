using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NTD.BUS;

namespace NTD.GUI
{
    public partial class frmDoiMK : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        User_BUS us = new User_BUS();
        string userName;
        string passwordCu;
        string passwordMoi;
        string passwordNhapLai;

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            userName = GlobalVar.userName;
            passwordCu = txtMKCu.Text;
            passwordMoi = textBox1.Text;
            passwordNhapLai = textBox2.Text;            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (passwordMoi != passwordNhapLai)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác!!!");
            }
            else if (us.KiemTraMatKhauCu(passwordCu) == 0)
            {
                MessageBox.Show("Nhập sai mật khẩu cũ, xin kiểm tra lại!!!");
            }
            else
            {
                int rs = us.DoiMatKhau(passwordMoi, userName);
                if(rs > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!!!");
                    this.Close();
                }
            }
        }
    }
}