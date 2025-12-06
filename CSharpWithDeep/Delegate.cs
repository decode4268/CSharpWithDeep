using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    // A delegate is a type-safe object that can refer to a method.
    // If the method signature matches, the delegate can call it.
    // Use case 
    // To pass method as parameters
    // To implement callback method 

    public delegate void MyDelegate(string message);

    public class MainClass
    {
        public void PrintToConsole(string msg)
        {
            Console.WriteLine("Console" + msg);
        }

        public void PrintToFile(string msg)
        {
            Console.WriteLine("File" + msg);
        }
    }

    public class DeleteUseClass
    {
        static void Main()
        {
            var obj = new MainClass();
            MyDelegate del1 = obj.PrintToConsole;
            MyDelegate del2 = obj.PrintToFile; ;

            del1("Hello from PrintToConsole");
            del2("Hello from PrintToFile");

            Console.ReadKey();
        }
    }
}
