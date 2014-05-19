// Write a program that enters the coefficients a, b and c of a quadratic equation
// a*x2 + b*x + c = 0
// and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;
using System.Threading;
using System.Globalization;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("This is not a valid quadratic equation!");
        }
        else
        {
            double d = (b * b) - (4 * a * c);
            Console.WriteLine("The equation discriminant is: D={0}", d);
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The equation roots are: x1={0} x2={1}", x1, x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The equation has only one root: x={0}", x);
            }
            else if (d < 0)
            {
                Console.WriteLine("The equation has no real roots!");
            }
        }
    }
}