// Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
// Write a program to test this method.

using System;

class PrintHello
{
    static void SayHi(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        SayHi(Console.ReadLine());
    }
}
