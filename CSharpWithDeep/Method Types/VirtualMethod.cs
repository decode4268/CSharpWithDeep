using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class VirtualMethod
    {
        // Follow this link and make the program accordingly : 
        //https://www.c-sharpcorner.com/UploadFile/3d39b4/virtual-method-in-C-Sharp/


        // Family (Father, Mother, You, Wife, Childrens) - Education 
        // Company (IT, Sales, Finance, HR) - Salary, Policy
        // Car  (Baleno, Alto, Desire) - FuelTank, Tier

        // Virtual Keyword is use in Base Class 
        //

        class Family
        {
            public virtual void Education( string name)
            {
                Console.WriteLine("B. Tech Degree"); // It is known as Method Implementation or Signarture 
            }
        }
        class Father : Family
        {
            public override void Education(string name)
            {
                Console.WriteLine("Graduation Degree");
            }
        }
        class Mother : Family
        {
            public override void Education(string name)
            {
                Console.WriteLine("Post Graduation Degree");
            }
        }
        class Son : Family
        {
            public override void Education(string name)
            {
                Console.WriteLine("BE Degree");
            }
        }

        static void Main()
        {
            var family = new Family();
            family.Education("Test");

            var father = new Father();
            father.Education("Test");

            var mother = new Mother();
            mother.Education("Test");

            var son = new Son();
            son.Education("Test");


            Console.ReadKey();
        }
    }
}
