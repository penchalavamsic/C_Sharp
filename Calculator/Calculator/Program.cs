using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    internal class Program
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int subtract(int a, int b)
        {
            return a - b;
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
        public static int divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return a / b;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Enter first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose an operation: 1.Addition\n 2.Subraction\n3.Multiplication\n4Division");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result: " + add(a, b));
                    break;
                case 2:
                    Console.WriteLine("Result: " + subtract(a, b));
                    break;
                case 3:
                    Console.WriteLine("Result: " + multiply(a, b));
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Result: " + divide(a, b));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }


    }
}