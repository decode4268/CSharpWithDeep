using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class FactorialProgram
    {
        static void Main()
        {
            int number = 5;

            int factResult = number;
            //  5 * 4 * 3 * 2 * 1

            for (int i = number - 1; i >= 1; i--)
            {
                if (factResult == number)
                {
                    factResult = factResult * i;
                }
                else
                {
                    factResult = factResult * i;
                }
            }

            Console.WriteLine("Factorial of Number is : " + factResult);
            Console.ReadKey();
        }
    }
}
