using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.Method_Types
{
    // All the partial class definitions must be in the same assembly and namespace.
    // The declaration of the partial method must begin with partial modifier. 
    // If any part is declare abstract, sealed or base type then the whole class is declared of the same type. 

    // The partial method does not contain out parameters. 
    // It is implicitly private method. 
    // It can be a static method. 
    // It can have only void return type. 
    // Partial methods are implicitly private methods, so cannot be virtual. 
    // A partial method is created only in partial class or in partial struct. 
    // All the parts must have the same accessibility like public or private, etc..

    // There are several situations when splitting a class definition is desirable: 
    // 1. When working on large projects, spreading a class over separate files enables multiple programmers to work on it at
    // the same time.

    partial class Company
    {
        partial void CalculateEmployeeSlarayOne();

        partial void CalculateEmployeeLeaveTwo();

        partial void CalculateYearlyHolidayThree();

        partial void CalculateEmployeeSlarayOne()
        {
            Console.WriteLine("I am partial method CalculateEmployeeSlarayOne");
        }
        static void Main()
        {
            var obj = new Company();
            obj.CalculateEmployeeSlarayOne();
            obj.CalculateEmployeeLeaveTwo();
            obj.CalculateYearlyHolidayThree();

            Console.ReadKey();
        }
    }
}
