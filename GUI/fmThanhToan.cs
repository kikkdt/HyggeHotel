using BLL;
using DTO;
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
    public partial class fmThanhToan : Form
    {
        private tb_CTDatPhong _ctDatPhong;
        public fmThanhToan(tb_CTDatPhong _ctDatPhong)
        {
            InitializeComponent();
            this._ctDatPhong = _ctDatPhong;
        }

        
        private void fmThanhToan_Load(object sender, EventArgs e)
        {
            LoadListProduct();
            LoadPhieuDatPhong();
            LoadChiTietPhong();
            LoadHoaDon();
        }

        private void LoadListProduct()
        {
            HyggeDbDataContext db = new HyggeDbDataContext();
            var temp = db.tb_CTDatPhong_SanPhams
                .Where(t => t.MaCTDatPhong == _ctDatPhong.MaCTDatPhong)
                .Select( t => new {
                    TenSanPham = t.tb_SanPham.TenSanPham,
                    DonGia = t.tb_SanPham.DonGia,
                    SoLuong = t.SoLuong,
                }).ToList();

            int i = 1;
            // Add to datagridview
            dgvDsSanPham.Rows.Clear();
            foreach (var item in temp)
            {
                dgvDsSanPham.Rows.Add(i, item.TenSanPham, string.Format("{0:#,##0}", item.DonGia), item.SoLuong, string.Format("{0:#,##0}", item.DonGia * item.SoLuong));
                i++;
            }

        }

        private void LoadPhieuDatPhong()
        {
            var phieuDatPhong = PhieuDatPhongBLL.GetReservedTicket(_ctDatPhong.MaPhieuDat);
            txtMaPhieu.Text = phieuDatPhong.MaPhieuDat;
            txtCCCD.Text = phieuDatPhong.CCCD;
            txtHoTenKH.Text = phieuDatPhong.tb_KhachHang.HoTen;
            txtLoaiHinh.Text = phieuDatPhong.LoaiHinh;
            txtHoTenNV.Text = phieuDatPhong.tb_NhanVien.HoTen;
            txtNgayLap.Text = phieuDatPhong.NgayLap.ToString();
        }
        private void LoadChiTietPhong()
        {
            txtTenPhong.Text = _ctDatPhong.tb_Phong.TenPhong;
            txtSoNguoiLon.Text = _ctDatPhong.SoLuongNguoiLon.ToString();
            txtSoTreEm.Text = _ctDatPhong.SoLuongTreEm.ToString();
            txtNgayNhan.Text = _ctDatPhong.CheckIn.ToString();
            txtNgayTra.Text = _ctDatPhong.CheckOut.ToString();
            txtThanhTien.Text = string.Format("{0:#,##0}", _ctDatPhong.ThanhTien); 
        }
        private void LoadHoaDon()
        {
            var hoaDon = HoaDonBLL.GetInvoiceByReservedTicket(_ctDatPhong.MaPhieuDat);

            txtMaHoaDon.Text = hoaDon.MaHD;
            txtSoTienPhaiThanhToan.Text = string.Format("{0:#,##0 đ}", hoaDon.ThanhTien);
            txtTongTien.Text = string.Format("{0:#,##0 đ}", hoaDon.TongTien);
            txtGiamTru.Text = string.Format("{0:#,##0 đ}", hoaDon.GiamTru).Equals("")? "0": string.Format("{0:#,##0 đ}", hoaDon.GiamTru);
        }

        private void dgvDsSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thanh toán.","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PhongBLL.UpdateStatus(_ctDatPhong.MaPhong, "Chưa dọn");
                fmDangNhap.mainForm.barBtnSoDoPhong.PerformClick();
                this.Close();
            }
        }
    }
}
