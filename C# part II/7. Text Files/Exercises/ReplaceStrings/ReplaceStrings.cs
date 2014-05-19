// Write a program that replaces all occurrences of the substring "start" with the
// substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

namespace ReplaceStrings
{
    class ReplaceStrings
    {
        static void Main()
        {
            using (StreamReader read = new StreamReader("input.txt"))
            {
                using (StreamWriter write = new StreamWriter("output.txt"))
                {
                    for (string line = read.ReadLine(); line != null; line = read.ReadLine())
                    {
                        string newLine = line.Replace("start", "finish");
                        write.WriteLine(newLine);
                    }
                }
            }
            Console.WriteLine("Done!");
        }
    }
}