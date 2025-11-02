using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating list
            List<int> numbers = new List<int>();
            //adding elements
            for(int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }
            //finding elements
            if(numbers.Contains(5))
            {
                Console.WriteLine("5 is found in the list at: "+numbers.IndexOf(5));
            }
            //foreach for printing elements
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
