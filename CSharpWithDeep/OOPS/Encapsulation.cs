using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep.OOPS
{
    public class BankAccount
    {
        private double balance; // hidden

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;  //balance + amount
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
    public class MyClass : BankAccount
    {
        static void Main(string[] args)
        {
            var obj = new MyClass();
            obj.GetBalance();
        }
    }
}
