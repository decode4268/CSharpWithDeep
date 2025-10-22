using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class MethodTypesInCsharp
    {

        #region Non-Static method or Instance Method 

        // Point : 
        // 1. for a non-static method call in main method you have to creat a obj of non-static method.
        // 2. Inside a non-static method another non-static method you can directly access with method name 
        // as below Calcuation method is called inside in ShowMessage().

        public int Calculation(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
        public void ShowMessage()
        {
            Calculation(1, 2);
            Console.WriteLine("Hello this is simple method");
        }

        #endregion

        #region Static Method

        public static void ShowLevel()
        {
            Console.WriteLine("hello from level msg!");
        }
        #endregion

    }


    // non static class 
    public class NonStaticClass
    {
        // field example 
        int nonStaticField;
        static int staticField;

        //Property Example 
        public int NonStaticProperty { get; set; }
        public static int StaticProperty { get; set; }

        // static method example
        public static void StaticEg()
        {
            Console.WriteLine("This is the simple static method");
        }
        //non static method example
        public void NonStaticEg()
        {
            Console.WriteLine("This is the simple non static method");
        }
    }

    // static class
    public static class StaticClass
    {
        // field example 
       // int nonStaticField;
        static int staticField;

        //Property Example 
       // public int NonStaticProperty { get; set; }
        public static int StaticProperty { get; set; }

        // static method example
        public static void StaticEg()
        {
            Console.WriteLine("This is the simple static method");
        }

        //non static method example
        //public void NonStaticEg()
        //{
        //    Console.WriteLine("This is the simple non static method");
        //}
    }

    public class MethodClass
    {
        static void Main(string[] args)
        {
            // Methods in Csharp 
            // Method: It is a set of statement or set of logic which perform a specific task. 
            // Or 
            // A method is a block of code that contains a series of statmement.

            // Method types in C#;
            // 1. Non-static method or Instance Method
            // 2. Static Method 
            // 3. Virtual Method 
            // 4. Partial Method 
            // 5. Extension Method 

            //MethodTypesInCsharp obj = new MethodTypesInCsharp();

            Console.WriteLine(new MethodTypesInCsharp().Calculation(1, 2));
            MethodTypesInCsharp.ShowLevel();
        }
    }
}
