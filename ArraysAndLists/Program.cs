using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i =1; i<=10; i++)
            {
                if (i%2 ==0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }
            Console.WriteLine("Even Numbers: ");
            foreach (int evenNumber in  evens)
            {
                Console.WriteLine(evenNumber);
            }

            Console.WriteLine("Odd Numbers: ");
            foreach (int oddNumber in odds)
            {
                Console.WriteLine(oddNumber);
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
