// Write a program that reads a number N and calculates the sum of the first N members
// of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
// Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;

class FibonacciSum
{
    static void Main()
    {
        Console.Write("How many Fibonacci numbers you want to sum?: ");
        int n = int.Parse(Console.ReadLine());
        decimal a = 0;
        decimal b = 1;
        decimal t = 0;
        decimal total = 1;
        if (n <= 1)
        {
            Console.WriteLine("The sum is: {0}", a);
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                t = a + b;
                a = b;
                b = t;
                total += t;
            }
            Console.WriteLine("The sum is: {0}", total);
        }
    }
}