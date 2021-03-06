﻿// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers:  a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

namespace NumbersInRange
{
    class NumbersInRange
    {
        static int counter = 0;        

        static void Main()
        {
            ReadNumber(1, 100);
        }

        static int ReadNumber(int start, int end)
        {
            int number = 0;
            try
            {
                Console.Write("Enter number between {0} and {1}: ", start, end);
                number = int.Parse(Console.ReadLine());
                counter++;
                if (counter == 10)
                {
                    return number;
                }
                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Your number is not valid!");
                return 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your number is out of range!");
                return 0;
            }
            return ReadNumber(number, end);
        }
    }
}