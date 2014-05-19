// Write a program that reads a string from the console and prints all different letters
// in the string along with information how many times each letter is found.

using System;

namespace LettersInString
{
    class LettersInString
    {
        static void Main()
        {
            string input = "Seeing a spider isn't a problem. It becomes a probleam when it desappears!";
            int[] counters = new int[26];
            foreach (char item in input.ToLower())
            {
                if ('a' <= item && item <= 'z')
                {
                    counters[item - 97]++;
                }
            }
            Console.WriteLine("Letters: ");
            for (int i = 0; i < counters.Length; i++)
            {
                if (counters[i] != 0)
                {
                    Console.WriteLine("{0}: {1}", (char)(i + 97), counters[i]);
                }
            }
        }
    }
}