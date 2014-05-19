//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
// Sample input: "Hi!".
// Expected output: "\u0048\u0069\u0021".
using System;
using System.Text;

namespace ConvertString
{
    class ConvertString
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            StringBuilder unicode = new StringBuilder(input.Length * 6);
            foreach (char element in input)
            {
                unicode.AppendFormat("\\u{0:X4}", (int)element);
            }
            string output = unicode.ToString();
            Console.WriteLine("Converted: {0}",output);
        }
    }
}