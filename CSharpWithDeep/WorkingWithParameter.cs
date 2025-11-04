using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class WorkingWithParameter
    {
        // Working with Parameters : 
        // 1- Pass by value 
        // 2- Pass by ref 
        // 3- Pass by out 
        // 4- Pass by Param

        //1. Pass by value : 
        // When a variable is passed by value, a copy of the variable's data is sent to the method.
        // That means any changes made insdie the method do not affect the original variable.
        int PassByValue(int x, int y)
        {
            x  = x + 10;
            y = x + 40;
            return x + y;
        }
        static void Main()
        {
            int i = 10, j = 20;

            var obj = new WorkingWithParameter();

            //--------------------------- Pass by Value Example -----------------------------

            Console.WriteLine("Pass by value result is : "+ obj.PassByValue(i, j));
            Console.WriteLine("I value is : "+ i + "\n" +  " J value is : "+ j );
            Console.ReadKey();
        }
    }
}
