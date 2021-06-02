using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu 
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
            this.CurrentMenuItem = m_MainMenu;
            this.m_MainMenu.m_SelectedDelegates += this.OnSelect;
        }

/*        private void selectAll(SubMenu i_SubMenu)
        {
            foreach(MenuItem item in Main.MenuItems)
            {
                if((item as SubMenu).MenuItems.Count > 0)
                {
                    selectAll(item as SubMenu);
                }
                item.SelectedDelgates += this.OnSelect();
            }
        }*/

        public void Show()
        {
            while(true)
            {
                this.CurrentMenuItem.RunItem();
            }

        }

        public void OnSelect(MenuItem i_SubMenu)
        {
            this.CurrentMenuItem = i_SubMenu;
        }
    }
}
