using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class ExceptionHandlingInCSharp
    {
        static void Main()
        {
            // Exception Handling in C#
            //int i = 100;
            //int result = i / 0;

            int[] myValue = new int[1];
            myValue[1] = 100;
            Console.WriteLine("Result is : "+ myValue[1]);
            Console.ReadKey();
        }
    }
}
