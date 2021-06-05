using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem 
    {
        protected readonly List<ISelectedListener> m_SelectedListeners = new List<ISelectedListener>();
        protected string m_Title;
        protected SubMenu m_Father;
       
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

        public SubMenu Father
        {
            get
            {
                return m_Father;
            }

            set
            {
                m_Father = value;
            }
        }

        public MenuItem(string i_Title)
        {
            this.m_Title = i_Title;
        }

        public void AddListener(ISelectedListener i_SelectedListener)
        {
            this.m_SelectedListeners.Add(i_SelectedListener);
        }

        public void RemoveListener(ISelectedListener i_SelectedListener)
        {
            this.m_SelectedListeners.Remove(i_SelectedListener);
        }

        public abstract void OnSelected();
    }
}
