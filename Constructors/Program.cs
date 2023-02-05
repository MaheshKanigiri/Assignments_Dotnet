using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        int a;
        Int32 b;
       
        public Program()
        {
            Console.WriteLine("default constructor");
        }
        public Program(String name,String city)
        {
            
            Console.WriteLine(name+"  | "+city);
        }
        static void Main(string[] args)
        {
            String name = "mahesh";
            String city ="banglore";
            Program obj = new Program();
            Program obj2 = new Program(name,city);
        }
    }
}
