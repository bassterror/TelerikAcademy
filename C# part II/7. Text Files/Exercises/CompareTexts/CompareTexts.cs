// Write a program that compares two text files line by line and prints the number of lines that
// are the same and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.IO;

namespace CompareTexts
{
    class CompareTexts
    {
        static void Main()
        {
            using (StreamReader readOne = new StreamReader("first.txt"), readTwo = new StreamReader("second.txt"))
            {
                string lineFirst, lineSecond;
                int diffLines = 0, sameLines = 0;

                while ((lineFirst = readOne.ReadLine()) != null && (lineSecond = readTwo.ReadLine()) != null)
                {
                    if (lineFirst == lineSecond)
                    {
                        sameLines++;
                    }
                    else
                    {
                        diffLines++;
                    }
                }
                Console.WriteLine("Diffrent lines: {0}", diffLines);
                Console.WriteLine("Same lines: {0}", sameLines);
            }  
        }
    }
}