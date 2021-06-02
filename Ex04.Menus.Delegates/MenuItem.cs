﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        protected string m_Title;
        protected SubMenu m_Father;
        public event Action<MenuItem> SelectedDelgates;  

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

        public abstract void OnSelected();
    }
}
