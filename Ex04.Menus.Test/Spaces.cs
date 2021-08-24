using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Spaces : IExecutable
    {
        void IExecutable.Execute()
        {
            string userInput = Utils.GetStringFromUser();
            Utils.CountSpacesInString(userInput);
        }
    }
}