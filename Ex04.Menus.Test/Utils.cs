using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    public class Utils
    {
        public static void ShowDate()
        {
            string currentDate = DateTime.Now.ToShortDateString();

            Console.Clear();
            Console.WriteLine("Today's data is: {0} ", currentDate);
            Utils.WaitForUserToContinue();
        }
        public static void ShowVersion()
        {
            Console.Clear();
            Console.WriteLine("Version: 21.3.4.8933");
            Utils.WaitForUserToContinue();
        }
        public static void ShowTime()
        {
            string currentTime = DateTime.Now.ToShortTimeString();

            Console.Clear();
            Console.WriteLine("Current time is: {0} ", currentTime);
            Utils.WaitForUserToContinue();
        }

        public static void CountSpacesInString(string i_StringToCheck)
        {
            int spacesCounter = 0; 
            char k_Space = ' ';

            foreach (char charInString in i_StringToCheck)
            {
                if (charInString.Equals(k_Space))
                {
                    spacesCounter++;
                }
            }

            Console.WriteLine("The number of spaces is: {0} ", spacesCounter);
            Utils.WaitForUserToContinue();
        }
        public static string GetStringFromUser()
        {
            bool isValidString = false;
            string stringInput = "";

            Console.Write("Please enter your string: ");
            while (!isValidString)
            {
                stringInput = Console.ReadLine();

                isValidString = !string.IsNullOrEmpty(stringInput);
                if (!isValidString)
                {
                    Console.Write("String missing, please try again: ");
                }
            }

            return stringInput;
        }
        public static void WaitForUserToContinue()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
