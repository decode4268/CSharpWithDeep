using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpWithDeep.ThreadingInC_
{
    public class MultithreadingInCSharp
    {
        static void Main()
        {
            Console.WriteLine("Task Started");
            Thread t1 = new Thread(Task1);
            Thread t2 = new Thread(Task2);

            t1.Start();
            t1.Join(); // wait untill t1 is not completed.
            t2.Start();

        }

        static void Task1()
        {
            Console.WriteLine("Task1 Started");
            Thread.Sleep(2000);
            Console.WriteLine("Task1 Finished");
        }

        static void Task2()
        {
            Console.WriteLine("Task2 Started");
            Thread.Sleep(1500);
            Console.WriteLine("Task2 Finished");
        }
    }
}
