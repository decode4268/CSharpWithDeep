using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    class VarKeywordInCsharp
    {
        //var deepRaj = "heloo"; 

        string PrintMessage()
        {
            return " Hello Var Keyword";
        }

        static void Main()
        {


            int number = 10;  // Re-Assign the value
            number = 50;
            int number2 = 10;
            int sum = number + number2; //(Addition)
            Console.WriteLine("The Sum value of Sum " + sum);

            Console.WriteLine("The value of number is " + number);

            string name = "Hello Var Keyword"; // Hello Var Keyword
            string anotherName = " from var session"; // from var session
            string finalName = name + anotherName;//(Concatination) // Hello Var Keyword from var session

            Console.WriteLine("The string value is " + finalName); // "Hello Var Keyword from var session"

            //char character = 'A';
            //bool isActive = true;
            //object obj= 123.45;

            // Var Keyword in CSharp - Implicitly Type Variable

            //1. Whenever you will create the var type you will have to assign the value to the var type.
            //2. You can not assign the null value to the var type.
            //3. Whenever you will assign the value to the var type it will take the data type of the assigned value.
            //4. Whenever it will get the data type after that it will start behave like orginal data type with limitations.
            //5. Var type will be always used as a local variable. 
            //6. Var can not be defined as a class level or parameterized variable.
            //7. Var can not be used as a return type of method.


            var num = 10;
            num = 20;
            var message = 10;

            // creation a obj of the class


            VarKeywordInCsharp varKeywordInCsharp = new VarKeywordInCsharp();
            var result = new VarKeywordInCsharp();
        }
    }
}
