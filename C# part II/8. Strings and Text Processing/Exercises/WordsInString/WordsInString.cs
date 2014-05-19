// Write a program that reads a string from the console and lists all different words 
// in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;

namespace WordsInString
{
    class WordsInString
    {
        static void Main()
        {
            string text = "The only difference between the tattooed people and non tattooed people is - the tattooed people don't care if you.";
            string[] words = text.ToLower().Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> counters = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (counters.ContainsKey(word))
                {
                    counters[word] = counters[word] + 1;
                }
                else
                {
                    counters.Add(word, 1);
                }
            }
            Console.WriteLine("Words: ");
            foreach (var word in counters)
            {
                Console.WriteLine("{0}: {1}", word.Key, word.Value);
            }
        }
    }
}