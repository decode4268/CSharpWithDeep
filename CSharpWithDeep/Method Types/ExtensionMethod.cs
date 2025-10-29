using CalculationDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.Method_Types
{
    // Extension Method : 
    // Extension methods can be used as an approach to extending the functionality of a class in the future if the source code 
    // of the class is not available or we don't have any permission in making changes to the class.
    public static class ExtensionMethod
    {
        // Extension Method : 
        // 1. Method must be static method. 
        // 2. Method parameter must be passed this keyword a long with the type who want to access this extension method.
        // 3. Class must be static class.

        private static string name = "deep";

        public static string MakeFirstLetterCapital(this string name)
        {
            string result = string.Empty;
            if (name.Length > 0)
            {
                result = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1).ToLower();
            }
            return result;
        }

        public static int Division(this Class1 cal, int fistNumber, int secondNumber)
        {
            return fistNumber / secondNumber;
        }
        static void Main()
        {
            //ExtensionMethod.MakeFirstLetterCapital(name);
            var obj = new Class1();
            Console.WriteLine("Sum is : "+ obj.Add(20, 10));
            Console.WriteLine("Sub is : "+ obj.Substract(20, 10));
            Console.WriteLine("Mul is : "+ obj.Multiply(20, 10));
            Console.WriteLine("Div is : "+ obj.Division(20, 10));
            Console.ReadKey();
        }
    }
}
