using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //interface
    public interface  ICar
    {
        void Company();
    }
    //not need to write override keyword
    //multiple interface inheritance is possible
    public class Name : ICar
    {
               public void Company()
        {
            Console.WriteLine("BMW");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Name n = new Name();
            n.Company();
           
        }
    }
}
