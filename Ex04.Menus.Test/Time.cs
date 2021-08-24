using System;

namespace Ex04.Menus.Test
{
    public class Time
    {

        public static void ShowTime()
        {
            string currentTime = DateTime.Now.ToShortTimeString();
            
            Console.Clear();
            Console.WriteLine("Current time is: {0} ",currentTime);
        }
    }
}