using System.Collections.Generic;

namespace HomeWork3
{
    class Alphabet
    {
        public static bool CheckLetter(char letter)
        {
            if (letter == 'a' || letter == 'A' ||
                letter == 'e' || letter == 'E' ||
                letter == 'i' || letter == 'I' ||
                letter == 'o' || letter == 'O' ||
                letter == 'u' || letter == 'U' ||
                letter == 'y' || letter == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}

