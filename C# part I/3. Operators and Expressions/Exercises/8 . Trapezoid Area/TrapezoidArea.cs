// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter h: ");
        double h = double.Parse(Console.ReadLine());

        double r = (((a + b) / 2) * h);
        Console.WriteLine("Trapezoid's area is: {0}", r);
    }
}
