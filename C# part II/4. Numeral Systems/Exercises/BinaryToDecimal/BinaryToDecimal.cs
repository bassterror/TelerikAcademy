// Write a program to convert binary numbers to their decimal representation.

using System;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Enter binary number: ");
            string input = Console.ReadLine();
            long number = Convert.ToInt64(input);
            long digit;
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                digit = number % 10;
                result += (int)(digit * Math.Pow(2, i));
                number /= 10;
            }
            Console.WriteLine("The decimal representation of your number is: {0}", result);
        }
    }
}