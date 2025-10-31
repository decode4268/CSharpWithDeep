using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.Constructor
{
    public class ParameterizedConstructor
    {
        int x;
        public ParameterizedConstructor(int i)//Parameterized constructor
        {
            Console.WriteLine("Parameterized Constructor: "+ i);
        }
        static void Main()
        {
            var obj = new ParameterizedConstructor(100);
        }
    }
}
