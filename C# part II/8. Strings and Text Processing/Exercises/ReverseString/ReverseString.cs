// Write a program that reads a string, reverses it and prints the result at the console.

using System;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            Console.Write("Type a string: ");
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            Console.Write("This is your string in reverse: ");
            Console.Write(array);
            Console.WriteLine();
        }
    }
}