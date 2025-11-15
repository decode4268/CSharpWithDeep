using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class ExceptionHandlingInCSharp
    {
        static void Main()
        {
            // Exception Handling in C#
            int i = 100;
            //int result = i / 0;

            //int[] myValue = new int[1];
            //myValue[1] = 100;
            //Console.WriteLine("Result is : "+ myValue[1]);


            int result;
          
            try
            {
                // Here you will keep piece of code which you assume 
                // error occure could be.
                result = i / 0;
                Console.WriteLine("Hey, I am visible here because there is no error.");

            }
            catch (Exception ex)
            {
                //If an error will be occured into try section then only this block will be
                // executed
                //Console.WriteLine(ex.Message);

                Console.WriteLine("Message:" + ex.Message + " StackTrace:"+ ex.StackTrace
                    + "Source:"+ ex.Source + "TargetSite: "+ex.TargetSite.Name + " DateTime :"+ DateTime.Now);

                //throw;

            }
            finally
            {
                // This block be always executed.
                Console.WriteLine("This is the finally block");
            }

            Console.ReadKey();
        }
    }
}
