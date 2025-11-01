using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SetGet
{
    public class Fruits {
        string name;
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        public string name2 { get; set; } = "Banana"; //auto-implemented property

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Fruits fruit = new Fruits();
            Console.WriteLine(fruit._name = "Mango"); //using setter and getter
            Console.WriteLine(fruit.name2); //using auto-implemented property

        }
    }
}
