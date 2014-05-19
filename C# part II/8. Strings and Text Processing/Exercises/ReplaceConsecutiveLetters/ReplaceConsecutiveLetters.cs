// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 
// Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".

using System;
using System.Text;

namespace ReplaceConsecutiveLetters
{
    class ReplaceConsecutiveLetters
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            StringBuilder edit = new StringBuilder(input);
            for (int letter = 0; letter < edit.Length - 1; letter++)
            {
                if (edit[letter] == edit[letter + 1])
                {
                    edit.Remove(letter, 1);
                    letter--;
                }
            }
            Console.WriteLine("Edit: {0}",edit);
        }
    }
}