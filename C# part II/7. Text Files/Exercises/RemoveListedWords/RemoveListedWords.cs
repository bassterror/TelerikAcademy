// Write a program that removes from a text file all words listed in given another text file.
// Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

namespace RemoveListedWords
{
    class RemoveListedWords
    {
        static void Main()
        {
            try
            {
                string words = @"\b(" + String.Join("|", File.ReadAllLines("list.txt")) + @")\b";
                using (StreamReader read = new StreamReader("input.txt"))
                {
                    using (StreamWriter write = new StreamWriter("output.txt"))
                    {
                        for (string line; (line = read.ReadLine()) != null; )
                        {
                            write.WriteLine(Regex.Replace(line, words, "******"));
                        }
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