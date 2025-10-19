using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class ForLoop
    {
        //  For Loop
        public void ForLoopEg()
        {
            for (int i = 0; i < 5; i++)   // Out letter 
            {
                Console.WriteLine("I value is :"+ i);

                for (int j = 1; j < 3; j++) // Inner Loop
                {
                    Console.WriteLine("J Value is : "+ j);
                }
            }
        }

        // user input 
        // find the duplicatae char from string 

        public void DuplicateChar()
        {
            Console.WriteLine("Enter the string to find the duplicate char from string");
            string data = Console.ReadLine().ToLower();                 // Google  => google

            int counter = 0;
            for (int i = 0; i < data.Length; i++)// g o o g l e
            {
                for (int j = 0; j < data.Length; j++)
                {

                    if (data[i] == data[j])
                    {
                        counter++;
                    }
                }
                Console.WriteLine(data[i]+ " Occured "+ counter + " times ");
                counter = 0;
            }
        }

        static void Main()
        {
            ForLoop obj = new ForLoop();
            obj.DuplicateChar();
            Console.ReadKey();
        }
    }
}
