using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.Constructor
{
    // Constructor Type in CSharp : 
    // 1. Default or Parameterless Constructor
    // 2. Parameteried Constructor 
    // 3. Copy Constructor
    // 4. Static Constructor 
    // 5. Private Constructor

    public class Constructor
    {

        // 1. Default or Parameterless Constructor 
        int _carModel;
        string _carName;
        bool _isValid;

        public Constructor() //Parameterless Constructor
        {
            _carModel = 0;
            _carName = null;
            _isValid = false;
        }

        public Constructor(int number)
        {

        }

        public Constructor(int number, int number2)
        {

        }

        public void PrintCarDetails(int carModel, string carName)
        {
            Console.WriteLine("Car Model: " + carModel + " Car Name : " + carName);
        }

        static void Main()
        {
            var obj = new Constructor();
            //var constructor = new Constructor(10);  // Automatically default constructor has called.
            //Console.WriteLine(constructor._carModel);   // 0
            //Console.WriteLine(constructor._carName);    // ""
            //Console.WriteLine(constructor._isValid);    //true

            Console.ReadKey();
        }
    }
}
