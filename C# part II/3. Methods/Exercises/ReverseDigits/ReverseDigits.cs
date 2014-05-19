// Write a method that reverses the digits of given decimal number.
// Example: 256 -> 652.
using System;
using System.Text;
using System.Threading;
using System.Globalization;

namespace ReverseDigits
{
    class ReverseDigits
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            
            Console.Write("Enter decimal number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            string numberToString = number.ToString();
            Console.WriteLine("Reversed number: {0}", Reverse(numberToString));

        }

        static string Reverse(string number)
        {
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            StringBuilder reversedNumber = new StringBuilder();
            if (array[array.Length - 1] == '-')
            {
                reversedNumber = reversedNumber.Append("-");
                for (int i = 0; i < array.Length - 1; i++)
                {
                    reversedNumber = reversedNumber.Append(array[i]);
                }
            }
            else
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    reversedNumber = reversedNumber.Append(array[i]);
                }
            }
            return reversedNumber.ToString();
        }
    }
}
