﻿using System;

namespace Ex04.Menus.Test
{
    internal class CountSpaces : Interfaces.IRunnable
    {
        public void Run()
        {
            string userInput;
            int numberOfSpaces = 0;

            Console.Clear();
            Console.WriteLine("Please enter a sentence");
            userInput = Console.ReadLine();
            numberOfSpaces = countNumberOfSpaces(userInput);
            Console.WriteLine($"The sentence you've entered is: \"{userInput}\",");
            Console.WriteLine($"There are {numberOfSpaces} spaces in it.");
            Console.WriteLine($"{Environment.NewLine}Press any key to go back...");
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