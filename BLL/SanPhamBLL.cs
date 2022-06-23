using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class SanPhamBLL
    {
        /// <summary>
        ///     Get list of all products
        /// </summary>
        /// <returns>List of all products</returns>
        public static List<tb_SanPham> GetProducts()
        {
            return new SanPhamDAL().GetProducts();
        }

        /// <summary>
        ///     Get product by product ID
        /// </summary>
        /// <param name="maSanPham">Product ID</param>
        /// <returns>Product</returns>
        public static tb_SanPham GetProducts(string maSanPham)
        {
            return new SanPhamDAL().GetProducts(maSanPham);
        }
    }
}