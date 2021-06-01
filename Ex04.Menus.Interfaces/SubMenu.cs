using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
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
 
        public SubMenu(string i_Title, SubMenu i_Father, string i_BackOptionName) : base(i_Title, i_Father)
        {
            this.m_MenuItems = new List<MenuItem>();
            this.r_BackOptionName = i_BackOptionName;
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            this.m_MenuItems.Add(i_MenuItem);
            i_MenuItem.Father = this;
            foreach (ISelectedListener listener in this.m_SelectedListeners)
            {
                i_MenuItem.AddListener(listener);
            }
        }

        public void RemoveMenuItem(MenuItem i_MenuItem)
        {
            this.m_MenuItems.Remove(i_MenuItem);
            i_MenuItem.Father = null;
        }

        public void OnSelected()
        {
            this.notifyAllSelectedListener();
        }

        private void notifyAllSelectedListener()
        {
            foreach(ISelectedListener listener in this.m_SelectedListeners)
            {
                listener.OnSelect(this);
            }
        }

        public void RunMenu()
        {
            string userInputString;
            int userInput;
            bool isInputValid = false;

            Console.WriteLine(this.ToString());

        }
        public override string ToString()
        {
            StringBuilder menuDisplay = new StringBuilder($"0. {this.r_BackOptionName}\n");
            int i = 1;
            foreach(MenuItem item in this.m_MenuItems)
            {
                menuDisplay.Append($"{i++}. {item.Title}\n");
            }

            return menuDisplay.ToString();
        }
    }
}
