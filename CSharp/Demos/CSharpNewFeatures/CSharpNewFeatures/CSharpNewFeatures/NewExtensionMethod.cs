using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CSharpNewFeatures.ShapeUtility;
namespace CSharpNewFeatures
{
    class NewExtensionMethod
    {
        private static void Main(string[] args)
        {
            Shape shape = new Shape();
            GenerateRandomSides(shape);
            /* You can write WriteLine(ShapeUtility.IsPolygon(shape));. 
            But here I'm executing extension method on shape type, 
            that's why they are called extension methods 
            since there are just a extension of your type.

            WriteLine(IsPolygon(shape)); // throws error */
            WriteLine(shape.IsPolygon()); // New way of calling Extension method.

            ReadLine();
        }

    }
    public class Shape
    {
        public int Sides { get; set; }
    }
    public static class ShapeUtility
    {
        public static bool IsPolygon(this Shape shape)
        {
            return shape.Sides >= 3;
        }
        public static void GenerateRandomSides(Shape shape)
        {
            Random random = new Random();
            shape.Sides = random.Next(1, 6);
        }
    }

}
