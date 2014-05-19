using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i != j)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }

        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j < n; j++)
            {
                if (i != j)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}
