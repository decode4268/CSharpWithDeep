using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class Foreach_Loop
    {
        // Foreach Loop vs For loop 
        // 1. For loop will run in the sequence of forward and backward 
        // 2. Foreach loop will always run in the sequence of forward direction only.
        // 3. Foreach loop will use for collection of data.

        public void BasicExample()
        {
            string name = "Deepraj";
            foreach (char item in name)
            {
                Console.WriteLine(item);
            }
        }

        public void BasicExample2()
        {
            // Declaration of Array 
            // DataTypeName [] arrayname = new DataTypeName[size];

            int[] myValues = new int[6];
            myValues[1] = 12;
            myValues[2] = 13;
            myValues[4] = 141;
            myValues[5] = 125;


            int maximunNo = 0;
            foreach (var item in myValues)
            {
                if (item > maximunNo)
                {
                    maximunNo = item;
                }
            }
            Console.WriteLine("The max no is : "+ maximunNo);

        }

        public void Example3()
        {
            Console.WriteLine("Please enter the length of arry");
            int lengtOfArray = Convert.ToInt32(Console.ReadLine());

            int[] myValues = new int[lengtOfArray];

            for (int i = 0; i < lengtOfArray; i++)
            {
                Console.WriteLine("Please enter " + (i+1) + " number");
                int userInput = Convert.ToInt32(Console.ReadLine());

                myValues[i] = userInput;  // store the value of array index

            }

            foreach (var item in myValues)
            {
                Console.WriteLine("Input data collection: "+item);
            }

            Console.WriteLine();

            int maxNumber = 1;

            foreach (var item in myValues)
            {
                if (item > maxNumber)
                {
                    maxNumber = item;
                }
            }

            Console.WriteLine("The maximun no value enter by user is  : "+ maxNumber);
        }
        static void Main()
        {
            Foreach_Loop obj = new Foreach_Loop();
            //obj.BasicExample2();
            obj.Example3();
            Console.ReadKey();
        }
    }
}
