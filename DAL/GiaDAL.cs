using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class GiaDAL
    {
        HyggeDbDataContext dataContext = new HyggeDbDataContext();

        /// <summary>
        /// Get price by kind of room
        /// </summary>
        /// <param name="maLoaiGia">Type of price</param>
        /// <param name="maLoaiPhong">Kind of room</param>
        /// <returns>Price by kind of room</returns>
        public tb_Gia GetPrice(int maLoaiGia, int maLoaiPhong)
        {
            return dataContext.tb_Gias.Where(gia => gia.MaLoaiGia.Equals(maLoaiGia) && gia.MaLoaiPhong.Equals(maLoaiPhong)).FirstOrDefault();
        }

        /// <summary>
        /// Get price by room
        /// </summary>
        /// <param name="maLoaiGia">Type of price</param>
        /// <param name="maPhong">Room ID</param>
        /// <returns>Price by room</returns>
        public tb_Gia GetPrice(int maLoaiGia, string maPhong)
        {
            int maLoaiPhong = dataContext.tb_Phongs.FirstOrDefault(phong => phong.MaPhong.Equals(maPhong)).MaLoaiPhong;
            return GetPrice(maLoaiGia, maLoaiPhong);
        }
    }
}
