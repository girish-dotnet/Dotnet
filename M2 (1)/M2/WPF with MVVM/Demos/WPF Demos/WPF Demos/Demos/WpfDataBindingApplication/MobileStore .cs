using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WpfDataBindingApplication
{
    public class MobileStore:INotifyPropertyChanged
    {
       private string brand;  
       private string model;  
       private int stock;  
       private double price;  
  
       public string Brand  
       {  
           get { return brand; }  
           set {   
               brand = value;   
               OnPropertyChanged("Brand");  
           }   
       }
  
       public string Model   
       {  
           get { return model; }   
           set {   
               model = value;   
               OnPropertyChanged("Model");   
           }   
       }  
      
 
       public int Stock   
       {   
               get { return stock; }   
               set {   
                   stock = value;   
                   OnPropertyChanged("Stock");   
               }   
       }
  
       public double Price   
       {   
               get { return price; }   
               set {   
                   price = value;   
                   OnPropertyChanged("Price");   
               }   
       }

       public event PropertyChangedEventHandler PropertyChanged;
       public void OnPropertyChanged(string property)
       {
           if (PropertyChanged != null)
           {
               PropertyChanged(this, new PropertyChangedEventArgs(property));
           }
       }
    }
}
