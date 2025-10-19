using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class DoWhile
    {
        // 2. Do-While Loop 
        // If condition will false then it will execute at least one time. 

        // Difference between while and Do while loop 
        // 1. While loop execute based on the condition, While => Do while will execute at least once either condition will be
        // false.

        public void WhileLoop()
        {
            int a = 1;
            while (a < 0)
            {
                Console.WriteLine("A value is : " + 1);
                a++;
            }
        }
        public void DoWhileLoop()
        {
            int b = 1;
            do
            {
                Console.WriteLine("b value is : " + b);
                b++;
            } while (b < 0);
        }

        public void NestedDoWhileLoop()
        {
            int a = 1;
            do
            {
                Console.WriteLine("a value is : " + a);
                a++;
                int b = 1;
                do
                {
                    Console.WriteLine("b value is : " + b);
                    b++;
                } while (b < 3);

            } while (a < 3);


        }

        static void Main()
        {
            DoWhile obj = new DoWhile();
            //obj.WhileLoop();
            //obj.DoWhileLoop();
            obj.NestedDoWhileLoop();
            Console.ReadKey();
        }

        // Task Do while Loop 
        // Task -1 : 
        // Take a input string from user
        // Before reversing the result is : for eg (deepRaj) 
        // After reversing the resulgt is : for eg (jaRpeed)

        // Task -2 : 
        // First and Last letter do the Capital 

    }
}
