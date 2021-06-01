using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : SubMenu, ISelectedListener
    {
        public readonly List<MenuItem> m_MenuItems = new List<MenuItem>();
        public MenuAction m_ExitMenuItem = new MenuAction();
        private MenuItem m_CurrentMenuItem;

        public MainMenu()
        {
            this.Father = null;
            this.AddMenuItem(this.m_ExitMenuItem);
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            i_MenuItem.AddListener(this as ISelectedListener);
            
        }

        public void ItemClick(SubMenu i_MenuItem)
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

        public void PreformTask(SubMenu i_MenuItem)
        {
            throw new NotImplementedException();
        }
    }
}