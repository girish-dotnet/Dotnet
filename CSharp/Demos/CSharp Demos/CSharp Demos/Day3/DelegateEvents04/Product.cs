using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents04
{
    public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<Product> GetProductInformation()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product("Ruby", 11));
            productList.Add(new Product("Sapphire", 10));
            productList.Add(new Product("Diamond", 12));
            productList.Add(new Product("Pearl", 10));
            return productList;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
