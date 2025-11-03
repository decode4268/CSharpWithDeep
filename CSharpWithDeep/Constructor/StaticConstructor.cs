using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.Constructor
{
    // Static Constructor : 
    // 1. Static Constructor does not allow any access specifier. 
    // 2. If you have any static field inside the class then default static constructor will be created by the 
    // compiler. 
    // 3. You can create static constructor inside the static as well as non-static class.. 
    // 4. You can't create more then one static constructor.
    // 5. Because you can't pass parameters to the static constructor. 
    // 6. Static constructor will be called at the first place when we have one more constructor. // To do for next 
    // class.
    class StaticConstructor
    {
        static int i;   // Static Field Variable 
        //static StaticConstructor()      // Static Constructor 
        //{
        //    Console.WriteLine("I am static Constructor");
        //}
        public StaticConstructor()
        {
            Console.WriteLine("I am a Default or Parameterless constructor"); // non-static costructor
        }
        static void Main()
        {
            //var obj = new StaticConstructor();
            Console.WriteLine("I value is :" + i);
            Console.ReadKey();
        }
    }
}
