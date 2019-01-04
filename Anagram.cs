using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Anagram
    {
       public static bool IsAnagram(string strinputStringOne,string strinputStringTwo)
        {
            char[] charOne = strinputStringOne.ToLower().ToCharArray();
            char[] charTwo = strinputStringTwo.ToLower().ToCharArray();

            Array.Sort(charOne);
            Array.Sort(charOne);

            strinputStringOne = charOne.ToString();

            strinputStringTwo = charTwo.ToString();

            if (strinputStringOne == strinputStringTwo)
                return true;

            return false;
        }
    }
}
