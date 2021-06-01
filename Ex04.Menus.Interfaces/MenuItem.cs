using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem 
    {
        protected string m_Title;
        protected SubMenu m_Father;
        protected readonly List<ISelectedListener> m_SelectedListeners = new List<ISelectedListener>();

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
