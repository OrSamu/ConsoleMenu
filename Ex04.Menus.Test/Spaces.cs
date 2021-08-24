using System;

namespace Ex04.Menus.Test
{
    public class Spaces
    {
        private const char k_Space = ' ';



        public static void CountSpacesInString(string i_StringToCheck)
        {
            int spacesCounter = 0;
            
            foreach(char charInString in i_StringToCheck)
            {
                if(charInString.Equals(k_Space))
                {
                    spacesCounter++;
                }
            }

            Console.WriteLine("The number of spaces is: {0} ", spacesCounter);
        }
    }
}