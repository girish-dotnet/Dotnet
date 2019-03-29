using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CSharpNewFeatures.SuperHero;
namespace CSharpNewFeatures
{
    class NullConditionalOperator
    {

        private static void Main(string[] args)
        {
            SuperHero hero = new SuperHero();
            if (hero.SuperPower == String.Empty)
            {
                hero = null;
            }
            /* old syntax of checking if an instance is null or not */
            WriteLine(hero != null ? hero.SuperPower : "You aint a super hero.");
            /* New null conditional operator */
                WriteLine(hero?.SuperPower ?? "You aint a super hero.");

            ReadLine();
        }
    }
    public class SuperHero
    {
        public string SuperPower { get; set; } = "";
    }

    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public Person Spouse { get; set; }
    }
}

