using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.Method_Types
{

    // For you reference : https://www.c-sharpcorner.com/UploadFile/93126e/importance-and-use-of-versioning-in-C-Sharp/4


    // Point: 1 => Whenever you will create abstract method that abstract method must be inside
    // the abstract class.
    // Point : 4 =>  Abstract method will not get a body. You can only declare.
    // Point : 3 => Because abstract class contains abstract as well as non-abstract method like( static, non-static and 
    //virtual etc).
    //Point : 5 => If you want to use the abstract method then you will have to inherit abstract class with non-abstract class.
    //Point : 6 => When inheritance is done then you will have to provide the body of all the abstract methods of the
    // abstract class.
    //Point : 7 => You can't access any members of the abstract class except static method.
    //Point : 8 => Because you can't create the instance of abstract class.
    public abstract class Abstract  // abstract class
    {
        public abstract void AbstractMethod();
        public abstract void AnotherAbstractMethod();

        public static void StaticMethod()
        {
            Console.WriteLine("Static Method inside the abstract class");
        }
        public void NonStaticMethod()
        {
            Console.WriteLine("Non Static Method inside the abstract class");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Virtual method inside the abstract class");
        }
    }

    public class NonAbstract : Abstract
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("This is the first abstract method body");
        }
        public override void AnotherAbstractMethod()
        {
            Console.WriteLine("This is the second abstract method body");
        }
        public override void VirtualMethod()
        {
            Console.WriteLine("Virtual method inside the NonAbstract class");
        }
        public void NonStaticMethod()
        {
            Console.WriteLine("Non Static Method inside the abstract class");
        }
        static void Main()
        {
            //var obj = new Abstract(); // can't create an instace 0f the abstract class.
            var nonAbstract = new NonAbstract();
            nonAbstract.AbstractMethod();
            nonAbstract.AnotherAbstractMethod();
            Abstract.StaticMethod();
            nonAbstract.NonStaticMethod();
            nonAbstract.VirtualMethod();

            Console.ReadKey();
        }
    }
}
