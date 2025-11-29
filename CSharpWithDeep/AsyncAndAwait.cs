using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class AsyncAndAwait
    {
        
        static async Task Main()
        {
            //int result = await SumCalcuation(20, 42);
            //  Console.WriteLine($"Sum = {result}");

            Console.WriteLine("Task Execution Starting...");
            Task t1 = TaskOne();
            Task t2 = TaskTwo();

            await Task.WhenAll(t1, t2);

            //await TaskOne();
            //await TaskTwo();

            Console.WriteLine("Both task completed!");

        }

        public static async Task<int> SumCalcuation(int a, int b)
        {
            await Task.Delay(2000);
            return a + b;
        }

        static async Task TaskOne()
        {
            await Task.Delay(2000);
            Console.WriteLine("Task 1 Done.");
        }
        static async Task TaskTwo()
        {
            await Task.Delay(3000);
            Console.WriteLine("Task 2 Done.");
        }
    }
}
