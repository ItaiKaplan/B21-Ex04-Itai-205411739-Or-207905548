namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            runInterfacesMenu();
            runDelegatesMenu();

        }

        private static void runInterfacesMenu()
        {
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu();

            Interfaces.SubMenu firstMenu = new Interfaces.SubMenu("Version And Spaces", "Back");
            Interfaces.SubMenu secondMenu = new Interfaces.SubMenu("Date and Time", "Back");
            mainMenu.Main.AddMenuItem(firstMenu);
            mainMenu.Main.AddMenuItem(secondMenu);


            //firstMenu.AddListener(mainMenu);
            //secondMenu.AddListener(mainMenu);
            Interfaces.MenuAction showVersion = new Interfaces.MenuAction("Show Version", new ShowVersion());
            Interfaces.MenuAction showDate = new Interfaces.MenuAction("Show Date", new ShowDate());
            Interfaces.MenuAction showTime = new Interfaces.MenuAction("Show Time", new ShowTime());
            Interfaces.MenuAction countSpaces = new Interfaces.MenuAction("Count Spaces", new CountSpaces());
            firstMenu.AddMenuItem(countSpaces);
            firstMenu.AddMenuItem(showVersion);
            secondMenu.AddMenuItem(showTime);
            secondMenu.AddMenuItem(showDate);

            mainMenu.Show();
        }

        private static void runDelegatesMenu()
        {
            Delegates.MainMenu mainMenu = new Delegates.MainMenu();

            Delegates.SubMenu firstMenu = new Delegates.SubMenu("Version And Spaces", "Back");
            Delegates.SubMenu secondMenu = new Delegates.SubMenu("Date and Time", "Back");
            mainMenu.Main.AddMenuItem(firstMenu, mainMenu.OnSelect);
            mainMenu.Main.AddMenuItem(secondMenu, mainMenu.OnSelect);

            //firstMenu.AddListener(mainMenu);
            //secondMenu.AddListener(mainMenu);
            Delegates.MenuAction showVersion = new Delegates.MenuAction("Show Version", new ShowVersion());
            Delegates.MenuAction showDate = new Delegates.MenuAction("Show Date", new ShowDate());
            Delegates.MenuAction showTime = new Delegates.MenuAction("Show Time", new ShowTime());
            Delegates.MenuAction countSpaces = new Delegates.MenuAction("Count Spaces", new CountSpaces());
            firstMenu.AddMenuItem(countSpaces, mainMenu.OnSelect);
            firstMenu.AddMenuItem(showVersion, mainMenu.OnSelect);
            secondMenu.AddMenuItem(showTime, mainMenu.OnSelect);
            secondMenu.AddMenuItem(showDate, mainMenu.OnSelect);

            mainMenu.Show();
        }
    }
}
