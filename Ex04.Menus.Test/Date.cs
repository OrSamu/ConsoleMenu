using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    public class Date
    {
        public static void ShowDate()
        {
            string currentDate = DateTime.Now.ToShortDateString();

            Console.Clear();
            Console.WriteLine("Today's data is: {0} ", currentDate);
        }
    }
}
