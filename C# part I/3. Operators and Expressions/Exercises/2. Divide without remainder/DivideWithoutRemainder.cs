// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivideWithoutRemainder
{
    static void Main()
    {
        Console.WriteLine("Enter integer: ");
        int a = int.Parse(Console.ReadLine());
        bool b = a % 7 == 0;
        bool c = a % 5 == 0;
        bool d = b && c;
        string e = (d ? "is" : "isn't");
        Console.WriteLine("Your integer {0} dividable by 7 and 5", e);
    }
}
