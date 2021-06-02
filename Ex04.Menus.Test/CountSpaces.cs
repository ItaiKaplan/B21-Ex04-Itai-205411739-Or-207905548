using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class CountSpaces : Interfaces.IRunnable
    {
        void Interfaces.IRunnable.Run()
        {
            string userInput;
            int numberOfSpaces = 0;

            Console.Clear();
            Console.WriteLine("Please enter a sentence");
            userInput = Console.ReadLine();
            numberOfSpaces = countNumberOfSpaces(userInput);
            Console.WriteLine($"There are {numberOfSpaces} spaces in this sentence.");
            Console.WriteLine("Press any key to go back");
            Console.ReadLine();
        }

        private int countNumberOfSpaces(string userInput)
        {
            int numberOfSpaces = 0;

            foreach(char character in userInput)
            {
                if(character == ' ')
                {
                    numberOfSpaces++;
                }
            }

            return numberOfSpaces;
        }
    }
}