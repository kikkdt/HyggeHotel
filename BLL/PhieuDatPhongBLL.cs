using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PhieuDatPhongBLL
    {
        /// <summary>
        /// Get reserved ticket
        /// </summary>
        /// <param name="maPhieuDatPhong">Reserved ticket ID</param>
        /// <returns>Reserved ticket</returns>
        public static tb_PhieuDatPhong GetReservedTicket(string maPhieuDatPhong)
        {
            return new PhieuDatPhongDAL().GetReservedTicket(maPhieuDatPhong);
        }
    }
}
