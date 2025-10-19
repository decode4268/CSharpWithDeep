using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class StringVsStrinbuilider
    {
        // String Vs StringBuilder 

        // String class is defined inside the System namespace.
        // StringBuilder class is defined inside the System.Text namespace.

        // The string class is Immutable. It means whenever you will create the instace then you can't change it. when will 
        // change the value then it will store the value of the same ref but different memory location.
        // Stringbuilder is Mutable. It means if you change the value then it will add the value to an existing memory location.

        // The string is slower compared to StringBuilder.
        // StringBuilder is faster than String.

        // string requires more memory allocation. If you will change value constinously. 
        // Because it will create the new instance for every change.
        // StringBuilder requires less memory if you will change value constinously because it will update the value on the same 
        // memeory location.

        // Use String when : 
        // You are performing few or no modifications to the string(like appeding, inserting, or deleting).
        // You are working with short strings. 

        // Use StringBuilder when :
        // You are performing many modifications to the string (eg: in loops).
        // You need better performance and memory efficiency especially with large repeated string operations.

        static void Main(string[] args)
        {
            //string name = "Hello"; // Heap value Space Allocation and reference on Stack Memory
            //name = "Hello World";

            //StringBuilder newName = new StringBuilder("Hello"); 
            //newName = new StringBuilder("Hello World");


            //Console.WriteLine("Hello msg" + name);

            Stopwatch stopwatch = new Stopwatch();
            //string str = "";// one way 
            string str = string.Empty; // second way
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                str = str + i.ToString();
            }
            stopwatch.Stop();
            Console.WriteLine("Total time take by string:"+ stopwatch.Elapsed);

            StringBuilder builder = new StringBuilder();
            stopwatch.Restart();
            for (int j = 0; j < 1000; j++)
            {
                builder.Append(j.ToString());
            }
            stopwatch.Stop();
            Console.WriteLine("Total time taken by strinbuilder"+ stopwatch.Elapsed);
            Console.ReadKey();

        }
    }
}
