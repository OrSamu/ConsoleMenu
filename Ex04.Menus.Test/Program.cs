﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
          //  Delegates.MainMenu delegatesMainMenu = DelegateMenuCreator.CreateMenuWithDelegates();
          //  delegatesMainMenu.Show();

            Interfaces.MainMenu intefacesMainMenu = InterfaceMenuCreator.CreateMenuWithInterfaces();
            intefacesMainMenu.Menu.Show();
        }
    }
}
