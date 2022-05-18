using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SanPhamDAL
    {
        HyggeDbDataContext dataContext = new HyggeDbDataContext();

        /// <summary>
        /// Get list of all products
        /// </summary>
        /// <returns>List of all products</returns>
        public List<tb_SanPham> GetProducts()
        {
            return dataContext.tb_SanPhams.ToList();
        }

        /// <summary>
        /// Get product by product ID
        /// </summary>
        /// <param name="maSanPham">Product ID</param>
        /// <returns>Product</returns>
        public tb_SanPham GetProducts(string maSanPham)
        {
            return dataContext.tb_SanPhams.FirstOrDefault(sp => sp.MaSanPham.Equals(maSanPham));
        }
        
    }
}
