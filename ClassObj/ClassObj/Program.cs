using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObj
{
    public class Car {
        public string name()
        {
            string a = "Benz";
            return a;
        }
        public string name1{set; get;}="BMW"; 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myobj = new Car();
            Console.WriteLine(myobj.name()); //accesing method name from class Car
            Console.WriteLine(myobj.name1); //accesing property name1 from class Car
        }
    }
}
