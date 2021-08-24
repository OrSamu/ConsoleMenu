using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class Menu : MainMenu
    {
        private const int k_Back = 0;

        public Menu(string i_Title, Menu i_PreviousMenu)
            : base(i_Title,i_PreviousMenu)
        {
        }

        public List<MenuItem> MenuItemList
        {
            get { return MenuItemList; }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            MenuItemList.Add(i_MenuItem);
        }

        internal override void DoWhenMenuItemSelected()
        {
            int usersChoice;

            PrintMenuItems();
            PrintLastOption();
            usersChoice = GetInputFromUser();

            if(usersChoice != k_Back)
            {
                MenuItemList[usersChoice - 1].DoWhenMenuItemSelected();
            }
            else
            {
                r_PreviousMenu.DoWhenMenuItemSelected();
            }
        }

        protected override void PrintLastOption()
        {
            Console.WriteLine(" {0} - Back ", k_Back);
        }
    }
}