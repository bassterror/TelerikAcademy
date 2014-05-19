// Write a program that deletes from a text file all words that start with the prefix "test".
// Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace DeleteWords
{
    class DeleteWords
    {
        static void Main()
        {
            using (StreamReader read = new StreamReader("input.txt"))
            {
                using (StreamWriter write = new StreamWriter("output.txt"))
                {
                    for (string line; (line = read.ReadLine()) != null; )
                    {
                        write.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                    }
                }
            }
            Console.WriteLine("Done!");
        }
    }
}