// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

namespace HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int digit = 0;
                switch (array[i])
                {
                    case 'A': digit = 10;
                        break;
                    case 'B': digit = 11;
                        break;
                    case 'C': digit = 12;
                        break;
                    case 'D': digit = 13;
                        break;
                    case 'E': digit = 14;
                        break;
                    case 'F': digit = 15;
                        break;
                    default: digit = int.Parse(array[i].ToString());
                        break;
                }
                for (int j = 0; j < i; j++)
                {
                    digit *= 16;
                }
                result += digit;
            }
            Console.WriteLine("The deciaml representation of your number is: {0}", result);
        }
    }
}
