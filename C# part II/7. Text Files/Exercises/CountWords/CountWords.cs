// Write a program that reads a list of words from a file words.txt and finds how many times
// each of the words is contained in another file test.txt. The result should be written 
// in the file result.txt and the words should be sorted by the number of their occurrences in descending order. 
// Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

namespace CountWords
{
    class CountWords
    {
        static void Main()
        {
            try
            {
                string[] words = File.ReadAllLines("words.txt");
                int[] counters = new int[words.Length];
                using (StreamReader read = new StreamReader("test.txt"))
                {
                    for (string line; (line = read.ReadLine()) != null; )
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            counters[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                        }
                    }
                }
                Array.Sort(counters, words);

                using (StreamWriter write = new StreamWriter("result.txt"))
                {
                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        write.WriteLine("{0}: {1}", words[i], counters[i]);
                    }
                }
                Console.WriteLine("Done!");
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found!");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied!");
            }
        }
    }
}