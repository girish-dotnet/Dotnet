using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.ProductDetails.Entities
{
    public class Product
    {
        public Product()
        {

        }
        public string SerialNumber { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string ProductType { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
    }
}
