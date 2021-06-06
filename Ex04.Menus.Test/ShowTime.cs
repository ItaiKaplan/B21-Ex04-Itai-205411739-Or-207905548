using System;

namespace Ex04.Menus.Test
{
    public class ShowTime : Interfaces.IRunnable
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("The time is:");
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine($"{Environment.NewLine}Press any key to go back...");
            Console.ReadLine();
        }
    }
}
