using DTO;
using System;
using System.Collections.Generic;

namespace GUI
{
    public partial class fmCTPhongTrong : DevExpress.XtraEditors.XtraForm
    {
        public fmCTPhongTrong(tb_Phong phong)
        {
            InitializeComponent();
            Phong = phong;
        }

        public tb_Phong Phong { get; set; }

        private void FmCTPhongTrong_Load(object sender, EventArgs e)
        {
            Text = $"PHÒNG: {Phong.TenPhong}";
            lblLoaiPhong.Text = Phong.tb_LoaiPhong.TenLoaiPhong;
            lblNguoiLon.Text = Phong.tb_LoaiPhong.SoLuongNguoiLon.ToString();
            lblTreEm.Text = Phong.tb_LoaiPhong.SoLuongTreEm.ToString();
        }

        private void BtnNhanPhong_Click(object sender, EventArgs e)
        {
            var fmNhanPhong = new fmNhanPhong(new List<tb_Phong> { Phong });
            Close();
            fmNhanPhong.FormClosed += (o, evt) => { fmDangNhap.mainForm.barBtnSoDoPhong.PerformClick(); };
            fmNhanPhong.ShowDialog();
        }
    }
}