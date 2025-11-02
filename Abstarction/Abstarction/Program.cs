using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarction
{
    //abstarction using abstract keyword
    abstract public class Potato { 
        public abstract void Cook();
    }
    public class Curry : Potato
    {
        //override method from abstract class , override keyword is compulsory
        public override void Cook()
        {
                       Console.WriteLine("Curry Potato is Cooked");
        }
    }
    public class Fries : Potato {
        public override void Cook()
        {
           Console.WriteLine("Fries Potato is Cooked");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Curry c = new Curry();
            c.Cook();
        }
    }
}
