using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Day1_DependencyPropertyDemo
{
    public class FoodDependencyProperty:DependencyObject
    {
        //Register Dependency Property
        public static readonly DependencyProperty FoodDependency =
            DependencyProperty.Register("MyFavouriteFood", 
            typeof(string), 
            typeof(FoodDependencyProperty),
            new FrameworkPropertyMetadata("Pan Pizza"));

        public string MyFood
        {
            get
            {
                return (string)GetValue(FoodDependency);
            }
            set
            {
                SetValue(FoodDependency, value);
            }
        }
    }
}
