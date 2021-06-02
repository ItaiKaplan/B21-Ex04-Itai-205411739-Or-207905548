using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private readonly string r_BackOptionName;
        private List<MenuItem> m_MenuItems;


        public List<MenuItem> MenuItems
        {
            get
            {
                return m_MenuItems;
            }
            set
            {
                m_MenuItems = value;
            }
        }

        public SubMenu(string i_Title, string i_BackOptionName) : base(i_Title)
        {
            this.m_MenuItems = new List<MenuItem>();
            this.r_BackOptionName = i_BackOptionName;
        }

        public void AddMenuItem(MenuItem i_MenuItem, Action<MenuItem> i_OnSelectHandler)
        {
            this.MenuItems.Add(i_MenuItem);
            i_MenuItem.Father = this;
            i_MenuItem.m_SelectedDelegates += i_OnSelectHandler;
        }

        public void RemoveMenuItem(MenuItem i_MenuItem, Action<MenuItem> i_OnSelectHandler)
        {
            this.MenuItems.Remove(i_MenuItem);
            i_MenuItem.Father = null;
            i_MenuItem.m_SelectedDelegates -= i_OnSelectHandler;
        }



        public override void RunItem()
        {
            int userInput;
            Console.Clear();
            Console.WriteLine(this.ToString());
            userInput = getValidUserInput();
            if(userInput == 0)
            {
                if(this.Father == null)
                {
                    Environment.Exit(0);
                }
                this.Father.OnSelected();
            }
            else
            {
                this.MenuItems[userInput - 1].OnSelected();
            }
        }

        private int getValidUserInput()
        {
            string userInputString;
            int userInput = 0;
            bool isInputValid = false;

            while(!isInputValid)
            {
                Console.WriteLine("Please Select Option");
                userInputString = Console.ReadLine();
                isInputValid = validateInput(userInputString, out userInput);
                if(!isInputValid)
                {
                    Console.WriteLine("Invalid Input\n");
                }
            }

            return userInput;
        }

        private bool validateInput(string i_UserInputString, out int io_UserInput)
        {
            bool isInputValid = false;
            ;

            isInputValid = int.TryParse(i_UserInputString, out io_UserInput);
            if(isInputValid)
            {
                if(io_UserInput < 0 || io_UserInput > this.MenuItems.Count)
                {
                    isInputValid = false;
                }
            }

            return isInputValid;
        }

        public override string ToString()
        {
            StringBuilder menuDisplay = new StringBuilder($"{this.Title} - Delegates\n\n");
            int i = 1;

            menuDisplay.Append($"0. {this.r_BackOptionName}\n");
            foreach(MenuItem item in this.MenuItems)
            {
                menuDisplay.Append($"{i++}. {item.Title}\n");
            }

            return menuDisplay.ToString();
        }
    }
}
