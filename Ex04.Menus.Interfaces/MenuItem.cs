using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private string m_Title;
        private readonly List<MenuItem> m_MenuItems;
        private readonly List<SelectedListener> m_SelectedListeners = new List<SelectedListener>();

        public string Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }

        public List<SelectedListener> SelectedListeners
        {
            get
            {
                return m_ClickListeners;
            }
        } 

        public List<MenuItem> MenuItems
        {
            get
            {
                return m_MenuItems;
            }
        }
 

        public MenuItem()
        {
        }

        public void AddListener(SelectedListener i_PressedObserver)
        {
            m_ClickListeners.Add(i_PressedObserver);
        }

        public void RemoveListener(SelectedListener i_PressedObserver)
        {
            m_ClickListeners.Remove(i_PressedObserver);
        }

        private void notifySelectedListener()
        {
            
        }

        public void OnClick()
    }
}
