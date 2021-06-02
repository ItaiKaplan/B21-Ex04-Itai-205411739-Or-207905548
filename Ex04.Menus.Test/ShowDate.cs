using Ex04.Menus.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowDate : Interfaces.IRunnable, Delegates.IRunnable
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Today is:");
            Console.WriteLine(DateTime.Now.ToString("dddd, MMM dd yyyy"));
            Console.WriteLine("\nPress any key to go back...");
            Console.ReadLine();
        }
    }
}
