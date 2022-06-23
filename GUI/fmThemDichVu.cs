using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmThemDichVu : DevExpress.XtraEditors.XtraForm
    {
        private readonly List<tb_CTDatPhong> _ctDatPhongs;

        public fmThemDichVu(List<tb_CTDatPhong> ctDatPhongs)
        {
            InitializeComponent();
            _ctDatPhongs = ctDatPhongs;

            var ucSanPhamDichVu = new UcSanPhamDichVu(ctDatPhongs)
            {
                Dock = DockStyle.Fill
            };
            panelContainer.Controls.Add(ucSanPhamDichVu);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            CTDatPhong_SanPhamBLL.Update(_ctDatPhongs);
            Close();
            var maPhieuDatPhong = _ctDatPhongs[0].MaPhieuDat;
            HoaDonBLL.UpdateTotalAmount(maPhieuDatPhong);
        }

        private void fmThemDichVu_Load(object sender, EventArgs e)
        {
        }
    }
}