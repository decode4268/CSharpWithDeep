using System;

namespace CSharpWithDeep
{
    class Program
    {
        static void Main() // void mean nothing 
        {
            //int i = 10;
            //string j = "Test";
            //double d = 10.25;
            //char k = 'r';kj
            //bool b = true;
            //object n = 10.25; // Super data type which can any type value.

            //Console.WriteLine("hello world");
            //Console.ReadKey();

            //Console.WriteLine("Please Enter Your Name : ...."); // 
            //string userInput = Console.ReadLine(); // Input
            //// Good Evening + userInput // Output
            //Console.WriteLine("Good Evening : " + userInput);
            //Console.WriteLine("Good Evening : {0} ", userInput);
            //Console.WriteLine($"Good Evening : {userInput}"); // String Interpolation


            //Console.WriteLine("Please Enter you FirstName");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Please Enter you LastName");
            //string lastName = Console.ReadLine();

            //Console.WriteLine("Good Morning : " + firstName + " " + lastName);
            //Console.WriteLine("Good Morning : {0} {1} ", firstName , lastName);
            //Console.WriteLine($"Good Morning : {firstName + " " + lastName}");

            // Sum of two number 
            Console.WriteLine("Please enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine()); // string format "1" + "2" => "12"
            Console.WriteLine("Please enter last number");
            int lastNumber = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumber + lastNumber;
            Console.WriteLine("The two number sum is : "+ firstNumber + " + "  +lastNumber + "= " + sum);
            Console.ReadKey();

           
        }

        /*
         Please enter your fist name 
        Please enter you last name 
        Good Morning firstname lastname
         */


    }
}


// Gurugram - Secotorone  
// Noida - Secotorone 
//namespace global
//{
//    namespace Grugram
//    {
//        class Secotorone // Gurugram
//        {

//        }
//    }

//    namespace Noida
//    {
//        class Secotorone // Gurugram
//        {

//        }
//    }
//}
