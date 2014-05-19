// Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;
using System.Threading;
using System.Globalization;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter radius: ");
        double r = double.Parse(Console.ReadLine());

        double pi = 3.1415926;
        double C = 2 * pi * r;
        double A = pi * r * r;

        Console.WriteLine("The perimeter of your circle is: {0:0.00}", C);
        Console.WriteLine("The area of your circle is: {0:0.00}", A);
    }
}