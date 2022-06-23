using DTO;
using System.Linq;

namespace DAL
{
    public class PhieuDatPhongDAL
    {
        private readonly HyggeDbDataContext dataContext = new HyggeDbDataContext();

        /// <summary>
        ///     Get reserved ticket
        /// </summary>
        /// <param name="maPhieuDatPhong">Reserved ticket ID</param>
        /// <returns>Reserved ticket</returns>
        public tb_PhieuDatPhong GetReservedTicket(string maPhieuDatPhong)
        {
            return dataContext.tb_PhieuDatPhongs.Where(x => x.MaPhieuDat.Equals(maPhieuDatPhong)).FirstOrDefault();
        }
    }
}