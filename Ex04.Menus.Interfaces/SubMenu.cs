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
 
        


        public SubMenu()
        {
  
        }


        public void PreformTask(SubMenu i_MenuItem)
        {
            throw new System.NotImplementedException();
        }

        SubMenu()
        {

        }
    }
}
