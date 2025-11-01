using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Encapsulation
//Bank Account Security
/*Balance should never be directly accessed.

Provide Deposit(amount) and Withdraw(amount) methods.

Withdraw only if balance is enough.

Show balance using method only, not by accessing variable.*/

namespace Encapsulation
{
    class BankAccount {
        private float balance;
        public BankAccount(float balance) {
            this.balance = balance;
        }
        public float GetBalance()
        {
            return balance;
        }

        public void Deposit(float amt)
        {
            if (amt == null)
            {
                Console.Write("Invalid amount");
            }
            else
            {
                balance += amt;
            }
        }
        public void Withdraw(float amt)
        {
            if (amt > balance)
            {
                Console.Write("Insufficient balance");
            }
            else
            {
                Console.WriteLine("Withdrawal successful of amount "+amt);
                balance = balance - amt;
                Console.Write("Remaining balance is "+balance);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba= new BankAccount(5000);
            ba.Deposit(2000);
            ba.Withdraw(1000);
        }
    }
}
