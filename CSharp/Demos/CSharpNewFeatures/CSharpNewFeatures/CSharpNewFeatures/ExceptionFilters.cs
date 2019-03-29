using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharpNewFeatures
{
    class ExceptionFilters
    {

        private static void Main(string[] args)
        {
            Random random = new Random();
            var randomExceptions = random.Next(400, 405);
            WriteLine("Generated exception: " + randomExceptions);
            Write("Exception type: ");
            try
            {
                throw new Exception(randomExceptions.ToString());
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("400"))
                    Write("Bad Request");
                else if (ex.Message.Equals("401"))
                    Write("Unauthorized");
                else if (ex.Message.Equals("402"))
                    Write("Payment Required");
                else if (ex.Message.Equals("403"))
                    Write("Forbidden");
                else if (ex.Message.Equals("404"))
                    Write("Not Found");
            }
            ReadLine();
        }

    }
}
