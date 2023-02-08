using System;
public delegate int methodDelegate(int n);

namespace DelegateExample
{
   
    public class ProgramDelegate<T>
    {
    
        public ProgramDelegate(T[] num)
        {
            foreach (var t in num) { 
            Console.WriteLine(t);
        }
       
        }
        public T method1(T n)
        {
            return n;
        }

    }
    public class Exec { 
    public static void Main(string[] args)
        {
            
            ProgramDelegate<int> example=new ProgramDelegate<int>(new int[] { 1, 2, 3 });
            int x=example.method1(5);
            Console.WriteLine( x);
            methodDelegate deleg = new methodDelegate(example.method1);
            int y=deleg(3);
            Console.WriteLine(y);



        }
    }

}
