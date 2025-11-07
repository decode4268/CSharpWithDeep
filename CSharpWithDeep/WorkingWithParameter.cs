using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class WorkingWithParameter
    {
        // Working with Parameters : 
        // 1- Pass by value 
        // 2- Pass by ref 
        // 3- Pass by out 
        // 4- Pass by Param

        //1. Pass by value : 
        // When a variable is passed by value, a copy of the variable's data is sent to the method.
        // That means any changes made insdie the method do not affect the original variable.
        int PassByValue(int x, int y)
        {
            x = x + 10;
            y = x + 40;
            return x + y;
        }

        // 2. Pass by ref
        // When a variable is passed by reference the memory address of the variable is sent to the method. 
        // That means the method works on the original data not a copy.
        // In case of the pass by ref you need to pass value along with the ref.

        //Note : 
        // In case of pass by value : The actuall value is not comming on params only copy of that particular 
        // value is comming. (That means the actual value will not change here).
        //In case of pass by ref : The actual value is passing through the parms. It means the actaul value will 
        // also change in the case of pass by ref.
        int PassByRef(ref int x, ref int y)
        {
            x = x + 10;
            y = x + 40;
            return x + y;
        }


        // 3- Pass by out 
        // When you use the out keyword the variable is passed by reference, just like ref, but with one key
        // difference: 
        // You don't need to initialize the variable before passing it. 
        // The called method must assing a value to it before returing. 

        int PassByOut(int x, int y, out int a)
        {
            x = x + 10;
            y = x + 40;
            a = x + y + 50;
            return x + y;
        }

        //4- Pass by Param

        //int AddNumbers(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //int AddValues(int[] values)
        //{
        //    int sum = 0;
        //    foreach (var item in values)
        //    {
        //        //sum = sum + item;
        //        sum += item;
        //    }

        //    return sum;
        //}


        int PaasByParm(params int[] values)
        {
            int sum = 0;
            foreach (var item in values)
            {
                //sum = sum + item;
                sum += item;
            }

            return sum;
        }

        static void Main()
        {
            int i = 10, j = 20;

            int a = 10, b = 20, c = 30, d = 40, e = 50, f = 60, g = 70;
            int[] myValues = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var obj = new WorkingWithParameter();

            //--------------------------- Pass by Value Example -----------------------------

            //Console.WriteLine("Pass by value result is : " + obj.PassByValue(i, j));
            //Console.WriteLine("I value is : " + i + "\n" + " J value is : " + j);


            //-------------------------- Pass by Ref example ---------------------------
            //Console.WriteLine("Pass by ref example start here..");
            //Console.WriteLine("Pass by ref result is : " + obj.PassByRef(ref i, ref j));
            //Console.WriteLine(i);
            //Console.WriteLine(j);



            //-------------------------- Pass by Out example ---------------------------
            //Console.WriteLine("Pass by ref example start here..");
            //Console.WriteLine("Pass by out result is : "+ obj.PassByOut(i, j, out int a));  //80
            //Console.WriteLine(i);
            //Console.WriteLine(j); 
            //Console.WriteLine(a); 


            //-------------------------- Pass by Param example ---------------------------
            //Console.WriteLine(obj.AddNumbers(a, b, c)); // 60
            //Console.WriteLine(obj.AddValues(myValues)); //28

            // Actual Example : 
            Console.WriteLine(obj.PaasByParm(a, b, c, d, e, f, g));
            Console.WriteLine(obj.PaasByParm(myValues));
            Console.ReadKey();
        }
    }

}
