using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    // A properties is a type member that provided a way to read, write private field.
    public class Properties
    {
        int magicNumber;
        public int GetOrSetValue
        {
            get
            {
                return magicNumber;
            }
            set
            {
                magicNumber = value;
            }
        }

        // for setting the value of magicNumber
        public void SetValue(int number)
        {
            magicNumber = number;
        }

        // for getting the value of magicNumber
        public int GetValue()
        {
            return magicNumber;
        }
    }
    public class DeepRaj
    {
        static void Main()
        {
            var obj = new Properties();
            //obj.magicNumber;
            //obj.SetValue(100);
            //Console.WriteLine(obj.GetValue());

            obj.GetOrSetValue = 200;
            Console.WriteLine(obj.GetOrSetValue);

            Console.ReadKey();
        }
    }
}
