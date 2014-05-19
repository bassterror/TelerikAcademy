// Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceWords
{
    class ReplaceWords
    {
        static void Main()
        {
            using (StreamReader read = new StreamReader("input.txt"))
            {
                using (StreamWriter write = new StreamWriter("output.txt"))
                {
                    string model = @"\b(start)\b";
                    Regex word = new Regex(model);
                    for (string line = read.ReadLine(); line != null; line = read.ReadLine())
                    {
                        string newLine = word.Replace(line, "finish");
                        write.WriteLine(newLine);
                    }
                }
            }
            Console.WriteLine("Done!");
        }
    }
}