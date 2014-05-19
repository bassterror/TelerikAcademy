// Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Enter value for N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}