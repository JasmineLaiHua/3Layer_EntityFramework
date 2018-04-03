using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class ProductsBUS
    {
        ProductsDAO proDAO = new ProductsDAO();

        public List<SanPham> GetProduct()
        {
            try
            {
                return proDAO.GetProducts();
            }
            catch (Exception e)
            {
                
                throw e;
            } 
        }
    }
}
