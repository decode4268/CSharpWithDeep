using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpWithDeep.PracticeProgram
{
    public class ThreadType
    {
        static void Main()
        {
            //ForegroundThread();
            BackgroundThread();
        }

        public static void ForegroundThread()
        {
            // These are the main working thread of the application.
            // The application will not exit until all foreground threads Complete. 
            // By Default, thread class create a foreground thread.


            Thread t = new Thread(() =>
            {
                Console.WriteLine("Foreground Thread Started");
                Thread.Sleep(4000);
                Console.WriteLine("Foreground Thread Finished");
                Console.WriteLine("Main thread ends. but app waits for foreground thread.");
            });

            t.IsBackground = false; // default (foreground)
            t.Start();
        }

        public static void BackgroundThread()
        {
            // These runs in the background. 
            // Application does not wait for background threads. 
            // If main thread ends , then background thread is killed immediatedly. 

            Thread t = new Thread(() =>
            {
                Console.WriteLine("Background Thread Started");
                Thread.Sleep(4000);
                Console.WriteLine("Background Thread Finished");
            });

            t.IsBackground = false; // default (foreground)
            t.Start();
            Console.WriteLine("Main thread ends. but app waits for foreground thread.");

        }

        async Task DonwloadData()
        {
           await Task.Delay(2000);
            Console.WriteLine("Data download!");
        }
    }
}
