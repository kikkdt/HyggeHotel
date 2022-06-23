using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GUI
{
    public partial class fmCTPhongCoKhach : DevExpress.XtraEditors.XtraForm
    {
        private tb_CTDatPhong _ctDatPhong;
        private tb_HoaDon _hoaDon;
        private tb_PhieuDatPhong _phieuDatPhong;
        private readonly tb_Phong _phong;

        public fmCTPhongCoKhach(tb_Phong phong)
        {
            InitializeComponent();
            _phong = phong;

            GetData();
        }

        private void GetData()
        {
            // Get unpaid invoices
            var hoaDons = HoaDonBLL.GetUnpaidInvoices();
            // Get reserved tickets of unpaid invoices
            var phieuDatPhongs = hoaDons.Select(hd => hd.tb_PhieuDatPhong).ToList();

            foreach (var phieu in phieuDatPhongs)
                foreach (var ctDatPhong in phieu.tb_CTDatPhongs)
                    if (ctDatPhong.MaPhong.Equals(_phong.MaPhong))
                    {
                        _phieuDatPhong = phieu;
                        _ctDatPhong = ctDatPhong;
                        _hoaDon = HoaDonBLL.GetInvoiceByReservedTicket(phieu.MaPhieuDat);
                        return;
                    }
        }

        private void FmCTPhongCoKhach_Load(object sender, EventArgs e)
        {
            Text = $"Thông tin phòng - {_phong.TenPhong}";
            lblKhachHang.Text = KhachHangBLL.GetCustomer(_phieuDatPhong.CCCD).HoTen;
            lblTamTinh.Text = string.Format("{0:#,##0}", _hoaDon.TongTien);
        }

        private void BtnThemDichVu_Click(object sender, EventArgs e)
        {
            var lstCTDatPhong = new List<tb_CTDatPhong>();
            lstCTDatPhong.Add(_ctDatPhong);
            var fmThemDichVu = new fmThemDichVu(lstCTDatPhong);
            fmThemDichVu.ShowDialog();
            Close();
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            var fmThanhToan = new fmThanhToan(_ctDatPhong);
            Close();
            fmThanhToan.ShowDialog();
        }
    }
}