// Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Text;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter your number:");
            int number = int.Parse(Console.ReadLine());
            StringBuilder hexNumber = new StringBuilder();
            while (number > 0)
            {
                switch (number % 16)
                {
                    case 10:
                        hexNumber.Append('A');
                        break;
                    case 11:
                        hexNumber.Append('B');
                        break;
                    case 12:
                        hexNumber.Append('C');
                        break;
                    case 13:
                        hexNumber.Append('D');
                        break;
                    case 14:
                        hexNumber.Append('E');
                        break;
                    case 15:
                        hexNumber.Append('F');
                        break;
                    default:
                        hexNumber.Append(number % 16);
                        break;
                }
                number /= 16;
            }
            string result = hexNumber.ToString();
            Console.Write("The hexadecimal representaion of your number is: ");
            for (int i = result.Length - 1; i > -1; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}