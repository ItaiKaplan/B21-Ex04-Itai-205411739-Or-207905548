using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem 
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

        private SubMenu m_Father;

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

        private readonly List<ISelectedListener> m_ClickListeners = new List<ISelectedListener>();

        public MenuItem(string i_Title, SubMenu i_Father)
        {
            this.Title = i_Title;
            this.Father = i_Father;
        }

        public void AddListener(ISelectedListener i_PressedObserver)
        {
            m_ClickListeners.Add(i_PressedObserver);
        }

        public void RemoveListener(ISelectedListener i_PressedObserver)
        {
            m_ClickListeners.Remove(i_PressedObserver);
        }
    }
}
