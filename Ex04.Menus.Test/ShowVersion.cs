﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowVersion : Interfaces.IRunnable
    {
        void Interfaces.IRunnable.Run()
        {
            Console.Clear();
            Console.WriteLine("Version: 21.1.4.8930");
            Console.WriteLine("\nPress any key to go back...");
            Console.ReadLine();
        }
    }
}
