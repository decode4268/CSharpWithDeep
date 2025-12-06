using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.Polymorphism
{
    //Run time, Late Binding Polymorphism
    /// <summary>
    /// Achieved by method overriding (virtual + override)
    /// Decide at runtime based on the object
    /// Very important in real-time projects
    /// </summary>
    
    class Employee
    {
        int salary = 0;

        public virtual void CalculateSalary()
        {
            Console.WriteLine("General Employee Salary");
        }
    }
    class Developer : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Developer salary Include Bonus + Basic pay");
        }
    }
    class Manager : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Manager salary include incentive + bonus pay");
        }
    }
    public class MainClass
    {
        static void Main()
        {
            //Employee emp = new Employee();
            var emp = new Employee();

            emp = new Developer();
            emp.CalculateSalary();

            emp = new Manager();
            emp.CalculateSalary();

            Console.ReadKey();
        }
    }
}
