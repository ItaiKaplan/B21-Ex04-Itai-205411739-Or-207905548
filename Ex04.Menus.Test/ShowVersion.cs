using System;

namespace Ex04.Menus.Test
{
    internal class ShowVersion : Interfaces.IRunnable
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Version: 21.1.4.8930");
            Console.WriteLine("\nPress any key to go back...");
            Console.ReadLine();
        }
    }
}
