// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;
using System.Threading;
using System.Globalization;

class GreaterNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is: {0}", Math.Max(a,b));
    }
}