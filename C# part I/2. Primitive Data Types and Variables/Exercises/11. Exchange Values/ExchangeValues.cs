using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;
        c = b;
        b = a;
        a = c;
        Console.WriteLine("Five = {0}, Ten = {1}", a, b);
    }
}
