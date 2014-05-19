// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
// Example:   Ivan	      George
//            Peter	      Ivan
//            Maria	      Maria
//            George	  Peter

using System;
using System.Collections.Generic;
using System.IO;

namespace SortStrings
{
    class SortStrings
    {
        static void Main()
        {
            using (StreamReader read = new StreamReader("input.txt"))
            {
                List<string> strings = new List<string>();

                for (string line = read.ReadLine(); line != null; line = read.ReadLine())
                {
                    strings.Add(line);
                }
                strings.Sort();

                using (StreamWriter write = new StreamWriter("output.txt"))
                {
                    foreach (string name in strings)
                    {
                        write.WriteLine(name);
                    }
                }
            }
            Console.WriteLine("Done!");
        }
    }
}