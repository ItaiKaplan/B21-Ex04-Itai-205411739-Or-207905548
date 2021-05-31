using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : PressedObserver
    {
        public readonly List<MenuItem> m_MenuItems = new List<MenuItem>();
        public MenuItem m_ExitMenuItem = new MenuItem();
        private MenuItem m_CurrentMenuItem;

        public MainMenu()
        {
            this.AddMenuItem(this.m_ExitMenuItem);
        }
        public void PreformTask(MenuItem i_MenuItem)
        {
            throw new NotImplementedException();
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            i_MenuItem.AddListener(this as PressedObserver);
            this.m_MenuItems.Add(i_MenuItem);
        }

        public void ItemClick(MenuItem i_MenuItem)
        {
            this.m_CurrentMenuItem = i_MenuItem;
        }

        public void ShowMenu()
        {
            while(this.m_CurrentMenuItem != this.m_ExitMenuItem)
            {
                if(this.m_CurrentMenuItem.isAction)
                {
                    RunMenuItemFunction(this.m_CurrentMenuitem);
                }
                DisplayMenuItem(this.m_CurrentMenuItem);
            }
        }
    }
}