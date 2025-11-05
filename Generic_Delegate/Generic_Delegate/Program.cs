using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate
//even or odd with generic delegate
{
    internal class Program
    {
        public delegate void Mydelegate<T>(T a); //even or odd with generic delegate
        public static void EvenorOdd(int b)
        {
            if(b % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
        static void Main(string[] args)
        {
            Mydelegate<int> del = EvenorOdd; //assigning method to delegate
            del(5); //calling delegate

        }
    }
}
