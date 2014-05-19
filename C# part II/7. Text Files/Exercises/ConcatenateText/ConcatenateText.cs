// Write a program that concatenates two text files into another text file.

using System;
using System.IO;

namespace ConcatenateText
{
    class ConcatenateText
    {
        static void Main()
        {
            using (StreamReader readFirst = new StreamReader("first.txt"))
            {
                using (StreamWriter write = new StreamWriter("output.txt", false))
                {
                    for (string line = readFirst.ReadLine(); line != null; line = readFirst.ReadLine())
                    {
                        write.WriteLine(line);
                    }
                }
            }

            using (StreamReader readSecond = new StreamReader("second.txt"))
            {
                using (StreamWriter write = new StreamWriter("output.txt", true))
                {
                    for (string line = readSecond.ReadLine(); line != null; line = readSecond.ReadLine())
                    {
                        write.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("Done!");
        }
    }
}