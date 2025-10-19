using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class Operator
    {
        // Operator In C# 
        // When you want to perform a operation between two or more operand(Variable) then you can use the operator.
        // Operators Type in C# 
        // 1. Arithmetic Operator  +, -, *, /, %
        // 2. Assignment Operator =, +=, -=, *=, /=, %=
        // 3. Unary Operator i++(Post Increment), ++i(Pre Increment), i--(Post Decrement), --i(Pre Decrement)
        // 4. Conditional or Comparison Operator  < >, <=, >=, ==, !=
        // 5. Logical Operator  &&(AND), ||(OR), !(NOT)
        // 6. Ternary Operator  condition ? true : false ( If and Else)


        static void Main()
        {
            //1. Arithmetic Operator
            //int i = 20, j = 10; //  
            ////Boadmas
            //Console.WriteLine("SUM:"+ (i + j)); //30
            //Console.WriteLine("Substract:"+ (i - j)); //10
            //Console.WriteLine("Mul:"+ (i * j)); // 200
            //Console.WriteLine("Div:"+ (i / j));  // 2
            //Console.WriteLine("Modulus:"+ (i % j)); // 0



            // 2.

            // 3. Unary Operator i++(Post Increment), ++i(Pre Increment), i--(Post Decrement), --i(Pre Decrement)
            //int l = 40;

            //l++; //40
            //--l; // 41-1= 40

            //int k = 2;
            //int result = 10 + k++ * 5;
            //Console.WriteLine(result);
            //Console.WriteLine(k);


            // 4.Conditional or Comparison Operator  < >, <=, >=, ==, !=

            //int a = 30, b = 20;

            //Console.WriteLine(a > b); // true
            //Console.WriteLine(a < b); // false
            //Console.WriteLine(a >= b); // true
            //Console.WriteLine(a <= b); // false
            //Console.WriteLine(a == b); // false
            //Console.WriteLine(a != b); // true


            // 5.Logical Operator  &&(AND), ||(OR), !(NOT)
            // &&(AND) operator
            // 1. If both (all) condition is true then it will return true otherwise false.
            // 2. if first condition is true then it will check the second condition and second condition is true then
            // it will return true else false.
            // 3. If first condition is false then it will not check the second condition and it will return false.

            // int a = 30, b = 20;
            //Console.WriteLine( a > b && b <= a); // true
            //Console.WriteLine( a <= b && b == a); // false
            //Console.WriteLine( a != b && b == a); // false
            //Console.WriteLine( a >= b && b <= a); // true


            // ||(OR) operator
            // 1. if any condition is true then it will return true.
            // 2. if first condition is true then it will not check the second condition and it will return true.
            // 3. if first condition is false then it will check the second condition and if second condition is true then it will return true otherwise false.

            //int a = 30, b = 20;
            //Console.WriteLine(a > b  || b <= a); // true
            //Console.WriteLine(a <= b || b == a); // false
            //Console.WriteLine(a != b || b == a); // true
            //Console.WriteLine(a >= b || b <= a); // true


            //!(NOT)
            // 1. If condition is true then it will return false.
            //int a = 30, b = 20;
            //Console.WriteLine(!(a > b && b <= a)); // false     
            //Console.WriteLine(!(a <= b && b == a)); // true   
            //Console.WriteLine(!(a != b && b == a)); // true   
            //Console.WriteLine(!(a >= b && b <= a)); // false   


            //  6. Ternary Operator  condition ? true : false ( If and Else)
            int a = 30;
            int b = 20;
            //var result = a < b ? "Yes, This is true" : "No, This is false";

            //int result = a < b ? a : b;
            //string result = a < b ? a.ToString() : b.ToString();
            //string result1 = a < b ? Convert.ToString(500) : Convert.ToString(1000);
            //string result2 = a < b ? "500" : "1000";

            int result = !(a > b || b <= a) ? 850 : 1250; 
            Console.WriteLine("result :" + result); 
            Console.ReadKey();
        }
    }
}
