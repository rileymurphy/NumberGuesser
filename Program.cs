using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    class Program
    {
        static int GetMedian(List<int> numberRange)
        {

            int medianValue;
            if (numberRange.Count % 2 != 0) //odd count
            {
                double medianPosOdd = (numberRange.Count / 2);
                double medianRoundedPosOdd = Math.Round(medianPosOdd);
                int medianIntPosOdd = Convert.ToInt32(medianRoundedPosOdd);
                medianValue = numberRange[medianIntPosOdd];
                return medianValue;
            }
            else // even count
            {
                int medianPosEven = (numberRange.Count / 2);
                medianValue = medianPosEven;
                return medianValue;
            }

        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userAnswer = Console.ReadLine();
            return userAnswer;
        }

        static void Main(string[] args)
        {
            // creating the original range
            List<int> guessingRange = new List<int>();

            for (int index = 1; index <= 1024; index++)
            {
                guessingRange.Add(index);
            }

            // Game begins
            Console.WriteLine("------------------------------------------------------------------------------------------------ ");
            Console.WriteLine($"Welcome! Please think of a number from 1 to 1024. ");
            Console.WriteLine($"I will guess a number and you will tell me if your number is HIGHER, LOWER, or if I am CORRECT. ");
            Console.WriteLine($"Press enter to begin.");
            Console.WriteLine("------------------------------------------------------------------------------------------------ ");
            Console.ReadKey();

            var numberGuess = GetMedian(guessingRange);

            var userAnswer = PromptForString($"My guess is {numberGuess}. Is your number HIGHER, LOWER, or am I CORRECT? Please type in ALL CAPS.");

            // while (userAnswer != "CORRECT")
            // {

            if (userAnswer == "HIGHER")
            {
                guessingRange.RemoveAll(lowerRange => lowerRange <= guessingRange[numberGuess] - 1);
                numberGuess = GetMedian(guessingRange);
                PromptForString($"My guess is {numberGuess}. Is your number HIGHER, LOWER, or am I CORRECT? Please type in ALL CAPS.");
            }
            else if (userAnswer == "LOWER")
            {
                guessingRange.RemoveAll(higherRange => higherRange >= guessingRange[numberGuess] - 1);
                numberGuess = GetMedian(guessingRange);
                PromptForString($"My guess is {numberGuess}. Is your number HIGHER, LOWER, or am I CORRECT? Please type in ALL CAPS.");
            }
            else
            {
                Console.WriteLine($"Please type in a valid input in ALL CAPS.");
            }
            // }
            Console.WriteLine("Haha! I win!");

        }
    }
}
