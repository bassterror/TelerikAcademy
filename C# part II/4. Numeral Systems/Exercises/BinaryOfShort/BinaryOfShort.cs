// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

namespace BinaryOfShort
{
    class BinaryOfShort
    {
        static void Main()
        {
            Console.Write("Enter 16-bit number: ");
            short number = short.Parse(Console.ReadLine());
            short sign = number;
            if (sign <= 0)
            { 
                number = (short)(number + 1);
            }
            Console.Write("The binary representation of your number is: ");
            for (int i = 15; i >= 0; i--)
            {
                short digit = (short)(number / (short)Math.Pow(2, i));
                number = (short)(number % (short)Math.Pow(2, i));
                if (sign < 0) 
                { 
                    Console.Write(1 + digit); 
                }
                else 
                { 
                    Console.Write(digit); 
                }
            }
            Console.WriteLine();
        }
    }
}
