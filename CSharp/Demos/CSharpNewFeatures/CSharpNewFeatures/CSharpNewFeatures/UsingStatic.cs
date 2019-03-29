using static System.Console;
using static CSharpNewFeatures.MySelf;	/* Magic happens here */
namespace CSharpNewFeatures
{
    class UsingStatic
    {
        static void Main(string[] args)
        {
            WhoAmI();
            ReadKey();
        }
    }
    static class MySelf
    {
        public static void WhoAmI()
        {
            WriteLine("C# 6.0 New Feature!");
        }
    }
}
