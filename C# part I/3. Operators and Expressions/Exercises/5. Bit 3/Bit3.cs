//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class Bit3
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int a = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int b = a & mask;
        int c = b >> 3;
        Console.WriteLine("The third bit of your integer is: " + c);
    }
}