// Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;
using System.Threading;
using System.Globalization;

class MinMax
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.Write("How many numbers do you wish to enter?: ");
        int a = int.Parse(Console.ReadLine());
        decimal min, max, b;

        Console.Write("Enter first number: ");
        b = decimal.Parse(Console.ReadLine());
        min = max = b;
        for (int i = 1; i < a; i++)
        {
            Console.Write("Enter next number: ");
            b = decimal.Parse(Console.ReadLine());

            if (b > max)
            {
                max = b;
            }
            if (b < min)
            {
                min = b;
            }
        }

        Console.WriteLine("Minimal is {0}", min);
        Console.WriteLine("Maximal is {0}", max);
    }
}