using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    //Interface in C#
    // 1- Whenever you want to create a interface you will have to use interface keyword to create it.
    // 2- Always keep 'I' as a prefix with the interface as a naming convention.
    // 3- It's contract which other types (Class which is using this interface) will have to follow that contract.
    // 4 - All the interface members will be by default public.
    // 5- No need to use any access speicifier their. 
    // 6- You can only declare members inside the interface.
    // 7- You can declare members like property, method delegate, event. 
    // 8- All the members of the interface will be fully abstract. 
    // 9- If you want to use this interface, you will have to inherit it with the class. 
    // 10- When inheritence will be done that time you will have to provie the body of all the members which has
    // been declared inside the interface.
    // 11- When you will provide the body of the interface members that time you will have to use access specifier
    // public.
    // 12 - We can't create the instance of object of interface.
    // 13 - In C#, multiple inheritance is not allowed but with the help of interface it is possible.

    // Note : It is generally used in Repository Design Pattern..

    interface ICar
    {
        void CarFeatures();
        string CarMusicInfo();
        int CarMileage();
    }


    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Deafult ctor is called of my class");
        }
        public void PrintMsg()
        {
            Console.WriteLine("Dummy msg");
        }
    }

    // Multiple Inheritance
    public class MyClass2 : MyClass , ICar
    {
        public void CarFeatures()
        {
            Console.WriteLine("Car Feature");
        }

        public int CarMileage()
        {
            Console.WriteLine("Car Mileage");
            return 0;
        }

        public string CarMusicInfo()
        {
            Console.WriteLine("Car Music Info");
            return string.Empty;
        }
    }
    public class InterfaceInCSharp : ICar
    {


        public void CarFeatures()
        {
            Console.WriteLine("Car Feature");
        }

        public int CarMileage()
        {
            Console.WriteLine("Car Mileage");
            return 0;
        }

        public string CarMusicInfo()
        {
            Console.WriteLine("Car Music Info");
            return string.Empty;
        }

        static void Main(string[] args)
        {
            //ICar obj = new ICar(); // cannot create..

            InterfaceInCSharp obj = new InterfaceInCSharp();
            obj.CarFeatures();
            obj.CarMileage();
            obj.CarMusicInfo();
        }
    }
}
