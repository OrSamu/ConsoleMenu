using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuItem
    {
        private const int k_Exit = 0;
        private readonly List<MenuItem> r_MenuOptions;

        public MainMenu(string i_Title):base(i_Title,null)
        {
            r_MenuOptions = new List<MenuItem>();
        }

        internal MainMenu(string i_Title,MenuItem i_PreviousItem) : base(i_Title, i_PreviousItem)
        {
            r_MenuOptions = new List<MenuItem>();
        }

        public List<MenuItem> MenuOptions
        {
            get { return r_MenuOptions; }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            MenuOptions.Add(i_MenuItem);
        }

        public void Show()
        {
            bool stopLoop = false;
            int usersChoice;
            
            while (!stopLoop)
            {
                PrintMenuItems();
                PrintLastOption();
                usersChoice = GetInputFromUser();
                stopLoop = usersChoice == k_Exit;

                if(!stopLoop)
                {
                    r_MenuOptions[usersChoice - 1].DoWhenMenuItemSelected();
                }
                else
                {
                    ExitFromMainMenu();
                }
            }
        }

        protected void PrintMenuItems()
        {
            int i = 0;

            Console.Clear();
            Console.WriteLine(" {0} ", this.Title);

            foreach(MenuItem item in r_MenuOptions)
            {
                Console.WriteLine(@" {0} - {1} ", i + 1, r_MenuOptions[i].Title);
            }
        }

        protected int GetInputFromUser()
        {
            bool isValidInput = false;
            string inputFromUser;
            int commandFromUser = -1;

            while(!isValidInput)
            {
                inputFromUser = Console.ReadLine();
                isValidInput = int.TryParse(inputFromUser, out commandFromUser);

                if(isValidInput)
                {
                    isValidInput = commandFromUser >= 0 && commandFromUser <= r_MenuOptions.Count;
                }

                if(!isValidInput)
                {
                    Console.WriteLine("Wrong input - please try again");
                }
            }

            return commandFromUser;
        }

        protected virtual void PrintLastOption()
        {
            Console.WriteLine(" 0 - Exit ");
        }

        protected void ExitFromMainMenu()
        {
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            Console.WriteLine("Good bye!");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }




        internal override void DoWhenMenuItemSelected()
        {
            Show();
        }
    }
}