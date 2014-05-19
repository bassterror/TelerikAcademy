// Write a program that finds the biggest of three integers using nested if statements.

using System;

class GreaterInteger
{
    static void Main()
    {
        Console.Write("Enter inger a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter inger b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter inger c: ");
        int c = int.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("{0} is the greatest integer.", a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("{0} is the greatest integer.", b);
        }
        else
        {
            Console.WriteLine("{0} is the greatest integer.", c);
        }
    }
}