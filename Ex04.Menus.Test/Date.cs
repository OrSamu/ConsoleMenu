using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Date : IExecutable
    { 
        void IExecutable.Execute()
        {
            Utils.ShowDate();
        }
    }
}
