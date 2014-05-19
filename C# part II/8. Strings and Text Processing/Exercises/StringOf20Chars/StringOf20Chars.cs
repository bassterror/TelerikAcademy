// Write a program that reads from the console a string of maximum 20 characters.
// If the length of the string is less than 20, the rest of the characters should be filled with '*'.
// Print the result string into the console.

using System;

namespace StringOf20Chars
{
    class StringOf20Chars
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            string output = input.PadRight(20, '*');
            Console.WriteLine("Result: {0}", output);
        }
    }
}