// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

using System;
using System.IO;

namespace AddNumberOfLines
{
    class AddNumberOfLines
    {
        static void Main()
        {
            using (StreamReader read = new StreamReader("input.txt"))
            {
                int count = 1;                
                using (StreamWriter write = new StreamWriter("output.txt"))
                {
                    for (string line = read.ReadLine(); line != null; line = read.ReadLine())
                    {
                        write.Write("{0}: ", count);
                        write.WriteLine(line);
                        count++;
                    }
                }
            }
            Console.WriteLine("Done!");
        }
    }
}