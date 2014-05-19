// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;

namespace DecimalToBinary
{
    class DecimalToBunary
    {
        static void Main()
        {
            Console.Write("Enter decimal: ");
            int number = int.Parse(Console.ReadLine());
            List<int> reverseBinary = new List<int>();
            while (number > 0)
            {
                reverseBinary.Add(number % 2);
                number = number / 2;
            }
            reverseBinary.Reverse();
            Console.Write("Binary representation of your number: ");
            for (int i = 0; i < reverseBinary.Count; i++)
            {
                Console.Write(reverseBinary[i]);
            }
            Console.WriteLine();
        }
    }
}
