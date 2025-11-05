using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCast_Delegate
{
    //multicast delegate
    internal class Program
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int sub(int a, int b)
        {
            return a - b;
        }
        //delegate declaration
        public delegate int mydelegate(int a, int b);
        static void Main(string[] args)
        {
            //delegate instantiation
            mydelegate del = add;
            del += sub;
            int result = del(10, 5);
            Console.WriteLine("Result: " + result);
            }
    }
}
