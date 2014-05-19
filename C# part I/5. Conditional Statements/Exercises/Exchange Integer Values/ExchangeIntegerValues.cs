// Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class ExchangeIntegerValues
{
    static void Main()
    {
        Console.Write("Enter integer a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter integer b: ");
        int b = int.Parse(Console.ReadLine());
        int c;
        Console.WriteLine("Entered values are: a = {0}, b = {1}", a, b);

        if (a > b)
        {
            c = b;
            b = a;
            a = c;
        }
        Console.WriteLine("The new values are: a = {0}, b = {1}", a, b);
    }
}