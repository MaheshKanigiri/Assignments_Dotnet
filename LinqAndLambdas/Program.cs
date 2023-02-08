using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqAndLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "mahesh", "jack", "rohan" };
            var getNames = from name in names
                           select name;
            Console.WriteLine(string.Join(", ", getNames));

            int[] nums = { 2, 45, 13, 20, 3, 2 };
            var getNums = from num in nums
                          where num > 10
                          select num;
            Console.WriteLine(string.Join(", ", getNums));

            string sentence = "I'm from Bangalore";
            var simple = from s in sentence
                         select s;
            Console.WriteLine(string.Join(",", simple));

            //in all the above queries ..it returns IEnumerable<T>
            //Note we can only iterate ..and no indexing possible.

            string[] pets = { "cats", "dogs", "rats", "rabbits", "pigs" };
            var getPets = from p in pets
                          where p.Contains("a") && (p.Length > 5)
                          select p;
            Console.WriteLine(string.Join(",", getPets));


            int[] numbers = { 2, 45, 13, 20, 3, 2 };
            var getNumbers = from num in nums
                             where num > 10
                             where num < 40
                             orderby num descending
                             select num;
            Console.WriteLine(string.Join(", ", getNumbers));

        }
    }
}
