// Write a program that finds the greatest of given 5 variables.

using System;
using System.Threading;
using System.Globalization;

class GreatestVariable
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter first variable: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second variable: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third variable: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter fourth variable: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter fifth variable: ");
        double e = double.Parse(Console.ReadLine());
        double f = a;
        if (f < b)
        {
            f = b;
        }
        if (f < c)
        {
            f = c;
        }
        if (f < d)
        {
            f = d;
        }
        if (f < e)
        {
            f = e;
        }
        Console.WriteLine("The greatest variable is: {0}", f);
    }
}