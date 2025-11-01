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
        int y;
        string name = "DeepRaj";
        public ParameterizedConstructor(int i)//Parameterized constructor
        {
            var x = this.name;
            i = this.x;
            //100 = x 
            Console.WriteLine("Parameterized Constructor: " + i);
        }
        public ParameterizedConstructor(int i, int j)//Parameterized constructor
        {
            // y = j;
            this.y = j;
            Console.WriteLine("Parameterized Constructor: " + j);
        }
        static void Main()
        {
            var obj = new ParameterizedConstructor(100);
        }
    }
}
