using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF45NewFeatures
{
   //<summary>
   //The class implement INotifyPropertyChanged interface. 
   //This is used for the Properties value changes.
   //</summary>
    public class Product : INotifyPropertyChanged
    {
        int productId;

        public int ProductId
        {
          get { return productId; }
          set 
          {
           productId = value;
           OnPropertychanged("ProductId");
          }
        }


        string productName;
        public string ProductName
        {
          get { return productName; }
          set 
          {
           productName = value;
           OnPropertychanged("ProductName");
          }
        }


        int price;
        public int Price
        {
          get { return price; }
          set 
          {
           price = value;
           OnPropertychanged("Price");
          }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertychanged(string pName)
        {
          if (PropertyChanged != null)
          {
           PropertyChanged(this,new PropertyChangedEventArgs(pName));
          }
        }
    }


    public class ProductCollection : ObservableCollection<Product>
    {
        public ProductCollection()
        {
          Add(new Product() { ProductId = 1, ProductName = "Mobile-Single-SIM", Price = 2300 });
          Add(new Product() { ProductId = 2, ProductName = "Mobile-Duel-SIM", Price = 2300 });
          Add(new Product() { ProductId = 3, ProductName = "Tablet-Single-SIM", Price = 2300 });
          Add(new Product() { ProductId = 4, ProductName = "Tablet-Calling-Facility", Price = 2300 });
          Add(new Product() { ProductId = 5, ProductName = "WiFi Router", Price = 2300 });
          Add(new Product() { ProductId = 6, ProductName = "Blooth", Price = 2300 });
          Add(new Product() { ProductId = 7, ProductName = "Mobile-Pouch", Price = 2300 });
          Add(new Product() { ProductId = 8, ProductName = "Mobile-Scratch-Guard", Price = 2300 });
          Add(new Product() { ProductId = 9, ProductName = "Mobile-Data-Card", Price = 2300 });
        }
    }
}
