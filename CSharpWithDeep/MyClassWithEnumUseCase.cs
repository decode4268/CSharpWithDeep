using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{

    enum Colour
    {
        Red = 1,
        Green,
        Blue,
        Black,
        Orange
    }
    public class MyClassWithEnumUseCase
    {
        static void Main()
        {
            Console.WriteLine("Please enter you colour choice : /n 1-Red, 2-Green, 3-Blue, 4-Black, 5-Orange");
            int userChoice = int.Parse(Console.ReadLine());

            Colour userInput = (Colour)userChoice;

            // Using If elseif and else
            if (userInput == Colour.Red)
            {
                Console.WriteLine("Your favourite colour is Red");
            }
            else if (userInput == Colour.Green)
            {
                Console.WriteLine("Your favourite colour is Green");
            }
            else if (userInput == Colour.Blue)
            {
                Console.WriteLine("Your favourite colour is Blue");
            }
            else if (userInput == Colour.Black)
            {
                Console.WriteLine("Your favourite colour is Black");
            }
            else if (userInput == Colour.Orange)
            {
                Console.WriteLine("Your favourite colour is Orange");
            }
            else
            {
                Console.WriteLine("Your choice does not exist!");
            }


            // Using Switch case
            //switch (userInput)
            //{
            //    case Colour.Red:
            //        Console.WriteLine("Your favourite colour is Red");
            //        break;

            //    case Colour.Green:
            //        Console.WriteLine("Your favourite colour is Green");
            //        break;
            //    case Colour.Blue:
            //        Console.WriteLine("Your favourite colour is Blue");
            //        break;
            //    case Colour.Black:
            //        Console.WriteLine("Your favourite colour is Black");
            //        break;
            //    case Colour.Orange:
            //        Console.WriteLine("Your favourite colour is Orange");
            //        break;

            //    default:
            //        Console.WriteLine("Your choice does not exist!");
            //        break;
            //}


            Console.ReadKey();
        }
    }
}
