using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini.ProductDetails.Entities;
using Capgemini.ProductDetails.DataAccessLayer;
using Capgemini.ProductDetails.Exceptions;

namespace Capgemini.ProductDetails.BusinessLayer
{
    public class ProductBL
    {
        private static bool Validate(Product product)
        {
            StringBuilder sb = new StringBuilder();
            bool validateEmploy = true;
            if(product.ProductName.Length==0)
            {
                validateEmploy = false;
                sb.Append(Environment.NewLine + "Productname must be entered.");
            }
            if (product.ProductDescription.Length == 0)
            {
                validateEmploy = false;
                sb.Append(Environment.NewLine + "ProductDescription must be entered.");
            }
            
            return validateEmploy;
        }

        public static bool AddProductBL(Product product)
        {
            bool productAdded = false;
            try
            {
                if (Validate(product))
                {
                    ProductDAL productDal = new ProductDAL();
                    productDal.AddProductDAL(product);
                    productAdded = true;
                }
            }
            catch (ProductException)
            {

                throw;
            }
            return productAdded;
        }
    }
}
