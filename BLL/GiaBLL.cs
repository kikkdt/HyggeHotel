using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class GiaBLL
    {

        /// <summary>
        /// Get price by kind of room
        /// </summary>
        /// <param name="maLoaiGia">Type of price. Default is 1</param>
        /// <param name="maLoaiPhong">Kind of room</param>
        /// <returns>Price by kind of room</returns>
        public static tb_Gia GetPrice(int maLoaiPhong, int maLoaiGia = 1)
        {
            return new GiaDAL().GetPrice(maLoaiGia, maLoaiPhong);
        }

        /// <summary>
        /// Get price by room
        /// </summary>
        /// <param name="maLoaiGia">Type of price. Default is 1</param>
        /// <param name="maPhong">Room ID</param>
        /// <returns>Price by room</returns>
        public static tb_Gia GetPrice(string maPhong, int maLoaiGia = 1)
        {
            return new GiaDAL().GetPrice(maLoaiGia, maPhong);
        }
    }
}
