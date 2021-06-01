using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class ShowTime : Interfaces.IRunnable
    {
        void Interfaces.IRunnable.Run()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Thread.Sleep(1000);
        }
    }
}
