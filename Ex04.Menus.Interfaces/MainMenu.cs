using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : ISelectedListener
    {
        private class ExitItem : IRunnable
        {
            void IRunnable.Run()
            {
                Environment.Exit(0);
            }
        }

        private readonly SubMenu m_MainMenu = new SubMenu("Main Menu", null, "exit");
        private MenuItem m_CurrentMenuItem;

        public MainMenu()
        {
            this.m_CurrentMenuItem = m_MainMenu;
        }

        public void Show()
        {
            while(userInput != 0)
            {
                Console.WriteLine(this.m_CurrentMenuItem.ToString());
                (this.m_CurrentMenuItem as SubMenu).RunMenu();
            }
        }


        /*        public readonly List<MenuItem> m_MenuItems = new List<MenuItem>();
                public MenuAction m_ExitMenuItem = new MenuAction();
                private MenuItem m_CurrentMenuItem;

                public MainMenu()
                {
                    this.Father = null;
                    this.AddMenuItem(this.m_ExitMenuItem);
                }

                public void AddMenuItem(MenuItem i_ChildMenuItem)
                {
                    i_MenuItem.Father = this;
                    i_MenuItem.AddListener(this as ISelectedListener);
                    this.m_MenuItems.Add(i_MenuItem);
                }

                public void ItemClick(SubMenu i_MenuItem)
                {
                    this.m_CurrentMenuItem = i_MenuItem;
                }

                public void ShowMenu()
                {
                    while (this.m_CurrentMenuItem != this.m_ExitMenuItem)
                    {
                        if (this.m_CurrentMenuItem.isAction)
                        {
                            RunMenuItemFunction(this.m_CurrentMenuitem);
                        }
                        DisplayMenuItem(this.m_CurrentMenuItem);
                    }
                }

                public void PreformTask(SubMenu i_MenuItem)
                {
                    throw new NotImplementedException();
                }*/
        public void OnSelect(SubMenu i_SubMenu)
        {
            this.m_CurrentMenuItem = i_SubMenu;
        }
    }
}