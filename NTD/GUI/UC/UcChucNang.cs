using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTD.DTO;

namespace NTD.GUI
{
    public partial class USChucNang : UserControl
    {
        public USChucNang()
        {
            InitializeComponent();
        }
        public void EnnableFunction(RoleForm roleForm)
        {
            btnthem.Enabled = roleForm.Insert;
            btnsua.Enabled = roleForm.Update;
            btnxoa.Enabled = roleForm.Delete;
            btnnhap.Enabled = roleForm.Import;
            btnxuat.Enabled = roleForm.Export;
        }
    }
}
