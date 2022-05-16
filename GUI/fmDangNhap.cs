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
        public static Main mainForm;
        public fmDangNhap()
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            mainForm = new Main();
            mainForm.Show();
            Hide();
        }

        private void FmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}