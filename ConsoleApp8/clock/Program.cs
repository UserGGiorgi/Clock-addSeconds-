using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            
            Console.WriteLine("Enter Hours:");
            clock.Hour=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Minutes:");
            clock.Minute = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Seconds:");
            clock.Second = int.Parse(Console.ReadLine());


            
           
            Console.Write("Entered");
            clock.currentTime();

            clock.addSeconds(4);
            Console.Write("New");
            clock.currentTime();

            clock.addSeconds(7);
            Console.Write("New(2)");
            clock.currentTime();


            Console.ReadKey();
        }
    }
}
