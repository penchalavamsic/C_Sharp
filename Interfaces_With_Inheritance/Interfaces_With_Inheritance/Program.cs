using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_With_Inheritance
{
    //simple implementation of interfaces
    internal class Program
    {
        interface circle {
            void areaC(double r);
                   
        }
        interface triangle {
            void areaT(double b, double h);
        }
        //multiple inheritance
        public class shapes : circle, triangle
        {   
            public void  areaC(double r)
            {
                Console.WriteLine("Area of circle is "+3.14*r*r);
            }
            public void areaT(double b, double h)
            {
                 Console.WriteLine("Area of triangle is "+1/2*b*h);
            }

        }
        

        static void Main(string[] args)
        {
            shapes s = new shapes();
            Console.WriteLine("Enter radius");
            double a = int.Parse(Console.ReadLine());
            s.areaC(a);
            Console.WriteLine("Enter base and height");
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            s.areaT(b, c);

        }
    }
}
