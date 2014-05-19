// Write a program to calculate n! for each n in the range [1..100].
// Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Numerics;

namespace FactorialsInRange
{
    class FactorialsInRange
    {
        static void Main()
        {
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            CalculateFactorialOfN(arr);

        }
        static void CalculateFactorialOfN(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                BigInteger factorial = Factorial(i);
                Console.WriteLine(factorial);
            }
        }
        static BigInteger Factorial(int i)
        {
            BigInteger fact = 1;
            for (int j = 1; j <= i; j++)
            {
                fact *= j;
            }
            return fact;
        }
    }
}
