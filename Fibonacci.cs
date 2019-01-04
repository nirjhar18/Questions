using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Fibonacci
    {
        public static void FibonacciSeries(int Fibonaccilength)
        {
            int lastNumber = 0;
            int currentNumber = 0;
            int numberToPrint = 0;
            for (int i= 0; i <= Fibonaccilength - 1; i++)
            {
                numberToPrint = lastNumber + currentNumber;
                Console.Write(numberToPrint + " ");
                if(i == 0)
                {
                    currentNumber++;
                }
                else if (i == 1){
                    lastNumber = 0;
                }
                else
                { 
                lastNumber = currentNumber;
                currentNumber = numberToPrint;
                }

            }           
        }

        //Recursive version of Fibonacci
        public static void Fibonacci_recursive(int Fibonaccilength)
        {
            Fibonacci_recursive_temp(0, 1, 1, Fibonaccilength);

        }

        private static void Fibonacci_recursive_temp(int a,int b,int counter,int Fibonaccilength)
        {
            if (counter < Fibonaccilength)
            {
                Console.WriteLine(a);
                Fibonacci_recursive_temp(b, a + b, counter + 1, Fibonaccilength);
            }
        }



        //Find the ith number in Fibonacci series
        public static int FibonacciNumber(int FibonacciNumber)
        {
            int lastNumber = 0;
            int currentNumber = 0;
            int numberToPrint = 0;
            for (int i = 0; i <= FibonacciNumber - 1; i++)
            {
                numberToPrint = lastNumber + currentNumber;
                //Console.Write(numberToPrint + " ");
                if (i == 0)
                {
                    currentNumber++;
                }
                else if (i == 1)
                {
                    lastNumber = 0;
                }
                else
                {
                    lastNumber = currentNumber;
                    currentNumber = numberToPrint;
                }
            }
            return currentNumber;
        }

    }
}
