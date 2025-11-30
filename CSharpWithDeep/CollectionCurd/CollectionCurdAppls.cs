using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharpWithDeep.CollectionCurd
{
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
            bool isItOk = true;
            while (isItOk)
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
                        Console.WriteLine();
                        Console.WriteLine("---------------");
                        break;
                    case UserChoice.ShowAllDetails:
                        ShowAllEmployeeDetails();
                        Console.WriteLine();
                        Console.WriteLine("---------------");
                        break;
                    case UserChoice.SingleDetails:
                        Console.WriteLine(FindSingleEmployeeDetail());
                        Console.WriteLine();
                        Console.WriteLine("---------------");
                        break;
                    case UserChoice.UpdateDetails:
                        break;
                    case UserChoice.DeleteDetails:
                        break;
                    case UserChoice.Exit:
                        isItOk = false;
                        Console.WriteLine("Than you for visiting.");
                        break;
                    default:
                        Console.WriteLine("your Choice is wrong");
                        break;
                }
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
            if (!string.IsNullOrEmpty(employee.EmailId))
            {
                if (IsEmailExist(employee.EmailId))
                {
                    return "Oops! Email Id already exist. Pleae try again with other email Id";
                }
            }
            else
            {
                Console.WriteLine("Kindly enter a email, Email is required");
            }

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
            Console.WriteLine("----------- Please find below all employee Details----------");
            foreach (var emp in employessList)
            {
                Console.WriteLine("Name: " + emp.Name);
                Console.WriteLine("Age: " + emp.Age);
                Console.WriteLine("Email: " + emp.EmailId);
                Console.WriteLine("City: " + emp.City);
            }
        }

        static string FindSingleEmployeeDetail()
        {
            string message = string.Empty;
            Console.WriteLine("Please enter email id");
            string email = Console.ReadLine();
            var employee = SingleEmployeesDetail(email);
            if (employee != null)
            {
                Console.WriteLine("-------------Employee Detail------------------");
                Console.WriteLine("Name: " + employee.Name);
                Console.WriteLine("Age: " + employee.Age);
                Console.WriteLine("Email: " + employee.EmailId);
                Console.WriteLine("City: " + employee.City);
            }
            else
            {
                message = "We did not find any records with this email id";
            }
            return message;
        }

        static Employee SingleEmployeesDetail(string email)
        {
            var employeeFromList = employessList.
                FirstOrDefault(e => e.EmailId.ToLower().Trim() == email.ToLower().Trim());
            if (employessList != null)
            {
                return employeeFromList;
            }
            return null;
        }

        static string GetEmployeeDetailsForUpdate()
        {
            string message = string.Empty;
            Console.WriteLine("Please enter email id");
            string emailId = Console.ReadLine();
            if (!string.IsNullOrEmpty(emailId) && IsEmailExist(emailId))
            {
                var employee = new Employee();
                Console.WriteLine("Please enter name");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Please Enter the age");
                employee.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the city");
                employee.City = Console.ReadLine();
            }
            else
            {
                message = "Email id does not exist into our records";
            }
            return message; 
        }

        #region CommonHelper Method
        static bool IsEmailExist(string emailId)
        {
            bool isEmailExist = false;
            if (!string.IsNullOrEmpty(emailId))
            {
                var employee = employessList.
                    FirstOrDefault(e => e.EmailId.ToLower().Trim() == emailId.ToLower().Trim());
                if (employee == null)
                {
                    isEmailExist = false;
                }
                else
                {
                    isEmailExist = true;
                }
            }

            return isEmailExist;
        }
        #endregion

    }
}
