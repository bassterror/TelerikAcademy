// Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class PrintNumbersWithExeption
{
    static void Main()
    {
        Console.Write("Enter value for N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            if (i % 21 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}