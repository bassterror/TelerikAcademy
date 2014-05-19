//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double x, x1, x2;
        double d = (b * b) - (4 * a * c);
        
        if (d < 0)
        {
            Console.WriteLine("The equation has no real roots");
        }
        else if (d == 0)
        {
            x = -b / (2 * a);
            Console.WriteLine("The equation has only one root - {0}", x);
        }
        else
        {
            x1 = ((-b + Math.Sqrt(d)) / (2 * a));
            x2 = ((-b - Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("The equation has two real roots - {0} and {1}", x1, x2);
        }
    }
}