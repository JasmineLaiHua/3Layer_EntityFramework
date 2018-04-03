using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAO
{
    public class ProductsDAO
    {
        QLBanHangEntities database = new QLBanHangEntities();

        //Lay du lieu SanPham
        public List<SanPham> GetProducts()
        {
            try
            {
                //tra ve la 1 list products
                List<SanPham> prod = (from s in database.SanPhams
                                      select s).ToList<SanPham>();
                return prod;
            }
            catch (Exception e)  //exeption chung nhat
            {
                
                throw e;
            }
        }

        //Delete 
        public int Delete(int id)
        {
            
            return 1;
        }
    }
}
