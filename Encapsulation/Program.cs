using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Student
    {
        // Creating setter and getter for each property  
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    class TestEncapsulation
    {
        static void Main(string[] args)
        {
        Student student = new Student();
        // Setting values to the properties  
        student.ID = "100";
        student.Name = "Mahesh";
        student.Email = "mahi@example.com";
        // getting values  
        Console.WriteLine("ID = " + student.ID);
        Console.WriteLine("Name = " + student.Name);
        Console.WriteLine("Email = " + student.Email);
    }
    }
}
