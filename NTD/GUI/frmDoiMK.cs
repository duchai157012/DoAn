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
    }
}