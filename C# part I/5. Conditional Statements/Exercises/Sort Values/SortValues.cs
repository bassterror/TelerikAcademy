// Sort 3 real values in descending order using nested if statements.

using System;
using System.Threading;
using System.Globalization;

class SortValues
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.Write("Enter value a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value c: ");
        double c = double.Parse(Console.ReadLine());
        double s = 0;
        double m = 0;
        double l = 0;
        
        if (a > b && a > c)
        {
            l = a;
        }
        else
        {
            if (b > a && b > c)
            {
                l = b;
            }
            else
            {
                l = c;
            }
        }

        if (a > b && a < c)
        {
            m = a;
        }
        else
        {
            if (b > a && b < c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
        }

        if (a < b && a < c)
        {
            s = a;
        }
        else
        {
            if (b < a && b < c)
            {
                s = b;
            }
            else
            {
                s = c;
            }
        }
        Console.WriteLine("{0} > {1} > {2}", l, m, s);
    }
}