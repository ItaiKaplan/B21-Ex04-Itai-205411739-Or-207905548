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
            Console.WriteLine(DateTime.Now.ToString("dddd , MMM dd yyyy"));
            Thread.Sleep(1000);
        }
    }
}
