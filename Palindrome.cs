using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Palindrome
    {
        public static bool IsPalindrome(string inputString)
        {
            string reverse = "";
            inputString = inputString.ToLower();
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reverse = reverse + inputString[i];
            }

            if (reverse == inputString)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Better way of doing it. O(logN)

        public static bool IsPalindromeHalf(string inputString)
        {
            inputString = inputString.ToLower();
            for (int i = 0; i < inputString.Length / 2; i++)
            {
                if (inputString[i] != inputString[inputString.Length - i - 1])
                    return false;
            }

            return true;
        }
    }
}
