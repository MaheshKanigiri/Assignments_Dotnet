using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsWithLinq
{
    //model
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public Gender gender { get; set; }
        public Student(int Id, string Name, string Course, Gender gender)
        {
            this.Id = Id; this.Course = Course; this.Name = Name; this.gender = gender;
        }

    }
    class College
    {
        string collegeName { get; set; }
        string city { get; set; }
        public College(string collegeName,string city)
        {
                this.collegeName = collegeName;this.city= city;
        }
    }
    enum Gender
    {
        MALE, FEMALE
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> list = new List<Student>()
            {
                new Student(1,"Mahesh","CSE",Gender.MALE),
                new Student(2,"Rohan","CSE",Gender.MALE),
                new Student(3,"Rita","MECH",Gender.FEMALE)

        };
            //getting only CSE students from above list
            var cse = from i in list
                      where (i.Course == "CSE")
                      orderby i.Id descending
                      select i;
            //on objects use foreach loop to get required.
            foreach (Student student in cse) { 
                Console.WriteLine(student.Id+" "+student.Name + " " + student.gender);
                Console.WriteLine($"Id:{student.Id},Name:{student.Name}");
            }

            List<College> colleges = new List<College>()
            {
                new College("NHCE","Bangalore"),
                new College("UVCE","Bangalore")

            };
           
                              
        }
    }
}
