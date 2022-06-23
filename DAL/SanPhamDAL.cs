using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class SanPhamDAL
    {
        private readonly HyggeDbDataContext dataContext = new HyggeDbDataContext();

        /// <summary>
        ///     Get list of all products
        /// </summary>
        /// <returns>List of all products</returns>
        public List<tb_SanPham> GetProducts()
        {
            return dataContext.tb_SanPhams.ToList();
        }

        /// <summary>
        ///     Get product by product ID
        /// </summary>
        /// <param name="maSanPham">Product ID</param>
        /// <returns>Product</returns>
        public tb_SanPham GetProducts(string maSanPham)
        {
            return dataContext.tb_SanPhams.FirstOrDefault(sp => sp.MaSanPham.Equals(maSanPham));
        }
    }
}