using System;
using System.Linq;
using System.Collections.Generic;
namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            int[] oneToTen= {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var even = new List<int>();
            var  odd = new List<int>();


            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            for (int i = 0; i < oneToTen.Length; i++)
            {
                if (oneToTen[i] % 2 == 0)
                {
                    even.Add(oneToTen[i]);
                }
                else
                {
                    odd.Add(oneToTen[i]);
                }


            }

            Console.WriteLine("These are even");
                foreach (var item in even)
                {
                    Console.WriteLine(item);
                }
            Console.WriteLine("These are odd");
                foreach (var item in odd)
                {
                    Console.WriteLine(item);
                }

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }

    internal class list<T>
    {
        public list()
        {
        }
    }
}
