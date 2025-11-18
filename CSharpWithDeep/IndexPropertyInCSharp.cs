using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Company
    {
        List<Employee> empList;
        public Company()
        {
            empList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "David", Age = 35},
                new Employee() {Id = 2, Name = "DeepRaj", Age = 25},//Deepraj
                new Employee() {Id = 3, Name = "Govind", Age = 27},
                new Employee() {Id = 4, Name = "Divyanshu", Age = 26},
            };
        }

        // Id = 1, Name = "David" // Get
        // Id = 1, Name = "David Test " // Set

        // Indexer Properties
        public string this[int Id]
        {
            get
            {
                string name = string.Empty;
                //return empList.Where(e => e.Id == Id).FirstOrDefault().Name;
                var data = empList.FirstOrDefault(e => e.Id == Id) != null ? empList.FirstOrDefault(e => e.Id == Id).Name : "No data found!";
                //if (empList.FirstOrDefault(e => e.Id == Id) != null)
                //{
                //    name = empList.FirstOrDefault(e => e.Id == Id).Name;
                //}
                //else
                //{
                //    name = "No data found!";

                //}
                return name;
            }
            set
            {
                empList.FirstOrDefault(e => e.Id == Id).Name = value;
            }
        }
        public int this[string Name]
        {
            get
            {
                //return empList.Where(e => e.Id == Id).FirstOrDefault().Name;
                return empList.FirstOrDefault(e => e.Name.ToLower() == Name.ToLower()).Age; // lambda expression (e => e.Name == Name)
            }
            set
            {
                empList.FirstOrDefault(e => e.Name.ToLower() == Name.ToLower()).Age = value;
            }
        }

        static void Main()
        {
            var obj = new Company();     // constructor has called on obj creation of the class.

            obj["deepRaj"] = 22;
            Console.WriteLine(obj["deepRaj"]);
            //Console.WriteLine(obj[10]);

            //obj[1] = "David Test";
            //Console.WriteLine(obj[1]);
            Console.ReadKey();
        }
    }
}
