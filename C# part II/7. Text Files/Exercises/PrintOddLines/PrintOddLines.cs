// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

namespace PrintOddLines
{
    class PrintOddLines
    {
        static void Main()
        {
            using (StreamReader read = new StreamReader("input.txt"))
            {
                int lineNumber = 1;
                for (string line = read.ReadLine(); line != null; line = read.ReadLine())
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineNumber++;
                }                
            }
        }
    }
}