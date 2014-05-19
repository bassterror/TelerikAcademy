//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter four digit integer or bigger:");
        int a = int.Parse(Console.ReadLine());
        bool b = (a / 100) % 10 == 7;
        string c = (b ? "is" : "isn't");
        Console.WriteLine("The third digit of your integer {0} 7", c);
    }
}
