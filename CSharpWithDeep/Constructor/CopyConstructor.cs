using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.Constructor
{
    // Copy Constructor : 
    // A copy constructor is simple a constructor that creates a new object by copying data from another 
    // object of the same type.
    public class CopyConstructor
    {
        int x;
        public CopyConstructor(int i)// Parameterized constructor
        {
            this.x = i;
            Console.WriteLine("Parameterized constructor i value is :"+ i);
        }

        public CopyConstructor(CopyConstructor obj)  // Copy Constructor
        {
            this.x = obj.x;
        }

        public void PrintDetails()
        {
            Console.WriteLine("X value is : "+ x);
        }
        static void Main()
        {
            var obj1 = new CopyConstructor(20);
            obj1.PrintDetails();
            var obj2 = new CopyConstructor(obj1);
            obj2.PrintDetails();
        }
    }
}
