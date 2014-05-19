// * Write a program that calculates for given N how many trailing zeros present at the end of the number N!.
// Examples: N = 10  N! = 3628800  2 ; N = 20  N! = 2432902008176640000  4
// Does your program work for N = 50 000?
// Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        BigInteger fN = 1;
        int zeros = 0;
        int d = 5;
        for (int i = 1; i <= N; i++)
        {
            fN *= i;
        }
        Console.WriteLine("{0}! = {1}", N, fN);
        while (N >= d)
        {
            zeros += (N / d);
            d *= 5;
        }
        Console.WriteLine("There are {0} trailing zeros at the end of {1}!", zeros, N);
    }
}