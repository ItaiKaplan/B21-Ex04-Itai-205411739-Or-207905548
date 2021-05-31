using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private string m_Title;

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
 
        private readonly List<SelectedListener> m_ClickListeners = new List<SelectedListener>();


        public MenuItem()
        {
            //if(!this.IsAction)
            //{
            //    MenuItem Back = new MenuItem();
            //    Back.AttachObserver(this as PressedObserver);
            //    this.MenuItems.Add(Back);
            //}
        }
        public void AddListener(SelectedListener i_PressedObserver)
        {
            m_ClickListeners.Add(i_PressedObserver);
        }

        public void RemoveListener(SelectedListener i_PressedObserver)
        {
            m_ClickListeners.Remove(i_PressedObserver);
        }

        OnClick()
        {

        }
    }
}
