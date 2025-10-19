using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    /// <summary>
    ///  Declartion
    ///  Initialization
    ///  const int number = 100; (here number is Declartion and 100 value is Initialization)
    /// </summary>
    class Const_ReadOnly
    {
        // Const And ReadOnly

        readonly string name; 
        const double pi = 3.14; // never changeable
        readonly int magicNumber = 100; // can be changeable in constructor only

      


        // Syntax of creation of constructor
        // modifier ClassName(){}
        // Shortcut ctor => Tab 1 times
        public Const_ReadOnly()
        {
            magicNumber = 150;
        }

        // Const -
        // 1.Whenever you will create a const variable that time you will have to assign a value. 
        // 2. Const value will be never changed when it has defined.

        // ReadOnly - 
        // 1. Readonly field you can declare with value or without value. 
        // 2. Readonly value will be only allowed to change in constructor not anywhere else.
        // 3. Readonly can be accessed only in the class or method.
        void DemoConst()
        {
            
            const int a = 10;
            Console.WriteLine("The readonly value is "+ magicNumber);
            Console.WriteLine("The const value is "+ pi);
        }

        static void Main(string[] args)
        {
            //pi = 3.145;
            var name = "Stringadfadfasd";
           
            Const_ReadOnly obj = new Const_ReadOnly();
            
            obj.DemoConst();
            Console.ReadKey();
        }
    }
}
