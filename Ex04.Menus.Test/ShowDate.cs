using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowDate : Interfaces.IRunnable
    {
        void Interfaces.IRunnable.Run()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToString("dddd, MMM dd yyyy"));
            Console.WriteLine("Press any key to go back");
            Console.ReadLine();
        }
    }
}
