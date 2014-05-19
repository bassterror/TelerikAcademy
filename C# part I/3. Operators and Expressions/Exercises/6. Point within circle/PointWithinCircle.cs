// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class PointWithinCircle
{
    static void Main()
    {
        double r = 5;
        Console.Write("Enter value for \"x\": ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter value for \"y\": ");
        double y = double.Parse(Console.ReadLine());
        bool a = (((x*x) + (y*y)) < r*r);
        string b = (a ? "is" : "isn't");
        Console.WriteLine("Point with coordinates x={0} and y={1} {2} within the circle K(0,5).", x, y, b);
    }
}
