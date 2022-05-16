using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class KhachHangDAL
    {
        HyggeDbDataContext dataContext = new HyggeDbDataContext();

        /// <summary>
        /// Get a customer by id
        /// </summary>
        /// <param name="id">Customer ID</param>
        /// <returns>A customer</returns>
        public tb_KhachHang GetCustomer(string id)
        {
            return dataContext.tb_KhachHangs.FirstOrDefault(kh => kh.CCCD.Equals(id));
        }

        /// <summary>
        /// Get a list of all customers
        /// </summary>
        /// <returns>List of all customers</returns>
        public List<tb_KhachHang> GetCustomers()
        {
            return dataContext.tb_KhachHangs.ToList();
        }
    }
}
