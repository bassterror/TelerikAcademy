using System;

class TelerikLogo
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int z = (x / 2) + 1;
        int width = (x + x) + (z + z) - 3;
        int addsides = x / 2;
        int mid = width - (z * 2);

        Console.Write(new string('.', addsides));
        Console.Write("*");
        Console.Write(new string('.', mid));
        Console.Write("*");
        Console.Write(new string('.', addsides));
        Console.WriteLine();
        mid -= 2;

        int dotsBefore = x / 2 - 1;
        int dotsAfter = 0;
        for (int i = 1; i < x - 1; i++)
        {
            if (i <= x / 2)
            {
                Console.Write(new string('.', dotsBefore));
                Console.Write('*');
                Console.Write(new string('.', dotsAfter));
            }
            else
            {
                Console.Write(new string('.', addsides));
            }
            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.', mid));
            Console.Write("*");
            Console.Write(new string('.', i));
            if (i <= x / 2)
            {
                Console.Write(new string('.', dotsAfter));
                Console.Write('*');
                Console.Write(new string('.', dotsBefore));
                dotsBefore--;
                dotsAfter++;
            }
            else
            {
                Console.Write(new string('.', addsides));
            }
            mid -= 2;
            Console.WriteLine();
        }

        Console.Write(new string('.', width / 2));
        Console.Write("*");
        Console.Write(new string('.', width / 2));
        Console.WriteLine();

        int sides = x - 2;
        mid = 1;
        for (int i = 0; i < x - 1; i++)
		{
            Console.Write(new string('.', addsides));
            Console.Write(new string('.', sides));
            Console.Write("*");
            Console.Write(new string('.', mid));
            Console.Write("*");
            Console.Write(new string('.', sides));
            Console.Write(new string('.', addsides));
            mid += 2;
            sides--;
            Console.WriteLine();
		}

        mid -= 4;
        for (int i = 1; i < x - 1; i++)
        {
            Console.Write(new string('.', addsides));
            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.', mid));
            Console.Write("*");
            Console.Write(new string('.', i));
            Console.Write(new string('.', addsides));
            mid -= 2;
            Console.WriteLine();
        }

        Console.Write(new string('.', width / 2));
        Console.Write("*");
        Console.Write(new string('.', width / 2));
        Console.WriteLine();
    }
}