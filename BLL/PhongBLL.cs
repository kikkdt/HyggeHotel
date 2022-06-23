using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class PhongBLL
    {
        /// <summary>
        ///     Get list all of rooms
        /// </summary>
        /// <returns>List all of rooms</returns>
        public static List<tb_Phong> GetRooms()
        {
            return new PhongDAL().GetRooms();
        }

        /// <summary>
        ///     Get list all of rooms by floor
        /// </summary>
        /// <param name="tangLau">Floor</param>
        /// <returns>List all of rooms</returns>
        public static List<tb_Phong> GetRooms(tb_TangLau tangLau)
        {
            return new PhongDAL().GetRooms(tangLau);
        }

        public static void UpdateStatus(string maPhong, string trangThai)
        {
            new PhongDAL().UpdateStatus(maPhong, trangThai);
        }

        /// <summary>
        ///     Count the number of rooms by status
        /// </summary>
        /// <param name="trangThai">Status want to count</param>
        /// <returns>Number of rooms</returns>
        public static int Count(string trangThai = null)
        {
            return new PhongDAL().Count(trangThai);
        }
    }
}