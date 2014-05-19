// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

namespace ListInOrder
{
    class ListInOrder
    {
        static void Main()
        {
            Console.Write("Enter list of words: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            Array.Sort(words);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}