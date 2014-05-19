// Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

class ProductSign
{
    static void Main()
    {
        Console.Write("Enter integer a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter integer b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter integer c: ");
        int c = int.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product of the numbers is zero!");
        }
        else
        {
            bool d = true;
            if (a < 0)
            {
                d = !d;
            }
            if (b < 0)
            {
                d = !d;
            }
            if (c < 0)
            {
                d = !d;
            }

            Console.WriteLine("The product of the numbers is {0}!", d ? "positive" : "negative");
        }
    }
}