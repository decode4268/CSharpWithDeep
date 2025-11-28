using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpWithDeep.ThreadingInC_
{
    public class BasicThreadExample
    {
        static void Main()
        {
            // Manually creating a thread and starting a thread with PrintNumbers method. 
            //Thread thread = new Thread(PrintNumbers);
            //thread.Start();

            //PrintNumbers();  //  Main thread.

            // Passing Parameter to thread 
            //Thread t = new Thread(Print);
            //t.Start("Hello from threading parm!");
            //Print("hello");

            // Sleep the thread
            //Thread.Sleep(5000);

            // Makes one thread wait for another 
            Thread t2 = new Thread(Print);
            t2.Start("Hello");
            Thread.Sleep(2000);

            t2.Priority = ThreadPriority.BelowNormal; // Lowest, Normal, AboveNormal, Highest

            PrintNumbers();
            t2.Join(); // Main thread waits unit t2 finished.
        }

        static void PrintNumbers()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Print(object message)
        {
            Console.WriteLine(message);
        }
    }
}
