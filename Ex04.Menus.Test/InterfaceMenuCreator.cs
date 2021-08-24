using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    class InterfaceMenuCreator
    {
        public static MainMenu CreateMenuWithInterfaces()
        {
            MainMenu newMainMenu;
            Menu mainMenu = new Menu("Main Interfaces", null);
            Menu versionAndSpacesSubMenu = new Menu("Version and Spaces", mainMenu);
            Menu dateAndTimeSubMenu = new Menu("Show Date/Time", mainMenu);
            MenuCommand countSpacesAction = new MenuCommand("Count Spaces",new Spaces(), versionAndSpacesSubMenu);
            MenuCommand showVersionAction = new MenuCommand("Show Version", new Version (), versionAndSpacesSubMenu);
            MenuCommand showDateAction = new MenuCommand("Show Date", new Date(), dateAndTimeSubMenu);
            MenuCommand showTimeAction = new MenuCommand("Show Time", new Time(), dateAndTimeSubMenu);
            versionAndSpacesSubMenu.AddMenuItem(countSpacesAction);
            versionAndSpacesSubMenu.AddMenuItem(showVersionAction);
            dateAndTimeSubMenu.AddMenuItem(showTimeAction);
            dateAndTimeSubMenu.AddMenuItem(showDateAction);
            mainMenu.AddMenuItem(versionAndSpacesSubMenu);
            mainMenu.AddMenuItem(dateAndTimeSubMenu);
            newMainMenu= new MainMenu(mainMenu);
            return newMainMenu;
        }
    }
}
