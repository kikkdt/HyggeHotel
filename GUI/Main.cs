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
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        fmSoDoPhong fmSDP = new fmSoDoPhong();
        frmHome fmHome = new frmHome();
        fmDatPhong fmDatPhong = new fmDatPhong();
        fmNhanPhong fmNhanPhong = new fmNhanPhong();
        fmDangNhap fmDangNhap = new fmDangNhap();
        fmDsDatPhong fmDsDatPhong = new fmDsDatPhong();
        fmDsNhanPhong fmDsNhanPhong = new fmDsNhanPhong();
        fmThanhToan fmThanhToan = new fmThanhToan();
        public Main()
        {
            InitializeComponent();
            OpenChildFrom(fmHome);

        }


        private void btnSoDoPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildFrom(fmSDP);
        }



        public void OpenChildFrom(Form childForm, object btnSender = null)
        {
            this.pnContent.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnContent.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => openHome(sender,e);

        private void btnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => openDatPhong(sender, e);

        private void S_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => openSoDoPhong(sender, e);

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => openDsDatPhong(sender, e);

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => openNhanPhong(sender, e);

        private void btnDangnhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => fmDangNhap.Show();

        private void btnDsNhanP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => openDsNhanPhong(sender, e);

        private void btnThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => openThanhToan(sender, e);

        private void Main_Load(object sender, EventArgs e)
        {
            fmHome.btnSoDoPhong.Click += openSoDoPhong;
            fmHome.btnDatPhong.Click += openDatPhong;
            fmHome.btnNhanPhong.Click += openNhanPhong;
            fmHome.btnDsDatPhong.Click += openDsDatPhong;
            fmHome.btnDsNhanPhong.Click += openDsNhanPhong;
            fmHome.btnThanhToan.Click += openThanhToan;
      
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmDoiMatKhau f = new fmDoiMatKhau();
            f.ShowDialog();
        }


        private void openThanhToan(object sender, EventArgs e)
        {
            OpenChildFrom(fmThanhToan);
        }

        private void openSoDoPhong(object sender, EventArgs e)
        {
            OpenChildFrom(fmSDP);
        }
        private void openHome(object sender, EventArgs e)
        {
            OpenChildFrom(fmHome);
        }
        private void openDatPhong(object sender, EventArgs e)
        {
            OpenChildFrom(fmDatPhong);
        }
        private void openNhanPhong(object sender, EventArgs e)
        {
            OpenChildFrom(fmNhanPhong); 
        }
        private void openDsDatPhong(object sender, EventArgs e)
        {
            OpenChildFrom(fmDsDatPhong); 
        }
        private void openDsNhanPhong(object sender, EventArgs e)
        {
            OpenChildFrom(fmDsNhanPhong);
        }
    }
}