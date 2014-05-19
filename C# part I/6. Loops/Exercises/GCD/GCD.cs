// Write a program that calculates the greatest common divisor (GCD) of given two numbers.
// Use the Euclidean algorithm (find it in Internet).

using System;

class GCD
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        int c, result, remainder;

        if (a == 0 || b == 0)
        {
            Console.WriteLine("The numbers must be greater than 0!!!");
            Main();
        }
        else
        {
            if (a < b)
            {
                c = a;
                a = b;
                b = c;
            }

            while (true)
            {
                result = a / b;
                remainder = a % b;
                if (remainder != 0)
                {
                    a = b;
                    b = remainder;
                }
                else
                {
                    Console.WriteLine("The GCD is: {0}", b);
                    break;
                }
            }
        }
    }
}