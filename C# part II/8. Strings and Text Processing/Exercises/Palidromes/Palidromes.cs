// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
using System;
using System.Text.RegularExpressions;

namespace Palidromes
{
    class Palidromes
    {
        static bool IsPalindrome(string item)
        {
            for (int i = 0; i < item.Length / 2; i++)
            {
                if (item[i] != item[item.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            string input = "Example:  ABBA, another word lamal, exe. boob";
            Console.WriteLine("Palidromes: ");
            foreach (Match item in Regex.Matches(input, @"\w+"))
            {
                if (IsPalindrome(item.Value))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}