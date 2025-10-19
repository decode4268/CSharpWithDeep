using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    class BoxingAndUnboxing
    {
        static void Main()
        {
            // Boxing and Unboxing in C#
            // Boxing : 1. When you will convert the value type into reference type that conversion is called boxing.
            //           2. No Type Cast required.

            int num = 123; // Stack Memory
            string str = num.ToString(); // Heap Memory  // Boxing 


            // UnBoxing : 1. When you will convert the  reference type into value type that conversion is called boxing.
            //            2.  Type cast mandatory.

            string name = "456"; // Heap Memory
            int number = Convert.ToInt32(name); // Stack Memory // UnBoxing


            object fisrtName = "John"; // 

            object age = 30; // boxing
            int ageOfJohn = (int)age;// unboxing


            int a = 5; 
            object o = a; // boxing

            object l = 5;
            int s = (int)l;// unboxing


            object d = "text";
            string j = (string)d; // not boxing and unboxing





        }
    }
}
