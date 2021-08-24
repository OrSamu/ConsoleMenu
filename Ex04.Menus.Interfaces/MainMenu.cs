using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class MainMenu
    {
        private Menu m_Menu;
        
        public MainMenu(Menu i_Menu)
        {
            m_Menu = i_Menu;
        }
        public Menu Menu
        {
            get
            {
                return m_Menu;
            }
        }

    }
}
