using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{

    internal class Program
    {
        static void even()
        {
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
                Thread.Sleep(500); //for waiiting 500 milliseconds
            }
        }
        static void odd()
        {
            for (int i = 1; i < 10; i += 2)
            {
                Console.WriteLine(i);
                Thread.Sleep(500); //for waiiting 500 milliseconds
            }
        }
        static async Task hello()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Hi");
                await Hi();
            }
        }
        static async Task Hi()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Hello");
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(even));
            Thread t2 = new Thread(new ThreadStart(odd));
            t1.Start(); //starting the thread
            t2.Start();
            t1.Join(); //waiting for the thread to complete its execution
            t2.Join();
           

           
                Task t3 = hello();
                Task t4 = Hi();
                Task.WhenAll(t3, t4).Wait();



            }
        }
    }


