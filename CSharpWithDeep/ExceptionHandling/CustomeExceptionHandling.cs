using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    
    public class CustomeExceptionHandling
    {
        public static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("Age must be 18 or above!");
            }
            else
            {
                Console.WriteLine("Valid Age");
            }
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Please Enter you age..");
                int age = Convert.ToInt32(Console.ReadLine());
                CheckAge(age);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception caught :"+ ex.Message);
            }
        }
    }
}
