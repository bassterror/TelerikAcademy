using System;

class NullValues
{
    static void Main()
    {
        Console.WriteLine("Examples with integer");
        int? a = null;
        Console.WriteLine("Integer with null value: " + a);
        a = 23;
        Console.WriteLine("Integer with value 23: " + a);
        
        Console.WriteLine("\nExamples with double");
        double? b = null;
        Console.WriteLine("Real number with null value: " + b);
        b = 6.78;
        Console.WriteLine("Real number with value 6.78: " + b);
    }
}