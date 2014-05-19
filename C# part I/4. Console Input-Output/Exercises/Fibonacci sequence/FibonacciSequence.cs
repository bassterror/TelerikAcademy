// Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class FibonacciSequence
{
    static void Main()
    {
        decimal a = 0;
        Console.WriteLine(a);
        decimal b = 1;
        Console.WriteLine(b);
        decimal c;
        for (int i = 0; i < 100; i++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }
}
