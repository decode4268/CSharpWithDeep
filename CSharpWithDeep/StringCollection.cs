using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class StringCollection
    {
        static void Main()
        {
            string[] userNames = new string[6];
            userNames[0] = "deepraj";
            userNames[1] = "divyanshu";
            userNames[2] = "rahul";
            userNames[3] = "nikhil";
            userNames[4] = "ritik";
            userNames[5] = "abhimanyu";

            Console.WriteLine("Please enter a name");
            string userInput = Console.ReadLine().ToLower();

            bool isExist = false;

            foreach (var name in userNames)
            {
                if (name == userInput)
                {
                    isExist = true;
                    break;
                }
            }
            if (isExist == true)
                Console.WriteLine("This name exist into our system");
            else
                Console.WriteLine("This name not exist into our system");

            Console.ReadKey();
        }
    }
}
