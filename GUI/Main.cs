using BLL;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : RibbonForm
    {
        private string username;

        public Main(string username)
        {
            this.username = username;
            InitializeComponent();
            NhanVien = NhanVienBLL.GetEmployee(username);
        }

        public static tb_NhanVien NhanVien { get; set; }

        private void Main_Load(object sender, EventArgs e)
        {
            barBtnSoDoPhong.PerformClick();
        }

        private void BarBtnSoDoPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var fmSoDoPhong = new fmSoDoPhong();
            OpenChildForm(fmSoDoPhong);
        }

        private void BarBtnDatPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var fmDatPhong = new fmDatPhong(new List<tb_Phong>());
            fmDatPhong.ShowDialog();
        }

        private void OpenChildForm(Form childForm)
        {
            if (MdiChildren.Length > 0)
                foreach (var child in MdiChildren)
                    child.Close();

            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }
    }
}