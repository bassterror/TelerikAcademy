using System;

class Triangle
{
    static void Main()
    {
        char a = '\u00A9';
        Console.WriteLine(" " + " " + " " + " " + a);
        Console.WriteLine(" " + " " + " " + a + " " + a);
        Console.WriteLine(" " + " " + a + " " + " " + " " + a);
        Console.WriteLine(" " + a + " " + " " + " " + " " + " " + a);
        Console.WriteLine(new string(a, 9));
    }
}
