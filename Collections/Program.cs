using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Example
    {
        public static void Main(string[] args)
        {
            // Create a list of strings using collection initializer  
            var names = new List<string>() { "Sonoo", "Vimal", "Ratan", "Love" };

            // Iterate through the list.  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
