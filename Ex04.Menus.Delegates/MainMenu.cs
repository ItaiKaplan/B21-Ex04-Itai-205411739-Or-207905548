namespace Ex04.Menus.Delegates
{
    public class MainMenu 
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
            this.CurrentMenuItem = m_MainMenu;
            this.m_MainMenu.m_SelectedDelegates += this.OnSelect;
        }

        public void Show()
        {
            while(true)
            {
                this.CurrentMenuItem.RunItem();
            }
        }

        public void OnSelect(MenuItem i_SubMenu)
        {
            this.CurrentMenuItem = i_SubMenu;
        }
    }
}
