﻿using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : ISelectedListener
    {

        private readonly SubMenu m_MainMenu = new SubMenu("Main Menu", "Exit");
        private MenuItem m_CurrentMenuItem;

        public SubMenu Main
        {
            get
            {
                return this.m_MainMenu;
            }
        }

        public MenuItem CurrentMenuItem
        {
            get
            {
                return m_CurrentMenuItem;
            }
            set
            {
                m_CurrentMenuItem = value;
            }
        } 

        public MainMenu()
        {
            this.CurrentMenuItem = Main;
            this.Main.AddListener(this);
        }

        public void Show()
        {
            while(true)
            {
                (this.CurrentMenuItem as SubMenu).RunMenu();
            }
        }

        public void OnSelect(SubMenu i_SubMenu)
        {
            this.CurrentMenuItem = i_SubMenu;
        }
    }
}