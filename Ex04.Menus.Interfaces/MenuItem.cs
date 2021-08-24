using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        protected readonly string r_ItemName;
        protected readonly Menu r_PreviousMenu;
        protected MenuItem(string i_ItemName, Menu i_PreviousMenu)
        {
            r_ItemName = i_ItemName;
            r_PreviousMenu = i_PreviousMenu;
        }
        public string ItemName
        {
            get { return r_ItemName; }
        }

        public Menu PreviousMenuItem
        {
            get { return r_PreviousMenu; }
        }

        internal abstract void DoWhenMenuItemSelected();
    }
}