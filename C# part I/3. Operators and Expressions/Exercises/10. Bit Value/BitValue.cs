// Write a boolean expression that returns if the bit at position p (counting from 0)
// in a given integer number v has value of 1. Example: v=5; p=1  false.

using System;

class BitValue
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << b;
        int c = mask & a;
        c = c >> b;
        if (c == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}