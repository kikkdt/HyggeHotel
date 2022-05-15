using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class KhachHangBLL
    {
        /// <summary>
        /// Get a customer by id
        /// </summary>
        /// <param name="id">Customer ID</param>
        /// <returns>A customer</returns>
        public static tb_KhachHang GetCustomer(string id)
        {
            return new KhachHangDAL().GetCustomer(id);
        }

        /// <summary>
        /// Get a list of all customers
        /// </summary>
        /// <returns>List of all customers</returns>
        public static List<tb_KhachHang> GetCustomers()
        {
            return new KhachHangDAL().GetCustomers();
        }
    }
}
