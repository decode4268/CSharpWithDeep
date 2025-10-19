using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    class ImplicitAndExplicitConversion
    {
        static void Main()
        {
            // Implicit and Explicit Conversion in C#

            /* Implicit :- 1. When you will convert the higher precision value into lower precision value that conversion 
            is called implicit conversion.
                2. No Type Cast required. 
                3. No Data Loss.


            */
            //sbyte MaxValue = 127; MinValue = -128
            //byte MaxValue = 255; MinValue = 0
            //short MaxValue = 32,767; MinValue = -32,768
            // ushort MaxValue = 65,535; MinValue = 0
            //int MaxValue = 2_147_483_647; int MinValue = -2_147_483_648;
            //uint MaxValue = 4_294_967_295; uint MinValue = 0;


            int myInt = 10; //MaxValue = 2_147_483_647;
            double myDouble = myInt; // MAXVALUE 1.7976931348623157E+308

            //Console.WriteLine(myInt); // 126
            //Console.WriteLine(myDouble); // 126


            /* Explicit :- 1. When you will convert the lower precision value into higher precision value that conversion
             * is called explicit conversion. 
             * 2. It requires type cast. 
             * 3. Possibility of Data Loss.
             
             */

            double myDoubles = 9.78; // -1.7976931348623157E+308
            int myInts = (int)myDoubles; // 2_147_483_647

            Console.WriteLine(myDoubles);
            Console.WriteLine(myInts);

            

            string strNumber = "12345";

            string pass = "Dukes";  // Semicolon ; => colon :
                                    


            int num = Convert.ToInt32(strNumber); // 12345
            int num2 = int.Parse(strNumber);// 12345
            Console.WriteLine(strNumber);
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.ReadKey();




        }
    }
}
