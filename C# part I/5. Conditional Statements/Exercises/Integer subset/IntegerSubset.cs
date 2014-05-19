// We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
// Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;

class IntegerSubset
{
    static void Main()
    {
        Console.Write("Enter inger a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter inger b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter inger c: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter inger d: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter inger e: ");
        int e = int.Parse(Console.ReadLine());
        int subset1, subset2, subset3, subset4, subset5, subset6, subset7, subset8, subset9, subset10, subset11, subset12, subset13, subset14, subset15;
        subset1 = a + b + c + d + e;
        subset2 = a + b + c + d;
        subset3 = b + c + d + e;
        subset4 = a + b + c;
        subset5 = b + c + d;
        subset6 = c + d + e;
        subset7 = a + b;
        subset8 = b + c;
        subset9 = c + d;
        subset10 = d + e;
        subset11 = a;
        subset12 = b;
        subset13 = c;
        subset14 = d;
        subset15 = e;
        
        if (subset1 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}, {3}, {4}", a, b, c, d, e);
        }
        if (subset2 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}, {3}", a, b, c, d);
        }
        if (subset3 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}, {3}", b, c, d, e);
        }
        if (subset4 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}", a, b, c);
        }
        if (subset5 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}", b, c, d);
        }
        if (subset6 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}, {2}", c, d, e);
        }
        if (subset7 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}", a, b);
        }
        if (subset8 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}", b, c);
        }
        if (subset9 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}", c, d);
        }
        if (subset10 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}, {1}", d, e);
        }
        if (subset11 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}", a);
        }
        if (subset12 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}", b);
        }
        if (subset13 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}", c);
        }
        if (subset14 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}", d);
        }
        if (subset15 == 0)
        {
            Console.WriteLine("The subset with sum zero is: {0}", e);
        }
    }
}