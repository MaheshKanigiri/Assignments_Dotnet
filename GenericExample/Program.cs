using System;

namespace GenericExample
{
    class GenericClass<T>
    {
        public GenericClass(T msg1, T msg2)
        {
            Console.WriteLine(msg1 + " I have " + msg2);
        }
        public GenericClass(int num1, int num2)
        {
            Console.WriteLine("Result: " + (num1 + num2));
        }
        public GenericClass(float a, float b, float c)
        {
            Console.WriteLine("Result for 3 Numbers: "+(a+b+c));
        }
    }
    class StudentClass<T>
    {
        public StudentClass(T studentId) {
        Console.WriteLine("STUDENT ID: "+studentId);
        }
        public StudentClass(String Result, params T[] marks) {
            Console.WriteLine("STUDENT MARKS of:"+Result+" is:");
            foreach(T mark in marks) { Console.WriteLine(mark); }
            

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> intro = new GenericClass<string>("Hi myself Mahesh", "2 Chocolates");
            GenericClass<int> addition = new GenericClass<int>(101, 120);
            GenericClass<float> threeVariableAddition = new GenericClass<float>(101, 100,250);
            StudentClass<string> studentID= new StudentClass<string>("@$1342");
            StudentClass<int> marks= new StudentClass<int>( "mahesh",50, 60,70 );
            StudentClass<float> newMarks= new StudentClass<float>( "jack", 60.3f,80.5f );

        }
    }
}
