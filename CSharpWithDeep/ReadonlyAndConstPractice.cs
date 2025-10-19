using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    class ReadonlyAndConstPractice
    {
        public const int Salary = 50000; 
        public readonly int bonus; //festival 
        public readonly int shoutOut;  // festival 


        // Default constructor or Implicit Constructor
        public ReadonlyAndConstPractice(int bonusAmount, int shoutOutAmount) 
        {
            // first way to provide bonus & shoutOut amount
            //bonus = 10000;
            //shoutOut = 5000;


            // second way to provide bonus & shoutOut amount
            bonus = bonusAmount;
            shoutOut = shoutOutAmount;
            DisplaySalary();

        }

        public void DisplaySalary()
        {
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Bonus: " + bonus);
            Console.WriteLine("ShoutOut: " + shoutOut);
            Console.WriteLine("Total Salary: " + (Salary + bonus + shoutOut));
        }

        static void Main(string[] args)
        {
            ReadonlyAndConstPractice obj = new ReadonlyAndConstPractice(10000, 5000);
            Console.ReadKey();
            //obj.DisplaySalary();
        }
    }
}
