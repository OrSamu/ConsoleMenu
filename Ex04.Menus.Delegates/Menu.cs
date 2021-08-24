using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class Menu : MainMenu
    {
        private const int k_Back = 0;

        public Menu(string i_Title, MenuItem i_PreviousMenu)
            : base(i_Title,i_PreviousMenu)
        {
        }

        internal override void DoWhenMenuItemSelected()
        {
            int usersChoice;

            PrintMenuItems();
            PrintLastOption();
            usersChoice = GetInputFromUser();

            if(usersChoice != k_Back)
            {
                MenuOptions[usersChoice - 1].DoWhenMenuItemSelected();
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