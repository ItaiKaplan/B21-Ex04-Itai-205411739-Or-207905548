using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {

        private List<SubMenu> m_MenuItems;

        public List<SubMenu> MenuItems
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

        public SubMenu(string i_Title, SubMenu i_Father) : base(i_Title, i_Father)
        {
            this.MenuItems = new List<SubMenu>();

        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            i_MenuItem.Father = this;
            this.MenuItems.Add(i_MenuItem);
        }
    }
}
