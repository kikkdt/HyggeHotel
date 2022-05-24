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
using DTO;
using BLL;

namespace GUI
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static tb_NhanVien _nhanVien;
        private String username;
        public static tb_NhanVien NhanVien { get => _nhanVien; set => _nhanVien = value; }

        public Main(String username)
        {
            this.username = username;
            InitializeComponent();
            _nhanVien = NhanVienBLL.GetEmployee(username);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            barBtnSoDoPhong.PerformClick();
        }

        private void BarBtnSoDoPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmSoDoPhong fmSoDoPhong = new fmSoDoPhong();
            OpenChildForm(fmSoDoPhong);
        }

        private void BarBtnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmDatPhong fmDatPhong = new fmDatPhong(new List<tb_Phong>());
            fmDatPhong.ShowDialog();
        }

        private void OpenChildForm(Form childForm)
        {
            if (MdiChildren.Length > 0)
            {
                foreach (var child in MdiChildren)
                {
                    child.Close();
                }
            }

            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }
    }
}