// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter integer: ");
        int a = int.Parse(Console.ReadLine());
        int b = a % 2;
        string c = (b == 0 ? "Even" : "Odd");
        Console.WriteLine("Your integer is: {0}", c);
    }
}