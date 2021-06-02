using Ex04.Menus;
using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            MainMenu mainMenu = new MainMenu();
            
            SubMenu firstMenu = new SubMenu("Version And Spaces", "Back");
            SubMenu secondMenu = new SubMenu("Date and Time", "Back");
            mainMenu.Main.AddMenuItem(firstMenu);
            mainMenu.Main.AddMenuItem(secondMenu);
            MenuAction showVersion = new MenuAction("Show Version",new ShowVersion());
            MenuAction showDate = new MenuAction("Show Date", new ShowDate());
            MenuAction showTime = new MenuAction("Show Time", new ShowTime());
            MenuAction countSpaces = new MenuAction("Count Spaces", new CountSpaces());
            firstMenu.AddMenuItem(countSpaces);
            firstMenu.AddMenuItem(showVersion);
            secondMenu.AddMenuItem(showTime);
            secondMenu.AddMenuItem(showDate);

            mainMenu.Show();
        }
    }
}
