using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capgemini.ProductDetails.Entities;
using Capgemini.ProductDetails.Exceptions;

namespace Capgemini.ProductDetails.DataAccessLayer
{
    public class ProductDAL
    {
        public bool AddProductDAL(Product product)
        {
            bool employAdded = false;
            string strcon = "integrated security=true;data source=DESKTOP-07HGAQG\\GIRISH;initial catalog=sqlpractice";
            try
            {
                SqlConnection conn = new SqlConnection(strcon);
                conn.Open();
                SqlCommand cmdInsert = new SqlCommand("prcProductAdd", conn);
                cmdInsert.CommandType = CommandType.StoredProcedure;
                cmdInsert.Parameters.AddWithValue("@SerialNumber", product.SerialNumber);
                cmdInsert.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmdInsert.Parameters.AddWithValue("@BrandName", product.BrandName);
                cmdInsert.Parameters.AddWithValue("@ProductType", product.ProductName);
                cmdInsert.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                cmdInsert.Parameters.AddWithValue("@Price", product.Price);
                cmdInsert.ExecuteNonQuery();
                employAdded = true;
            }
            catch (ProductException)
            {

                throw;
            }
            return employAdded;
           

        }
    }
}
