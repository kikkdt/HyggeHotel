using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        /// <summary>
        /// Get a invoice by invoice ID
        /// </summary>
        /// <param name="maHoaDon">Invoice ID</param>
        /// <returns>A invoice</returns>
        public static tb_HoaDon GetInvoice(string maHoaDon)
        {
            return new HoaDonDAL().GetInvoice(maHoaDon);
        }

        /// <summary>
        /// Get a invoice by reserved ticket ID
        /// </summary>
        /// <param name="maPhieuDat">Reserved ticket ID</param>
        /// <returns>A invoice</returns>
        public static tb_HoaDon GetInvoiceByReservedTicket(string maPhieuDat)
        {
            return new HoaDonDAL().GetInvoiceByReservedTicket(maPhieuDat);
        }

        /// <summary>
        /// Get list of all unpaid invoices
        /// </summary>
        /// <returns>list of all unpaid invoices</returns>
        public static List<tb_HoaDon> GetUnpaidInvoices()
        {
            return new HoaDonDAL().GetUnpaidInvoices();
        }

        public static void UpdateTotalAmount(string maPhieuDatPhong)
        {
            var hoaDon = GetInvoiceByReservedTicket(maPhieuDatPhong);
            using (HyggeDbDataContext dataContext = new HyggeDbDataContext())
            {
                var phieuDatPhong = PhieuDatPhongBLL.GetReservedTicket(maPhieuDatPhong);
                var ctDatPhongs = CTDatPhongBLL.GetDetailReservedTicket(maPhieuDatPhong);
                double totalAmount = DatPhongBLL.CalcTotalAmount(phieuDatPhong.LoaiHinh, ctDatPhongs);
                hoaDon.TongTien = (decimal)totalAmount;
                
                Update(hoaDon);
            }
        }

        public static void Update(tb_HoaDon hoaDonMoi)
        {
            new HoaDonDAL().Update(hoaDonMoi);
        }
    }
}
