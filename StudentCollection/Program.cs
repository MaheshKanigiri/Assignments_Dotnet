using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentList = new List<Student>();
            {
                studentList.Add(
                new Student { id = 1, name = "mahesh" });
               
            }

            studentList.ToString();
            foreach (var student in studentList)
            {
                Console.WriteLine("ID: " + student.id + " NAME: " + student.name);

            }            
           
        }

    }
}
