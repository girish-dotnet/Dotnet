using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharpNewFeatures
{
    class DictionaryInitializer
    {
         static void Main(string[] args)
        {
            Dictionary <string,string> dictionaryObj = new Dictionary<string, string> ()             /* The new and friendly syntax */
            {
                ["Name"] = "Fizzy",
                ["Planet"] = "Kepler-452b"
            };
            foreach (KeyValuePair<string, string> keyValuePair in dictionaryObj)
            {
                WriteLine(keyValuePair.Key + ": " + keyValuePair.Value + "\n");
}
            ReadLine();
        }

    }
}
