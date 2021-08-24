using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class MenuCommand : MenuItem
    {
        private readonly IExecutable r_Command;

        public MenuCommand(string i_ItemName, IExecutable i_Command, Menu i_PreviousMenu)
            : base(i_ItemName, i_PreviousMenu)
        {
            r_Command = i_Command;
        }

        internal override void DoWhenMenuItemSelected()
        {
            r_Command.Execute();
        }

    }
}
