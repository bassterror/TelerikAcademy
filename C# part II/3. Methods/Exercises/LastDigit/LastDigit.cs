// Write a method that returns the last digit of given integer as an English word.
// Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

using System;

namespace LastDigit
{
    class LastDigit
    {
        static string[] digitNames = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        static string DigitName(int index)
        {
            return digitNames[index];
        }

        static int GetLastDigit(int number)
        {
            int digit = number % 10;
            return digit;
        }

        static void Main()
        {
            Console.Write("Enter inger: ");
            int number = int.Parse(Console.ReadLine());
            int remain = GetLastDigit(number);
            Console.WriteLine(DigitName(remain));
        }
    }
}
