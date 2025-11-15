using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.PracticeProgram
{
    public class FindMaxElementInArray
    {
        static void Main(string[] args)
        {
            int[,] arr =
            {
                {1,4,7 },
                {2,5,7 },
                { 4,7,8}
            };
            int highest = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > highest)
                        highest = arr[i, j];
                }
            }
            Console.WriteLine("Highest element : "+ highest);
        }
    }
}
