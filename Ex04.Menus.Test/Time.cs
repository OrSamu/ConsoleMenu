using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Time : IExecutable
    {
        void IExecutable.Execute()
        {
            Utils.ShowTime();
        }
    }
}