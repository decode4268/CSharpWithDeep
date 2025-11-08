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
            // 3- Array stores the valeu in index based. 
            // 4- Array starting index will be 0. 
            // 5- Last index of arrary be array length-1.
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
            int[] myValues = new int[5];

            // b- DataTypeName [] arrayName = new DataTypeName[]{values};
            int[] myValues2 = new int[] { 1, 2, 3, 4, 5 };

            // c- DataTypeName [] arrayName = {values};
            int[] myValues3 = { 10, 20, 30, 100 };

        }
    }
}
