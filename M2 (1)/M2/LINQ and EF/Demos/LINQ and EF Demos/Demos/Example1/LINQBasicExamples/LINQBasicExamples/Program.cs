using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQBasicExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectionOperatorSelectMany();
            ProjectionOperatorSelectOP();
            ProjectionOperatorsSelect();
            FilteringOperatorWhere();
            SortingOperatorOrderBy();
            SortingOperatorThenBy();
            GroupOperatorGroupBy();
            ConcatOperator();
            SetOperators();
            AggregationOperator();
            ElementOperator();

        }
        /// <summary>
        /// Example of Simple Select Projection
        /// </summary>
        private static void ProjectionOperatorsSelect()
        {
            List<string> language = new List<string> { "C","C++","Java","C#","Vb.Net","PHP" };

            var query = from lan in language
                        select lan;

            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
        }
        /// <summary>
        /// Example of Projection operator
        /// </summary>
        private static void ProjectionOperatorSelectOP()
        {
            List<string> phrases = new List<string>() { "an apple a day", "the quick brown fox" };

            var query = from phrase in phrases
                        from word in phrase.Split(' ')
                        select word;

            foreach (string s in query)
                Console.WriteLine(s);
        }

        /// <summary>
        /// Example of Projection Operator SelectMany
        /// </summary>
        private static void ProjectionOperatorSelectMany()
        {
            List<Bouquet> bouquets = new List<Bouquet>() {
                new Bouquet { Flowers = new List<string> { "sunflower", "daisy", "daffodil", "larkspur" }},
                new Bouquet{ Flowers = new List<string> { "tulip", "rose", "orchid" }},
                new Bouquet{ Flowers = new List<string> { "gladiolis", "lily", "snapdragon", "aster", "protea" }},
                new Bouquet{ Flowers = new List<string> { "larkspur", "lilac", "iris", "dahlia" }}
            };

            var query = bouquets.SelectMany(bq => bq.Flowers);

            foreach(string str in query)
            {
                Console.WriteLine(str);
            }
        }
        /// <summary>
        /// Example of Filtering Operator Where
        /// </summary>
        private static void FilteringOperatorWhere()
        {
            List<string> cities = new List<string> { "Mumbai","Agra","Delhi","Chennai","Banagalore","Pune","Trichy"};

            var query = from city in cities
                        where city.Length > 6
                        select city;

            foreach (string c in query)
            {
                Console.WriteLine(c);
            }
        }
        /// <summary>
        /// Exmaple of Sorting/Ordering Operator
        /// </summary>
        private static void SortingOperatorOrderBy()
        {
            List<string> cities = new List<string> { "Mumbai", "Agra", "Delhi", "Chennai", "Banagalore", "Pune", "Trichy" };

            //query for ascending ordering
            var query1 = from city in cities
                         orderby city
                         select city;
           
            //query for descending ordering
            var query2 = from city in cities
                         orderby city descending
                         select city;

            Console.WriteLine("Cities in Ascending Order");
            foreach (string s in query1)
            {
                Console.Write("{0},",s);
            }

            Console.WriteLine("\nCities in Descending Order");
            foreach (string s in query2)
            {
                Console.Write("{0},",s);
            }
        }
        /// <summary>
        /// Exmaple of Sorting / Ordering using ThenBy and ThenByDescending
        /// </summary>
        private static void SortingOperatorThenBy()
        {
            List<Student> studentList = new List<Student> { 
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }, 
                new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
            };

            var query1 = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

            var query2 = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

            foreach (Student s in query1)
            {
                Console.Write("Student Name :{0},Age :{1}", s.StudentName,s.Age);
            }
            Console.WriteLine();    
            foreach (Student s in query2)
            {
                Console.Write("Student Name :{0},Age :{1}", s.StudentName, s.Age);
            }
        }

        /// <summary>
        /// Example of Grouping
        /// </summary>
        private static void GroupOperatorGroupBy()
        {
            List<int> numbers = new List<int>() { 35, 44, 200, 84, 3987, 4, 199, 329, 446, 208 };

            IEnumerable<IGrouping<int, int>> query = from number in numbers
                                                     group number by number % 2;

            foreach (var group in query)
            {
                Console.WriteLine(group.Key == 0 ? "\nEven numbers:" : "\nOdd numbers:");
                foreach (int i in group)
                    Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Example of Concatenation Operator
        /// </summary>
        private static void ConcatOperator()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] morenumbers = { 9, 10, 11, 12, 13, 14, 15 };

            var query = numbers.Concat(morenumbers);

            foreach (int num in query)
            {
                Console.Write("{0}\t", num);
            }
        }

        /// <summary>
        /// Example of Set Operators
        /// </summary>
        private static void SetOperators()
        {
            int[] arr1 = { 2, 4, 6, 8, 10 };
            int[] arr2 = { 3, 6, 9, 12, 15 };

            var intersection = arr1.Intersect(arr2);
            Console.WriteLine("Intersection ...");
            foreach (var item in intersection)
            {
                Console.WriteLine(item);
            }

            var difference = arr1.Except(arr2);
            Console.WriteLine("Difference ...");
            foreach (var item in difference)
            {
                Console.WriteLine(item);
            }

            var union = arr1.Union(arr2);
            Console.WriteLine("Union ...");
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Example of Aggreation Operator
        /// </summary>
        private static void AggregationOperator()
        {
            int[] numbers = { 54, 76, 87, 327, 99 };
            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Min = {0}", numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("Average = {0}", numbers.Average());
            Console.WriteLine("Count = {0}", numbers.Count());
        }

        /// <summary>
        /// Example of Element Operator
        /// </summary>
        private static void ElementOperator()
        {
            string[] empty = { };
            string[] notEmpty = { "Hello", "World" };

            var result = empty.FirstOrDefault(); // null 
            Console.WriteLine(result);

            result = notEmpty.Last();            // World
            Console.WriteLine(result);

            result = notEmpty.ElementAt(1);      // World 
            Console.WriteLine(result);

            result = empty.First();              // InvalidOperationException 
            Console.WriteLine(result);

            result = notEmpty.Single();         // InvalidOperationException 
            Console.WriteLine(result);

            result = notEmpty.First(s => s.StartsWith("W"));
            Console.WriteLine(result);

        }
    }

    class Bouquet
    {
        public List<string> Flowers { get; set; }
    }

    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
