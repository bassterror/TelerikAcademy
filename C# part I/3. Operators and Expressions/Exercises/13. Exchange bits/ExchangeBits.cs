// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));
        
        int mask1 = 1 << 3;
        int bit3 = (a & mask1) >> 3;
        mask1 = 1 << 24;
        int bit24 = (a & mask1) >> 24;
        if (bit3 == 0)
        {
            mask1 = ~(1 << 24);
            a = a & mask1;
        }
        else if (bit3 == 1)
        {
            mask1 = 1 << 24;
            a = a | mask1;
        }
        if (bit24 == 0)
        {
            mask1 = ~(1 << 3);
            a = a & mask1;
        }
        else if (bit24 == 1)
        {
            mask1 = 1 << 3;
            a = a | mask1;
        }

        int mask2 = 1 << 4;
        int bit4 = (a & mask2) >> 4;
        mask2 = 1 << 25;
        int bit25 = (a & mask2) >> 25;
        if (bit4 == 0)
        {
            mask2 = ~(1 << 25);
            a = a & mask2;
        }
        else if (bit4 == 1)
        {
            mask2 = 1 << 25;
            a = a | mask2;
        }
        if (bit25 == 0)
        {
            mask2 = ~(1 << 4);
            a = a & mask2;
        }
        else if (bit25 == 1)
        {
            mask2 = 1 << 4;
            a = a | mask2;
        }

        int mask3 = 1 << 5;
        int bit5 = (a & mask3) >> 5;
        mask3 = 1 << 26;
        int bit26 = (a & mask3) >> 26;
        if (bit5 == 0)
        {
            mask3 = ~(1 << 26);
            a = a & mask3;
        }
        else if (bit5 == 1)
        {
            mask3 = 1 << 26;
            a = a | mask3;
        }
        if (bit26 == 0)
        {
            mask3 = ~(1 << 5);
            a = a & mask3;
        }
        else if (bit26 == 1)
        {
            mask3 = 1 << 5;
            a = a | mask3;
        }
        Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));
    }
}