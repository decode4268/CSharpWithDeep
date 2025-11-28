using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpWithDeep.PracticeProgram
{
    public class ThreadProgram1
    {
        static void Main()
        {
            Console.WriteLine("Main Thread Started");

            Thread t1 = new Thread(DoWork1);
            Thread t2 = new Thread(DoWork2);

            t1.Start(); // Start first thread 
            t1.Join(); // t2 will start only after t1 finishes (Wait)

            t2.Start(); // start second thread 

            Console.WriteLine("Main Thread Ended");
        }

        static void DoWork1()
        {
            Console.WriteLine("Thread 1 started");
            Thread.Sleep(5000); // Simulate work for 2 second. 
            Console.WriteLine("Thread 1 finished");
        }

        static void DoWork2()
        {
            Console.WriteLine("Thread 2 Started");
            Thread.Sleep(2500); // Simulate work for 1.5 second
            Console.WriteLine("Thread 2 Finished");
        }
    }
}
