using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharpWithDeep.CollectionCurd
{
    enum UserChoice
    {
        AddDetails = 1,
        ShowAllDetails = 2,
        SingleDetails = 3,
        UpdateDetails = 4,
        DeleteDetails = 5,
        Exit = 6
    }

    // CURD => Create, Update, Read, Delete
    public class CollectionCurdAppls
    {
        static List<Employee> employessList = null;
        static CollectionCurdAppls()
        {
            employessList = new List<Employee>();
        }
        static void Main()
        {
            Console.WriteLine("Please enter your Choice \n 1-Add Details, \n 2-Show All Details \n " +
                "3-Single Details, \n 4-Update Details \n 5-Delete Details \n 6-Exit");

            int userInput = Convert.ToInt32(Console.ReadLine());

            UserChoice userChoice = (UserChoice)userInput;

            switch (userChoice)
            {
                case UserChoice.AddDetails:
                    var employeeDetails = UserInfoForAdd();
                    Console.WriteLine(SaveEmployeeDetails(employeeDetails));
                    break;
                case UserChoice.ShowAllDetails:
                    ShowAllEmployeeDetails();
                    break;
                case UserChoice.SingleDetails:
                    break;
                case UserChoice.UpdateDetails:
                    break;
                case UserChoice.DeleteDetails:
                    break;
                case UserChoice.Exit:
                    break;
                default:
                    Console.WriteLine("your Choice is wrong");
                    break;
            }
            Console.ReadKey();
        }

        static Employee UserInfoForAdd()
        {
            var employee = new Employee();
            Console.WriteLine("Please Enter employee details");
            Console.WriteLine("Please enter name");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Please enter age");
            employee.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter email");
            employee.EmailId = Console.ReadLine();

            Console.WriteLine("Please enter city");
            employee.City = Console.ReadLine();

            return employee;
        }

        static string SaveEmployeeDetails(Employee employee)
        {
            int maxId = 0;
            foreach (var empInfo in employessList)
            {
                if (maxId < empInfo.Id)
                {
                    maxId = empInfo.Id;
                }
            }
            employee.Id = maxId == 0 ? 1 : maxId + 1; 
            employessList.Add(employee);
            return "Record successfully Save.";
        }

        static void ShowAllEmployeeDetails()
        {
            Console.WriteLine("----------- Please find below all employee Details");
            foreach (var emp in employessList)
            {
                Console.WriteLine("Name: " + emp.Name);
                Console.WriteLine("Age: " + emp.Age);
                Console.WriteLine("Email: " + emp.EmailId);
                Console.WriteLine("City: " + emp.City);
            }
        }

    }
}
