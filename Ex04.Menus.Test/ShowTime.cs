﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class ShowTime : Interfaces.IRunnable, Delegates.IRunnable
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine("Press any key to go back");
            Console.ReadLine();
        }
    }
}
