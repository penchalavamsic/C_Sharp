using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //base class
    public class Animal {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }    
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Eat(); //Inherited method
            d.Bark(); //Own method
        }
    }
}
