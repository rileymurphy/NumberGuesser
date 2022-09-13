using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> guessingRange = new List<int>();

            for (int index = 1; index <= 1024; index++)
            {
                guessingRange.Add(index);
            }

            Console.WriteLine($"Welcome! Please think of a number from 1 to 1024. I will guess a number and you will tell me if your number is HIGHER, LOWER, or if I am CORRECT.");

        }
    }
}




