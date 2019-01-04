using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string input = Console.ReadLine();
            bool isPalindrome = Palindrome.IsPalindromeHalf(input);
            Console.WriteLine(input + " is" + isPalindrome);


            Fibonacci.FibonacciSeries(9);
            Console.Write(Fibonacci.FibonacciNumber(9));

            Console.ReadLine();
        }


      

    }
}
