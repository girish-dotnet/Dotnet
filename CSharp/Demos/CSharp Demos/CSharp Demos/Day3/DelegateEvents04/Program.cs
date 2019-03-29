using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing the Product List
            Console.WriteLine("Product List");
            Console.WriteLine("------------");
            foreach (Product product in Product.GetProductInformation())
            {
                Console.WriteLine(product.ToString());

            }

            Console.Write(Environment.NewLine);
            Console.WriteLine("\n\nUsing IComparer Interface to Compare and Sort");
            Console.WriteLine("-------------------------------------------------");
            List<Product> productList01 = Product.GetProductInformation();
            productList01.Sort(new CompareProduct());
            foreach (Product product in productList01)
            {
                Console.WriteLine(product.ToString());

            }

            Console.Write(Environment.NewLine);
            Console.WriteLine("Sorting Product List using Lambda Expression");
            Console.WriteLine("--------------------------------------------");
            Console.Write(Environment.NewLine);
            List<Product> productList02 = Product.GetProductInformation();
            foreach (Product product in productList02.OrderBy(p => p.Name))
            {
                Console.WriteLine(product.ToString());
            }

            Console.Write(Environment.NewLine);
            Console.WriteLine("Lamda Expression with Printing & Finding with price > 10 ");
            Console.WriteLine("---------------------------------------------------------");
            Console.Write(Environment.NewLine);
            List<Product> productList03 = Product.GetProductInformation();
            foreach (Product product in productList03.Where(p => p.Price > 10))
            {
                Console.WriteLine(product);
            }

            Console.Write(Environment.NewLine);
            Console.WriteLine("Delegate to Printing & Finding with price == 10");
            Console.WriteLine("-----------------------------------------------");
            Console.Write(Environment.NewLine);
            List<Product> productList04 = Product.GetProductInformation();
            productList04.FindAll((delegate(Product p) { return p.Price == 10; })).ForEach((delegate(Product p) { Console.WriteLine(p); }));

            Console.ReadKey();
        }
    }
}
