using System;
using System.Threading;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : ISelectedListener
    {
        private readonly SubMenu m_MainMenu = new SubMenu("Main Menu", "Exit");
        private MenuItem m_CurrentMenuItem;

        public SubMenu Main
        {
            get
            {
                return this.m_MainMenu;
            }
        }

        public MenuItem CurrentMenuItem
        {
            get
            {
                return m_CurrentMenuItem;
            }

            set
            {
                m_CurrentMenuItem = value;
            }
        } 

        public MainMenu()
        {
            this.CurrentMenuItem = Main;
            this.Main.AddListener(this);
        }

        public void Show()
        {
            bool exitFlag = false;
            while(!exitFlag)
            {
                (this.CurrentMenuItem as SubMenu).RunMenu(out exitFlag);
            }

            Console.WriteLine("Exiting Interface Implementation");
            Thread.Sleep(1000);
        }

        public void OnSelect(SubMenu i_SubMenu)
        {
            this.CurrentMenuItem = i_SubMenu;
        }
    }
}