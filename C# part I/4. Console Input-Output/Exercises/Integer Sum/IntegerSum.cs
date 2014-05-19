// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class IntegerSum
{
    static void Main()
    {
        Console.Write("Enter integer for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter integer for b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter integer for c: ");
        int c = int.Parse(Console.ReadLine());
        int d = a + b + c;
        Console.WriteLine("The sum of your integers is: {0}", d);
    }
}