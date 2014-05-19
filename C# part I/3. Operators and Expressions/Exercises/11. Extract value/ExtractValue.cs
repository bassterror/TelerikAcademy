// Write an expression that extracts from a given integer i the value of a given bit number b. 
// Example: i=5; b=2  value=1.

using System;

class ExtractValue
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << b;
        int c = mask & a;
        c = c >> b;
        Console.WriteLine("The bit value you looking for is " + c);
    }
}