using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.ExceptionHandling
{
    // Custom Ha
    public class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message)
        {
        }
    }


    public class Normal
    {
        public static void CheckMarks(int marks)
        {
            if (marks < 0 || marks > 100) // true   // && both condition , || in any one 
            {
                throw new InvalidMarksException("Marks must be between 0 and 100");
            }
            else
            {
                Console.WriteLine($"Your marks percentage is :{marks}");
            }
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter your marks!");
                var mark = int.Parse(Console.ReadLine());
                CheckMarks(mark);
                Console.ReadKey();
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine("Custom Exception : "+ ex.Message);
            }
        }
    }
}
