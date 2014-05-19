// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.
// Example:		string = "43 68 9 23 318"  result = 461

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfStrings
{
    class SumOfStrings
    {
        static void Main()
        {
            Console.Write("Enter integers separeted with spaces: ");
            string input = Console.ReadLine();
            input = input.Trim();
            int sum = 0;
            string[] numbers = input.Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i].Trim());
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}