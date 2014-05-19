// Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
// such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class MiddleNumbers
{
    static void Main()
    {
        Console.Write("Enter first positive integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second positive integer: ");
        int b = int.Parse(Console.ReadLine());
        int c;
        int p = 0;
        
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
       
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                p = p + 1;
            }
        }
      
        Console.WriteLine("p({0},{1}) = {2}", a, b, p);
    }
}