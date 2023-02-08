using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class StreamWriterExample
    {
        public static void Main(string[] args)
        {
            //creating file
            //FileStream f = new FileStream("C:\\Users\\LF775KW\\source\\repos\\FileHandling\\output.txt", FileMode.Create);
            //StreamWriter s = new StreamWriter(f);

            //s.WriteLine("hello welcome to FileHandling"+"\n"+"Please learn the different methods in it!");
            //s.Close();
            //f.Close();
            //Console.WriteLine("File created successfully...");


            //Reading from the file
            try
            {
                FileStream f1 = new FileStream("C:\\Users\\LF775KW\\source\\repos\\FileHandling\\output.txt", FileMode.Open);
                StreamReader s1 = new StreamReader(f1);
                Console.WriteLine("Enter Choice:\n1.Read Entire File \n2.Read from specific Index");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    string line = "";
                    ;
                    while ((line = s1.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                if (i == 2)
                {
                    Console.WriteLine("Specify Index to print from file: ");
                    long specificIndex = Convert.ToInt64(Console.ReadLine());
                    s1.BaseStream.Seek(specificIndex, SeekOrigin.Begin);
                    string line2 = s1.ReadLine();
                    while (string.IsNullOrEmpty(line2))
                    {
                        Console.WriteLine(line2);
                        line2 = s1.ReadLine();
                    }
                }
                s1.Close();
                f1.Close();
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }

}