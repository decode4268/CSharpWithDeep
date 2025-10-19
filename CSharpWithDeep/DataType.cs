using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    class DataType
    {
        static int number;
        static string name;
        //Data Type Category
        // Pre-Define or System-Define Data Type
        // int, double, char, string, bool, object, etc..

        // User-Define Data Type
        // class, object, array, interface, delegate, enum, struct, etc..

        // Based on the memory allocation in C# Data type are two types which are follow as :

        // Value Type
        // int, double, char, bool, struc, enum, etc..
        // Default value is 0. 
        // It stores value on stack memory.
        // No Garbase Collector required for memeory management.


        // Reference Type
        // string, object, class, array, interface, delegate, etc..
        // Default value is null.
        // It stores value on Heap memory but reference on stack memeory.
        // Garbase Collector is required for memeory management.

        static void Main(string[] args)
        {
            Console.WriteLine("Hello From Data Type Session"); // "" => Double Quote, '' => Single Quote
            Console.WriteLine("The Value of number"+ DataType.number);
            Console.WriteLine("The Value of name"+ DataType.name);



            Console.ReadKey();

        }
    }
}
