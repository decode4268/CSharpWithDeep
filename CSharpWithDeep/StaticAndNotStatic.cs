using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    // Creation of field, property, method
    class StaticAndNotStatic
    {
        // field example 
        int number1 = 100; // nonStaticField
        static int number2; // staticField


        // Property example (Shortcut prop => Tab 1 times)
        public string FirstName { get; set; }  // nonstatic prop
        public static string LastName { get; set; }  // nonstatic prop

        // Method Example 
        // Syntax of method creation 
        /* returnType MethodName(){
            return returnTypeValue;    
        } */ 
        // for example 

        // Non Static Method 
        void NonStaticMethod()
        {
            number2 = 100;
            StaticAndNotStatic.number2 = 100;
            int i = 10;
            Console.WriteLine("This is non static method");
        }

        // Static Method 
        static void StaticMethod()
        {
            Console.WriteLine("This is static method");
        }


        static void Main()
        {
            int i = 10;
            // Class Vs object 

            // India (Class)                    USA (Class)
            //Shri Narendra Modi(object)        Trump

            // Syntax of Creating Object 
            // ClassName objectName = new ClassName()

            StaticAndNotStatic.number2 = 20;
            StaticAndNotStatic obj = new StaticAndNotStatic();
            obj.number1 = 1;
        }


        // Id => Primary key idenity 1, 1
        // FirstName => 100 not null
        // LastName => 50 not null
        // Email => 200 null 
        // DateofBirth => not null (Datetime)



    }
}
