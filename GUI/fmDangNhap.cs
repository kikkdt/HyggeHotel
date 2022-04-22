using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public fmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        { 
            new Main().Show();
            this.Visible = false;
        }

        private void fmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}