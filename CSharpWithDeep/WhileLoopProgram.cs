using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class WhileLoopProgram
    {
        public void ReverseString()
        {
            // DeepRaj => [0]= D, [1]= e, [2]= e, [3]= p, [4]= R, [5]= a, [6]= j
            // length => 7
            Console.WriteLine("Enter your Name for");   // DeepRaj 
            string name = Console.ReadLine().ToLower();  // deepraj => jarpeed => JarpeeD => 06=> 7 lenth-1 , 0
            string result = string.Empty;

            int k = name.Length - 1;
            while (k >= 0)
            {
                //result += name[length];
                if (k == 0)
                {
                    result += name[k].ToString().ToUpper();
                }
                else if (k == name.Length - 1)
                {
                    result += name[k].ToString().ToUpper();
                }
                else
                {
                    result += name[k];
                }
                k--;

            }
            Console.WriteLine("The reverse name is : " + result);

            //1. Upper letter count , Lower letter count, and space count 
            // This is Cat 
            // Upper Letters  = 2, 
            // Lower Letters = 7, 
            // Spaces = 2

            // Find the highest number take the user input 4 number
            // 12, 34, 56,76
            // outpu => 76
        }

        public void NestedWhileLoop()
        {
            int i = 1;
            while (i < 5)     // outler loop
            {
                Console.WriteLine("I value is : " + i);
                i++;
                int j = 1;
                while (j < 3)  // inner loop
                {
                    Console.WriteLine("J Value is : " + j);
                    j++;
                }
            }

            //     I value is 1
            // J value is 1 
            //          J value is 2
        }

        static void Main(string[] args)
        {
            WhileLoopProgram obj = new WhileLoopProgram();

            obj.NestedWhileLoop();

            Console.ReadKey();
        }
    }
}
