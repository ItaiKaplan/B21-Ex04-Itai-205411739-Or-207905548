using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    { 
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

        public SubMenu(string i_Title, SubMenu i_Father) : base(i_Title, i_Father) {

            this.m_MenuItems = new List<MenuItem>();
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
    }
}
