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
            char space = ' ';
            int spacesCounter = 0;
            string stringToCheck = getStringFromUser();

            foreach (char charInString in stringToCheck)
            {
                if (charInString.Equals(space))
                {
                    spacesCounter++;
                }
            }

            Console.WriteLine("The number of spaces is: {0} ", spacesCounter);
            waitForUserToContinue();
        }

        private static void showVersionAction_ActionSelected()
        {
            Console.Clear();
            Console.WriteLine("Version: 21.3.4.8933");
            waitForUserToContinue();
        }

        private static void showDateAction_ActionSelected()
        {
            string currentDate = DateTime.Now.ToShortDateString();

            Console.Clear();
            Console.WriteLine("Today's data is: {0} ", currentDate);
            waitForUserToContinue();
        }

        private static void showTimeAction_ActionSelected()
        {
            string currentTime = DateTime.Now.ToShortTimeString();

            Console.Clear();
            Console.WriteLine("Current time is: {0} ", currentTime);
            waitForUserToContinue();
        }

        private static void waitForUserToContinue()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        private static string getStringFromUser()
        {
            bool isValidString = false;
            string stringInput = "";

            Console.Write("Please enter your string: ");
            while (!isValidString)
            {
                stringInput = Console.ReadLine();

                isValidString = !string.IsNullOrEmpty(stringInput);
                if (!isValidString)
                {
                    Console.Write("String missing, please try again: ");
                }
            }

            return stringInput;
        }
    }
}