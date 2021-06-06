using System;

namespace Ex04.Menus.Test
{
    internal class ShowDate : Interfaces.IRunnable
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Today is:");
            Console.WriteLine(DateTime.Now.ToString("dddd, MMM dd yyyy"));
            Console.WriteLine($"{Environment.NewLine}Press any key to go back...");
            Console.ReadLine();
        }
    }
}
