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

namespace NTD.GUI
{
    public partial class frmTyGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTyGia()
        {
            InitializeComponent();
        }

        private void usChucNang1_Load(object sender, EventArgs e)
        {

        }

        private void frmTyGia_Load(object sender, EventArgs e)
        {
            int tag = int.Parse(this.Tag.ToString());
            var roleform = GlobalVar.dictRoleForm[tag];
            usChucNang1.EnnableFunction(roleform);
        }
    }
}