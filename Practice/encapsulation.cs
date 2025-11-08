//encapsulation
using System;

namespace Encapsulation{
    public class BankAccount{
        private double balance;
        public float deposit(float amount){
            balance=balance+amount;
            return balance;
        }
        public double Withdraw(double amount){
            
            balance=balance-amount;
            return balance;
        }
        public double GetBalance(){
            return balance;
        }
    }

class Program
{
    static void Main(string[] args){
        BankAccount b=new BankAccount();
        Console.WriteLine(b.deposit(1000));
        Console.WriteLine(b.Withdraw(500));
        Console.WriteLine(b.GetBalance());

    }
}

}
    