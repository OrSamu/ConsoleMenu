using System;
using System.Collections.Generic;
using System.Threading;

namespace Ex04.Menus.Interfaces
{
    public class Menu : MenuItem
    {
        private const int k_ExitMenu = 0;
        private readonly List<MenuItem> r_MenuItems;

        public Menu(string i_ItemName, Menu i_PreviousMenu)
            : base(i_ItemName, i_PreviousMenu)
        {
            r_MenuItems = new List<MenuItem>();
        }

        public void Show()
        {
            DoWhenMenuItemSelected();
        }

        internal override void DoWhenMenuItemSelected()
        {
            int usersChoice;

            PrintMenuItems();
            PrintLastOption();
            usersChoice = GetInputFromUser();

            if (usersChoice != k_ExitMenu)
            {
                r_MenuItems[usersChoice - 1].DoWhenMenuItemSelected();
            }
            else
            {
                if (r_PreviousMenu != null)
                {
                    r_PreviousMenu.DoWhenMenuItemSelected();
                }
                else
                {
                    ExitFromMainMenu();
                }
            }
        }
        protected void PrintLastOption()
        {
            String msg = "Back";
            if (r_PreviousMenu == null)
            {
                msg = "Exit";
            }

            Console.WriteLine(" {0} - {1} ", k_ExitMenu, msg);

        }
        protected void ExitFromMainMenu()
        {
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            Console.WriteLine("Good bye!");
        }
        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Add(i_MenuItem);
        }
        public List<MenuItem> MenuItems
        {
            get { return r_MenuItems; }
        }
        protected int GetInputFromUser()
        {
            bool isValidInput = false;
            string inputFromUser;
            int commandFromUser = -1;

            while (!isValidInput)
            {
                inputFromUser = Console.ReadLine();
                isValidInput = int.TryParse(inputFromUser, out commandFromUser);

                if (isValidInput)
                {
                    isValidInput = commandFromUser >= 0 && commandFromUser <= r_MenuItems.Count;
                }

                if (!isValidInput)
                {
                    Console.WriteLine("Wrong input - please try again");
                }
            }

            return commandFromUser;
        }
        protected void PrintMenuItems()
        {
            int i = 0;

            Console.Clear();
            Console.WriteLine(" {0} ", ItemName);

            foreach (MenuItem item in r_MenuItems)
            {
                Console.WriteLine(@" {0} - {1} ", i + 1, r_MenuItems[i].ItemName);
                i++;
            }
        }
    }
}