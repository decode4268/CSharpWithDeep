using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class ArrayInCSharp
    {
        static void Main()
        {
            // 1 to 100 
            int a = 1, b = 2, c = 3, d = 4; // .... 100

            // Array in CSharp
            // 1- Array in a reference type.
            // 2- Array is fixed in size.
            // 3- Array stores the value in index based. 
            // 4- Array starting index will be 0. 
            // 5- Last index of arrary will be array length - 1.
            // 6- Array can store multiple value of same data type. 
            // 7- If you will not assign a value of the particular index then it will get the default value
            // based on that data type. 
            // 8- If you want to change the size then we can recreate the array.

            // Array type in C# 
            // 1- Single Dimensional Array
            // 2- Multi Dimensional Array 
            // 3- Jagged Array 

            // 1- Single Dimensional Array
            // 1, 2, 3, 4, 5, 6, ....99.
            // Syntax of Single Dimensional Array
            // a- DataTypesName [] arrayName = new DataTypeName[size];
            int[] myValues = new int[10];
            myValues[0] = 1;
            myValues[1] = 2;
            myValues[2] = 45;
            myValues[3] = 5;
            myValues[4] = 8;
            myValues[5] = 7;
            myValues[7] = 7;
            myValues[9] = 85;

            // resize the array 
            Array.Sort(myValues);
            Console.WriteLine("Array value after sort");
            //foreach (var item in myValues)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------------------");

            //Console.WriteLine("Array value after reverse");

            Array.Reverse(myValues);
            //foreach (var item in myValues)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---------------------------");

            Array.Resize(ref myValues, 11);

            //Console.WriteLine("Array length is : " + myValues.Length);
            //Console.WriteLine("Array length is : " + myValues.GetLength(0));
            //Console.WriteLine("Array lowest index is : " + myValues.GetLowerBound(0));
            //Console.WriteLine("Array highest index is : " + myValues.GetUpperBound(0));
            //Console.WriteLine("Array Value by index is : " + myValues.GetValue(9));

            //Console.WriteLine(myValues[6]);
            //Console.WriteLine(myValues[8]);



            // b- DataTypeName [] arrayName = new DataTypeName[]{values};
            //int[] myValues2 = new int[] { 1, 2, 45, 5, 8, 7, 0, 0, 85 };
            //foreach (var item in myValues2)
            //{
            //    Console.WriteLine(item);
            //}


            // c- DataTypeName [] arrayName = {values};
            //int[] myValues3 = { 10, 20, 30, 100 };


            // 2- Multi Dimensional Array 
            // Syntax of multi dimensional array. 
            // DateTypeName [] arrayName = new DataType[size]; // Single Dimensional Array 
            //DateTypeName [,] arrayName = new DateTypeName[row, columns]; // Multi Dimensional Array 

            int[,] myMultiValuesFirst = new int[3, 2]; // rows = 3, columns = 2    // 1 2

            // first rows initiliazed 
            myMultiValuesFirst[0, 0] = 1;
            myMultiValuesFirst[0, 1] = 2;


            // second rows 
            myMultiValuesFirst[1, 0] = 3;
            myMultiValuesFirst[1, 1] = 4;

            // third rows 

            myMultiValuesFirst[2, 0] = 5;
            myMultiValuesFirst[2, 1] = 6;

            //Console.WriteLine("row : " + myMultiValuesFirst.GetLength(0) + "Columns : "+ myMultiValuesFirst.GetLength(1));

            int row = myMultiValuesFirst.GetLength(0);
            int column = myMultiValuesFirst.GetLength(1);

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write(myMultiValuesFirst[i, j] + " ");  // 1 2
            //    }
            //    Console.WriteLine();
            //}


            // 3- Jagged Array 
            // Syntax of Jagged array. 
            //DateTypeName [] arrayName = new DataType[size]; // Single Dimensional Array 
            //DateTypeName [,] arrayName = new DateTypeName[row, columns]; // Multi Dimensional Array 

            //DateTypeName[][] arrayName = new DataTypeName[size][]; // Jagged Array Single Dimensional
            //DateTypeName[][,] arrayName = new DataTypeName[size][];// Jagged Array Multi Dimensional


            //DateTypeName[][] arrayName = new DataTypeName[size][]; // Jagged Array Single Dimensional
            int[][] jaggedArray = new int[4][]
            {
                new int[6] { 1, 2, 3, 4, 5, 0},
                new int[] { 6, 7 },
                new int[] { 8, 9, 10, 11, 12, 13, 14 },
                new int [] {7,8, 9, 10,11, 12, 13}
            };

            //Console.WriteLine(jaggedArray[2][1]);


            //DateTypeName[][,] arrayName = new DataTypeName[size][];// Jagged Array Multi Dimensional
            int[][,] jaggedMultiArray = new int[2][,];
            jaggedMultiArray[0] = new int[3, 2] { { 1, 2 }, { 2, 1 }, { 3, 1 } };
            jaggedMultiArray[1] = new int[3, 3] { { 1, 2, 1 }, { 2, 1, 4 }, { 3, 1, 6 } };

            // other way 

            int[][,] jaggedOtherMutliArray = new int[2][,]
            {
                new int [3, 2] { { 1, 2 }, { 2, 1 }, { 3, 1 } },
                new int [3, 3] { { 1, 2, 1 }, { 2, 1, 4}, { 3, 1, 6 } }
            };

            Console.ReadKey();




            /*
             1 2
             3 4 
             5 6
             
             1
             1 2
             1 2 3
             1 2 3 4
             1 2 3 4 5
             */


        }
    }
}
