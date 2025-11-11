using System;
using System.Runtime.CompilerServices;

namespace MyNamespace
{
    enum WeekDays
    {
        Monday ,
        Tuesday,
        Wednesday,
        Friday,
        Saturday,
        Sunday
    }

    struct MyStruct
    {
        int i;
        public MyStruct(int i)
        {
            this.i = i;
        }

        void ShowMessage()
        {
            Console.WriteLine("Method from class");
        }
        static void Main()
        {
            
            MyStruct obj = new MyStruct();
            obj.ShowMessage();

            Console.ReadKey();
        }
    }
}