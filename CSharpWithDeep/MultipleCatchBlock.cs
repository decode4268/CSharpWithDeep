using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class MultipleCatchBlock
    {
        static void Main()
        {
            try
            {
                int a = 100;
                int[] arr = { 1, 2, 3 };
                Console.WriteLine(arr[2]); // Index out of Range Exception.

                int result = a / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You try to divide by zero");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array index is out of range");
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
