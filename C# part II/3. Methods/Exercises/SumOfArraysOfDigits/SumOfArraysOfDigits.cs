// Write a method that adds two positive integer numbers represented as arrays of digits
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SumOfArraysOfDigits
{
    class SumOfArraysOfDigits
    {
        static int[] ToArray(BigInteger a)
        {
            string aString = a.ToString();
            int[] intArray = new int[aString.Length];
            for (int i = aString.Length - 1; i >= 0; i--)
            {
                intArray[i] = (int)(a % 10);
                a = a / 10;
            }
            return intArray;
        }

        static void Main()
        {
            Console.Write("Enter first integer: ");
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            int[] firstArray = ToArray(a);
            int[] secondArray = ToArray(b);
            int[] resultArray = SumArrays(firstArray, secondArray);
            Console.Write("Result is: ");
            for (int i = resultArray.Length - 1; i >= 1; i--)
            {
                Console.Write(resultArray[i]);
            }
            Console.WriteLine();
                        
        }

        static int[] SumArrays(int[] firstArray, int[] secondArray)
        {
            int[] tempArray = new int[Math.Max(firstArray.Length, secondArray.Length) + 1];
            int addition = 0;
            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                tempArray[i] = (firstArray[i] + secondArray[i] + addition) % 10;
                if (tempArray[i] >= 10)
                {
                    addition = 1;
                }
                else
                {
                    addition = 0;
                }
            }

            if (firstArray.Length >= secondArray.Length)
            {
                for (int i = secondArray.Length; i < firstArray.Length; i++)
                {
                    tempArray[i] = firstArray[i] + addition;
                    if (tempArray[i] >= 10)
                    {
                        addition = 1;
                    }
                    else
                    {
                        addition = 0;
                    }
                }
            }
            else
            {
                for (int i = firstArray.Length; i < secondArray.Length; i++)
                {
                    tempArray[i] = secondArray[i] + addition;
                    if (tempArray[i] >= 10)
                    {
                        addition = 1;
                    }
                    else
                    {
                        addition = 0;
                    }
                }
            }            

            if (addition == 0)
            {
                Array.Resize(ref tempArray, tempArray.Length - 1);
            }
            else
            {
                tempArray[tempArray.Length - 1] += addition;
            }
            
            return tempArray;
        }
    }
}