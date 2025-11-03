using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.Constructor
{
    public class PrivateConstructor
    {
        // Private Constructor 
        // A Private constructor is a constructor that cannot be accessed from outside the class 
        // It is declared using the private access modifier.
        // Purpose : 
        // To restrict object creation from outside the class. 
        // To control how and when objects are created. 
        // Generally used in Singleton Desing Pattern. 
        // And used in static classes, where all members are static, and no instance is required. 
        // use Cases: 
        // Singleton pattern: Ensure only one instance of a class exist.

        private PrivateConstructor()
        {
            Console.WriteLine("Private constructor");
        }

        public static void Displaymsg()
        {
            Console.WriteLine("Message Display");
        }

        public static PrivateConstructor CreateObject()
        {
            // way to create obj inside of the class 
            return new PrivateConstructor();
        }

        public void DummyMethod()
        {
            Console.WriteLine("Dummy Method testing");
        }

      
    }

     class Helper
    {
        private Helper()
        {

        }
    }

    public class MyClass
    {
        static void Main()
        {
            //var obj = new PrivateConstructor();   // Cannot create obj Because the constructor is private
            //PrivateConstructor obj = PrivateConstructor.CreateObject();
            //PrivateConstructor.Displaymsg();
            //PrivateConstructor.DummyMethod();
        }
    }

}
