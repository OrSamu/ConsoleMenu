using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public static class DelegateMenuCreator
    {
        public static MainMenu CreateMenuWithDelegates()
        {
            MainMenu mainMenu = new MainMenu("Main Delegates");
            Menu versionAndSpacesSubMenu = new Menu("Version and Spaces", mainMenu);
            Menu showDateAndTimeSubMenu = new Menu("Show Date/Time", mainMenu);
            ActionItem countSpaces = new ActionItem("Count Spaces", versionAndSpacesSubMenu);
            ActionItem showVersion = new ActionItem("Show Version", versionAndSpacesSubMenu);
            ActionItem showDate = new ActionItem("Show Date", showDateAndTimeSubMenu);
            ActionItem showTime = new ActionItem("Show Time", showDateAndTimeSubMenu);

            mainMenu.AddMenuItem(versionAndSpacesSubMenu);
            mainMenu.AddMenuItem(showDateAndTimeSubMenu);
            versionAndSpacesSubMenu.AddMenuItem(countSpaces);
            versionAndSpacesSubMenu.AddMenuItem(showVersion);
            showDateAndTimeSubMenu.AddMenuItem(showDate);
            showDateAndTimeSubMenu.AddMenuItem(showTime);

            return mainMenu;
        }
    }
}