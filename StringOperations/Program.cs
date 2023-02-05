using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello,";
            string str2 = "World";
            string s1 = "Hello C Sharp";
            string[] s2 = s1.Split(' ');
            Console.WriteLine(s2);
            foreach (string s3 in s2)
            {
                Console.WriteLine(s3);
            }
            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str2.ToLower());
            Console.WriteLine(str1.IndexOf('l'));
            Console.WriteLine("split"+(str1.Split('e')));
            Console.WriteLine(str2.Trim());
            Console.WriteLine(str1.Replace("ello","king"));
            string str3 = str1 + str2;
            Console.WriteLine(str3.Concat(str1));
            Console.WriteLine(str2.EndsWith("d"));
            Console.WriteLine(str2.Contains("orld"));
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str3.Length);
            Console.WriteLine(str1.Substring(3));
            Console.WriteLine(str2.StartsWith("Wo"));
            Console.WriteLine(string.Concat(str1, str3));
            Console.WriteLine("---");
            var x = new StringBuilder("hello");
            x.AppendLine("this is string builder");
            Console.WriteLine(x);
            

        }
    }
}
