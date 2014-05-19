using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(".");
        }
        for (int i = n + 1; i <= n * 2; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        
        for (int i = 1; i <= n - 1; i++)
        {
            for (int j = n; j > 0; j--)
            {
                if (i == j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            for (int k = 1; k <= n; k++)
            {
                if (k == n)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        
        for (int i = 1; i <= n*2; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}