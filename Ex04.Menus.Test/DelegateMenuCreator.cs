using Ex04.Menus.Delegates;
using System;

namespace Ex04.Menus.Test
{
    public static class DelegateMenuCreator
    {
        public static MainMenu CreateMenuWithDelegates()
        {
            MainMenu mainMenu = new MainMenu("Main Delegates");
            Menu versionAndSpacesSubMenu = new Menu("Version and Spaces", mainMenu);
            Menu showDateAndTimeSubMenu = new Menu("Show Date/Time", mainMenu);
            ActionItem countSpacesAction = new ActionItem("Count Spaces", versionAndSpacesSubMenu);
            ActionItem showVersionAction = new ActionItem("Show Version", versionAndSpacesSubMenu);
            ActionItem showDateAction = new ActionItem("Show Date", showDateAndTimeSubMenu);
            ActionItem showTimeAction = new ActionItem("Show Time", showDateAndTimeSubMenu);

            mainMenu.AddMenuItem(versionAndSpacesSubMenu);
            mainMenu.AddMenuItem(showDateAndTimeSubMenu);
            versionAndSpacesSubMenu.AddMenuItem(countSpacesAction);
            versionAndSpacesSubMenu.AddMenuItem(showVersionAction);
            showDateAndTimeSubMenu.AddMenuItem(showDateAction);
            showDateAndTimeSubMenu.AddMenuItem(showTimeAction);
            countSpacesAction.ActionSelected += countSpaceAction_ActionSelected;
            showVersionAction.ActionSelected += showVersionAction_ActionSelected;
            showDateAction.ActionSelected += showDateAction_ActionSelected;
            showTimeAction.ActionSelected += showTimeAction_ActionSelected;

            return mainMenu;
        }

        private static void countSpaceAction_ActionSelected()
        {
            string userInput = Utils.GetStringFromUser();
            Utils.CountSpacesInString(userInput);
        }

        private static void showVersionAction_ActionSelected()
        {
            Utils.ShowVersion();
        }

        private static void showDateAction_ActionSelected()
        {
           Utils.ShowDate();
        }

        private static void showTimeAction_ActionSelected()
        {
            Utils.ShowTime();
        }

    }
}