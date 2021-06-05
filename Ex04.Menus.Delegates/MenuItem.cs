using System;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        protected string m_Title;
        protected SubMenu m_Father;

        public event Action<MenuItem> m_SelectedDelegates;  

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

        public virtual void OnSelected()
        {
            this.m_SelectedDelegates?.Invoke(this);
        }

        public abstract void RunItem();
    }
}
