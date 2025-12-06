using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.Polymorphism
{
    // Compile-Time or Early Binding Polymorphism
    /// <summary>
    /// 1.Achieved by method overloading / operator overloading
    /// 2.Decided at compile time 
    /// 3.Same method name, different parameters
    /// </summary>
    /// Reason to call the Early binding.
    // Because the compiler decided which Add() method to call before the program starts running.
    public class MethodOverloading
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        static void Main()
        {
            // To Do (Home work) 
            // Pass the dynamic value at the run time.
            int a, b, c;
            double d1, d2;

            var obj = new MethodOverloading();
            Console.WriteLine(obj.Add(10, 20)); // call Add(int a, int b)
            Console.WriteLine(obj.Add(10, 20, 50)); // call Add(int a, int b, int c)
            Console.WriteLine(obj.Add(10.5, 20.5)); // call Add(double a, double b )

            Console.ReadKey();
        }

    }
}
