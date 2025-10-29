using CalculationDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    // Base class => The class which has inherited also known as parent class. 
    // Derieved class => The calss which will inherit the base class aslo know as child class.

    internal class MyClass : Class1
    {
       
        static void Main(string[] args)
        {
            
            var obj = new Class1();
            var derivedClassInstance = new MyClass();
            Console.WriteLine("Sum is : "+ obj.Add(1, 2)); 
            //Console.WriteLine("Subtract is : "+ obj.Substract(5, 2));

            Console.WriteLine("Multiply is : "+ derivedClassInstance.Multiply(10, 2)); 
            //Console.WriteLine("Division is : "+ derivedClassInstance.Division(50, 2));

            Console.ReadKey();

        }
    }
}
