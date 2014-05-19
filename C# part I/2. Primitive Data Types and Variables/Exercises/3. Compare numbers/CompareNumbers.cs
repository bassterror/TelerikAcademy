using System;

class CompareNumbers
{
    static void Main()
    {
        Console.WriteLine("Compare the following numbers with precision of 0.000001:\na=7.002 with b=7.006 and\nc=7.000000003 with d=7.000000009\n");

        float a = 7.002f;
        float b = 7.006f;
        float c = 7.000000003f;
        float d = 7.000000009f;
        bool compare1 = (a == b);
        bool compare2 = (c == d);
        
        Console.WriteLine("a=b: {0}\nc=d: {1}", compare1, compare2);
    }
}
