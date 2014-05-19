// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;

namespace ConvertAnyNumeralSystem
{
    class ConvertAnyNumeralSystem
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            Console.Write("Enter base 's': ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter base 'd': ");
            int d = int.Parse(Console.ReadLine());
            int decimalNumber = ConvertToDecimal(number, s);
            ConvertFromDecimal(decimalNumber, d);            
        }

        static int ConvertToDecimal(string number, int s)
        {
            int deciamlNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                deciamlNumber += Convert.ToInt32(number.Substring(i, 1)) * (int)Math.Pow(s, number.Length - 1 - i);
            }
            return deciamlNumber;
        }

        static void ConvertFromDecimal(int decimalNumber, int d)
        {
            List<int> result = new List<int>();
            if (d > 10)
            {
                while (decimalNumber > 0)
                {
                    result.Add(decimalNumber % d);
                    decimalNumber /= d;
                }
                result.Reverse();
                foreach (var item in result)
                {
                    switch (item)
                    {
                        case 10: 
                            Console.Write("A");
                            break;
                        case 11: 
                            Console.Write("B");
                            break;
                        case 12: 
                            Console.Write("C");
                            break;
                        case 13: 
                            Console.Write("D");
                            break;
                        case 14: 
                            Console.Write("E");
                            break;
                        case 15: 
                            Console.Write("F");
                            break;
                        default:
                            Console.Write(item);
                            break;
                    }
                }
                Console.WriteLine();
            }
            else
            {
                while (decimalNumber > 0)
                {
                    result.Add(decimalNumber % d);
                    decimalNumber /= d;
                }
                result.Reverse();
                foreach (var item in result)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
    }
}
