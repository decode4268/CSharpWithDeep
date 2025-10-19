using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    // Variable type in c#
    // 1. Class level or Field varialbe.
    // 2. Local Variable
    // 3. Parameterized Variable.
    class VariableTypeInCSharp
    {
        int i; /* Class level or Field Variable */

        // Syntax of creating method 
        // returnType MethodName(){}

        void ShowMessage(int i) // Parameterized Variable(Will contain a value at run time).
        {
            Console.WriteLine("Class level varialbe value: " + i);
        }

        static void Main()
        {
            VariableTypeInCSharp obj = new VariableTypeInCSharp();
            obj.ShowMessage(obj.i);
            int i = 10;  // Local var must assing a value
            Console.WriteLine("The Value of i :"+ i );
            Console.ReadKey();
        }
    }
}
