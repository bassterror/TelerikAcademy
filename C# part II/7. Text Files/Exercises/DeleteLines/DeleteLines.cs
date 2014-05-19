// Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;

namespace DeleteLines
{
    class DeleteLines
    {
        static void Main()
        {
            using (StreamReader read = new StreamReader("input.txt"))
            {
                using (StreamWriter write = new StreamWriter("temp.txt"))
                {
                    int lineNumber = 1;
                    for (string line = read.ReadLine(); line != null; line = read.ReadLine())
                    {
                        if (lineNumber % 2 == 0)
                        {
                            write.WriteLine(line);
                        }
                        lineNumber++;
                    }
                }
            }
            File.Delete("input.txt");
            File.Move("temp.txt", "input.txt");
            Console.WriteLine("Done!");
        }
    }
}