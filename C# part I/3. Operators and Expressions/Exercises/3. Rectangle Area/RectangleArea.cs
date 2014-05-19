// Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter hight: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter width: ");
        double b = double.Parse(Console.ReadLine());
        double c = (a * b);
        Console.WriteLine("Rectangle area is: {0}", c);
    }
}