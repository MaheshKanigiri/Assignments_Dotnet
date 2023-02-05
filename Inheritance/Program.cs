using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public class Employee
    {
        public float salary = 40000;
    }
    public class Programmer : Employee
    {
        public float bonus = 10000;
        public void company()
        {
            Console.WriteLine("Working in Company!");
        }
    }
    public class Developer : Programmer {
        public float DeveloperBonus = 5000;
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Programmer p1 = new Programmer();
            Developer d1= new Developer();
            Employee emp1= new Employee();
            Console.WriteLine("Basic Salary: " + emp1.salary);
            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);
            Console.WriteLine("Developer Salary: " + d1.DeveloperBonus);
            d1.company();
            Console.WriteLine("Developer Salary: " + d1.bonus);


        }

    }
}
