// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.
// Sample dictionary: .NET - platform for applications from Microsoft
//                    CLR - managed execution environment for .NET
//                    namespace - hierarchical organization of classes

using System;
using System.IO;

namespace WordsInDictionary
{
    class WordsInDictionary
    {
        static void Main()
        {            
            using (StreamReader read = new StreamReader("dictionary.txt"))
            {
                Console.Write("Enter word: ");
                string word = Console.ReadLine();
                for (string line; (line = read.ReadLine()) != null; )
                {
                    if (line.IndexOf(word + " -", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        Console.Write("Description: {0}\n", line);
                    }
                }
            }
        }
    }
}