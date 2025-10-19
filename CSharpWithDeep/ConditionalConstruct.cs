using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class ConditionalConstruct
    {

        // Conditional Construct => If else, Switch Case

        // if(boolean Expresion) {if true this code block will be executed.} else { if false then this code will be executed}

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");    // output
            int inputNumber = Convert.ToInt32(Console.ReadLine()); // input

            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("The Given number is Even number");
            }
            else
            {
                Console.WriteLine("The Given number is Odd number");
            }
            Console.ReadKey();
        }
    }
}
